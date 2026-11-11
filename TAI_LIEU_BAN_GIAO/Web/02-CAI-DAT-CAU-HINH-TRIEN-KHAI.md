# 02. CÀI ĐẶT, CẤU HÌNH VÀ TRIỂN KHAI

## 1. Yêu cầu môi trường

- Windows Server được ưu tiên vì worker gọi `UseWindowsService()`; web có thể chạy trên Windows/IIS hoặc Linux/systemd sau khi kiểm thử.
- .NET SDK/ASP.NET Core Runtime tương thích `net7.0`. Tuy nhiên .NET 7 đã hết hỗ trợ; kế hoạch gần nhất nên nâng lên .NET 8 LTS hoặc phiên bản LTS đang được tổ chức phê duyệt.
- MySQL tương thích Pomelo EF Core 7; cần ghi chính xác phiên bản production vào biên bản bàn giao.
- Reverse proxy/IIS phải chuyển `X-Forwarded-For` và `X-Forwarded-Proto`; HTTPS bắt buộc vì cookie đặt `SecurePolicy=Always`.
- Quyền ghi cho thư mục upload và log worker.

## 2. Cấu hình bắt buộc

Dùng [appsettings.Handover.example.json](appsettings.Handover.example.json) làm danh mục khóa. Tuyệt đối không commit giá trị production.

| Khóa | Dùng bởi | Mô tả |
|---|---|---|
| `Settings:ConnectionStr` | CMS, WebClient, API | Chuỗi kết nối MySQL |
| `Settings:Key` | API | Khóa ký JWT, độ dài đủ mạnh |
| `Settings:Issuer` | API | JWT issuer |
| `Settings:Audience` | API | JWT audience; code có đọc khóa này dù model `Settings` chưa khai báo |
| `MailSetting:*` | WS_SendMail | SMTP address/display name/password/host/port |
| `DauGiaContent:*` | WS_SendMail | Tiêu đề/nội dung mail đấu giá |
| `TraGopContent:*` | WS_SendMail | Tiêu đề/nội dung mail nhắc trả góp |

VNPT, Sendbird, Telegram/WhatsMate đang có cấu hình trong code helper/call API. Cần chuyển các giá trị này sang environment variable hoặc secret store trước bàn giao.

Khuyến nghị thứ tự ưu tiên cấu hình: secret manager/environment variable > file cấu hình ngoài thư mục deploy > `appsettings.{Environment}.json`. Không dùng `appsettings.json` trong Git cho secret.

## 3. Chuẩn bị database

1. Nhận bản backup production đã mã hóa và kiểm tra checksum.
2. Tạo database/user riêng cho từng môi trường, cấp quyền tối thiểu.
3. Restore schema, data và toàn bộ stored procedure.
4. Cập nhật connection string bằng secret store.
5. Sao lưu lại trước khi chạy ứng dụng lần đầu.
6. Kiểm tra bảng `__EFMigrationsHistory` khớp source.

CMS và WebClient tự chạy migration lúc startup. Không nên để nhiều instance đồng thời chạy migration trong production; nên chuyển thành bước deploy riêng và dùng tài khoản DB tách quyền DDL/DML.

Lệnh tham khảo sau khi đã có cấu hình hợp lệ:

```bash
dotnet restore WebSIMManager/WebSIMManager.sln
dotnet build WebSIMManager/WebSIMManager.sln -c Release
dotnet ef database update --project WebSIMManager/EFCoreMySQL --startup-project WebSIMManager/WebSIMManager
```

## 4. Build và publish

```bash
dotnet publish WebSIMManager/WebSIMManager/WebSIMManager.csproj -c Release -o ./artifacts/cms
dotnet publish WebSIMManager/WebClient/WebClient.csproj -c Release -o ./artifacts/webclient
dotnet publish WebSIMManager/WebSIMAPI/WebSIMAPI.csproj -c Release -o ./artifacts/api
dotnet publish WebSIMManager/WorkerService/WS_GetSimVNPT.csproj -c Release -o ./artifacts/get-sim
dotnet publish WebSIMManager/WS_CheckSimVNPT/WS_CheckSimVNPT.csproj -c Release -o ./artifacts/check-sim
dotnet publish WebSIMManager/WS_SendMail/WS_SendMail.csproj -c Release -o ./artifacts/send-mail
```

Không dùng sẵn thư mục `WebSIMManager/publish` làm nguồn phát hành nếu chưa đối chiếu commit/checksum. Nên build artifact từ tag bàn giao bằng pipeline tái lập được.

## 5. Trình tự triển khai đề xuất

1. Chốt tag/commit bàn giao và tạo checksum source/artifact.
2. Backup database, upload và cấu hình hiện tại.
3. Dừng worker/job ghi dữ liệu.
4. Chạy migration có kiểm soát.
5. Deploy API, CMS, WebClient; chạy health/smoke test.
6. Deploy worker nhưng chỉ bật lịch sau khi xác nhận web/API ổn định.
7. Theo dõi log, DB connection, lỗi 5xx và tài nguyên ít nhất một chu kỳ nghiệp vụ.
8. Ghi biên bản rollback point và kết quả nghiệm thu.

## 6. Smoke test tối thiểu

- CMS: đăng nhập, phân quyền, tìm SIM, tạo/sửa đơn thử nghiệm, xem một báo cáo.
- Website: trang chủ, tìm SIM, xem tin tức, tạo đơn trong môi trường test.
- API: Swagger tải được; login trả token; endpoint có quyền trả 200 và không token trả 401.
- DB: migration history đúng; stored procedure báo cáo/tìm kiếm chạy được.
- Worker: chạy trên dữ liệu test, log đầy đủ, tự dừng đúng trạng thái; không xóa dữ liệu ngoài tập test.
- Upload: file hợp lệ được lưu, file quá cỡ/không hợp lệ bị từ chối sau khi bổ sung giới hạn.

