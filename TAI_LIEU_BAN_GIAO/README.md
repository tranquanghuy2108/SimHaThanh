# BỘ TÀI LIỆU BÀN GIAO SOURCE CODE SIM HÀ THÀNH

**Phiên bản tài liệu:** 1.0  
**Ngày rà soát:** 10/11/2026  
**Phạm vi:** repository `sim-ha-thanh`, solution `WebSIMManager/WebSIMManager.sln`

## 1. Mục đích

Bộ tài liệu này giúp đơn vị tiếp nhận hiểu cấu trúc source, kiến trúc, cấu hình, dữ liệu, tích hợp và cách vận hành hệ thống. Nội dung được tổng hợp từ source tại thời điểm rà soát; các thông tin hạ tầng thực tế, tài khoản và bí mật phải được hai bên xác nhận bằng biên bản riêng.

## 2. Danh mục tài liệu

1. [01-TONG-QUAN-VA-KIEN-TRUC.md](01-TONG-QUAN-VA-KIEN-TRUC.md): phạm vi nghiệp vụ, thành phần và kiến trúc solution.
2. [02-CAI-DAT-CAU-HINH-TRIEN-KHAI.md](02-CAI-DAT-CAU-HINH-TRIEN-KHAI.md): yêu cầu môi trường, cấu hình, build, database và triển khai.
3. [03-DU-LIEU-VA-TICH-HOP.md](03-DU-LIEU-VA-TICH-HOP.md): mô hình dữ liệu, migration, stored procedure và hệ thống ngoài.
4. [04-VAN-HANH-VA-XU-LY-SU-CO.md](04-VAN-HANH-VA-XU-LY-SU-CO.md): web/API/worker, log, backup và runbook sự cố.
5. [05-CHECKLIST-BAN-GIAO.md](05-CHECKLIST-BAN-GIAO.md): danh sách hiện vật, quyền truy cập và tiêu chí nghiệm thu.
6. [06-RUI-RO-VA-KHUYEN-NGHI.md](06-RUI-RO-VA-KHUYEN-NGHI.md): phát hiện kỹ thuật và thứ tự ưu tiên xử lý.
7. [appsettings.Handover.example.json](appsettings.Handover.example.json): mẫu khóa cấu hình, không chứa secret.

## 3. Tóm tắt nhanh cho đơn vị tiếp nhận

- Nền tảng chính: ASP.NET Core MVC/Web API, .NET 7, EF Core 7, MySQL (Pomelo), ASP.NET Core Identity.
- Solution khai báo 12 project: 3 ứng dụng chạy chính (`WebSIMManager`, `WebClient`, `WebSIMAPI`), 4 worker, và 5 thư viện/tầng dùng chung.
- Chức năng chính: quản lý kho SIM, đơn hỏi mua/xuất SIM, khách hàng/đại lý, kho vật tư, công nợ–quỹ–ngân hàng, đấu giá, tin tức, thông báo, báo cáo và API ứng dụng.
- Database là thành phần bắt buộc; source có EF Core migration nhưng còn phụ thuộc nhiều stored procedure MySQL cần bàn giao cùng bản dump/schema.
- Các worker được thiết kế chạy Windows Service; phần lớn thực hiện một lượt nghiệp vụ rồi tự dừng, do đó cần Task Scheduler/orchestrator gọi theo lịch.
- Hệ thống có tích hợp VNPT, SMTP, Sendbird, Telegram/WhatsMate và Zalo SDK. Cần bàn giao hợp đồng/tài khoản/whitelist tương ứng.
- Source hiện chứa thông tin nhạy cảm trong một số file. Phải thu hồi/xoay vòng toàn bộ credential trước khi bàn giao và đưa secret ra khỏi Git.

## 4. Giới hạn của lần rà soát

- Không có môi trường MySQL và tài khoản dịch vụ ngoài để chạy kiểm thử end-to-end.
- Không thấy bộ test tự động trong solution.
- Lệnh `dotnet build --no-restore` đã được chạy nhưng không kết thúc trong thời gian kiểm tra và phải dừng; trước khi dừng ghi nhận cảnh báo .NET 7 hết hỗ trợ, dependency DataTables được resolve khác phiên bản yêu cầu và package Web API cũ có nguy cơ không tương thích.
- Tài liệu không sao chép mật khẩu, token, connection string hoặc API key từ source.

