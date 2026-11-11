# 04. VẬN HÀNH VÀ XỬ LÝ SỰ CỐ

## 1. Danh mục tiến trình

| Tiến trình | Kiểu chạy | Dấu hiệu hoạt động |
|---|---|---|
| WebSIMManager | Web service lâu dài | CMS phản hồi HTTPS, đăng nhập được |
| WebClient | Web service lâu dài | Website public phản hồi HTTPS |
| WebSIMAPI | Web service lâu dài | Swagger/API phản hồi, auth đúng |
| WS_GetSimVNPT | Job dài/nặng | Log số SIM được thêm, dữ liệu kho tăng |
| WS_CheckSimVNPT | Job một lần | Log số SIM đã kiểm tra/xóa rồi process dừng |
| WS_SendMail | Job một lần | Log mail/đơn/notification rồi process dừng |
| WS_UpdatePTSim | Job một lần | Log cập nhật `HadSimData` rồi process dừng |

Không cấu hình Windows Service kiểu tự restart vô hạn cho job một lần mà không có khoảng lịch, vì có thể chạy lặp nghiệp vụ liên tục. Nên dùng Task Scheduler, Hangfire/Quartz hoặc job orchestrator với khóa chống chạy song song.

## 2. Lịch chạy cần chủ sở hữu xác nhận

Source không phải nguồn đáng tin cậy về lịch production. Khi bàn giao phải ghi rõ cho từng worker:

- Tần suất và khung giờ.
- Timeout tối đa và retry policy.
- Có được chạy song song hay không.
- Người nhận cảnh báo khi thất bại.
- Điều kiện chạy bù và cách chống trùng.

## 3. Log và giám sát

- Worker check/update/mail ghi console và file `logs/app.txt`; cần cấp quyền ghi, rotation và retention.
- Web dùng exception handler ở production; lỗi nghiệp vụ cũng có entity `LogException`/`LogAction` trong DB.
- Nên bổ sung structured logging, correlation ID, health check `/health`, metric thời gian phản hồi, DB pool, số lỗi 4xx/5xx và kết quả từng job.
- Không ghi password, token, full connection string, JWT hoặc dữ liệu cá nhân vào log.

## 4. Runbook sự cố

### Web/API không khởi động

1. Kiểm tra runtime .NET, biến `ASPNETCORE_ENVIRONMENT`, port và quyền bind.
2. Kiểm tra secret/config đã được inject và DB có thể kết nối.
3. Kiểm tra migration bị khóa/lỗi; không chạy nhiều instance cùng lúc.
4. Đọc log ứng dụng/IIS/Event Viewer.
5. Nếu liên quan migration, dừng rollout và restore/rollback theo kế hoạch đã thử trước.

### Đăng nhập/API trả 401/403

1. Kiểm tra giờ máy chủ và issuer/audience/key giữa nơi phát và nơi xác thực token.
2. Kiểm tra role/group trong DB và attribute `[Authorize]` của endpoint.
3. Với CMS, kiểm tra HTTPS/proxy vì cookie luôn Secure và SameSite=None.
4. Không tắt authorization để chữa cháy; dùng tài khoản test với role xác định.

### Báo cáo/tìm SIM lỗi

1. Xác nhận stored procedure tồn tại và user DB có quyền execute.
2. So sánh signature/thứ tự tham số với source.
3. Kiểm tra collation, timezone, dữ liệu null và model kết quả.
4. Chạy procedure trên bản sao staging trước khi sửa production.

### Worker VNPT lỗi hoặc xóa bất thường

1. Dừng lịch/job ngay, giữ log và snapshot DB.
2. Kiểm tra endpoint, credential, quota và thay đổi response của VNPT.
3. Không chạy lại `WS_CheckSimVNPT` cho đến khi xác nhận lỗi “không có kết quả” không phải lỗi tích hợp.
4. Restore dữ liệu bị xóa từ backup/audit nếu cần.

### Mail gửi trùng

1. Dừng `WS_SendMail` và kiểm tra số instance/lịch chạy.
2. Đối chiếu đơn, notification và CashBook được tạo cùng thời điểm.
3. Chỉ chạy bù sau khi xác định record đã xử lý; về dài hạn bổ sung idempotency key/trạng thái job.

## 5. Backup/restore

- Backup DB định kỳ, mã hóa và lưu khác máy chủ; kiểm tra restore thực tế.
- Backup thư mục upload/static do người dùng tạo.
- Lưu version/tag source, artifact, appsettings template và manifest dependency.
- Trước release: backup DB + upload; sau release: ghi migration, artifact checksum và người thực hiện.

## 6. Rollback tối thiểu

1. Dừng worker.
2. Chuyển traffic về artifact trước.
3. Nếu schema tương thích ngược, giữ DB; nếu không, dùng script down/restore đã kiểm thử.
4. Khôi phục upload/config nếu release thay đổi.
5. Smoke test đăng nhập, tìm SIM, đơn và API trước khi mở traffic.

