# 05. CHECKLIST BÀN GIAO

Điền người phụ trách, ngày và bằng chứng cho từng mục. Không đánh dấu hoàn tất chỉ dựa trên việc “đã gửi file”.

## A. Source và quyền sở hữu

- [ ] Repository đã chuyển quyền owner/maintainer cho bên nhận.
- [ ] Chốt tag/commit bàn giao: `________________`.
- [ ] Branch mặc định, branch protection và quy trình merge đã thống nhất.
- [ ] Danh sách project ngoài solution (`WebApplicationAPI`, `WorkerService1`, `WorkerServiceSimHT`, `publish`) đã có quyết định giữ/xóa.
- [ ] License của source và dependency thương mại đã được xác nhận.
- [ ] Không còn file build, backup, `.DS_Store`, `.vscode` cá nhân hoặc secret không cần thiết trong gói bàn giao.

## B. Build và kiểm thử

- [ ] Có máy/pipeline sạch build thành công toàn solution.
- [ ] Ghi phiên bản SDK/runtime, MySQL và OS.
- [ ] Đã xử lý hoặc chấp nhận bằng văn bản các warning dependency.
- [ ] Có artifact checksum và khả năng tái tạo từ tag.
- [ ] Có kết quả smoke/UAT cho CMS, WebClient, API và từng worker.
- [ ] Đã lập kế hoạch nâng khỏi .NET 7.

## C. Database

- [ ] Bản backup mã hóa và checksum đã bàn giao qua kênh an toàn.
- [ ] Restore thử thành công trên môi trường mới.
- [ ] Đã gồm stored procedure, trigger/event (nếu có) và migration history.
- [ ] Phiên bản MySQL, charset, collation, timezone, `sql_mode` đã ghi nhận.
- [ ] Tài khoản DB mới thuộc bên nhận; tài khoản cũ đã thu hồi.
- [ ] Chính sách backup, retention và RPO/RTO đã thống nhất.

## D. Hạ tầng và triển khai

- [ ] DNS, domain, TLS certificate và quyền gia hạn đã chuyển giao.
- [ ] Server/IIS/reverse proxy/firewall/port/IP whitelist đã lập danh mục.
- [ ] Pipeline CI/CD, biến môi trường và quyền deploy đã chuyển giao.
- [ ] Thư mục upload/log có owner, permission, dung lượng và retention phù hợp.
- [ ] Có sơ đồ môi trường dev/UAT/prod và rollback runbook.
- [ ] Có danh sách lịch worker, timeout, retry, chống song song và người nhận cảnh báo.

## E. Tài khoản và tích hợp

- [ ] VNPT: tài khoản, hợp đồng, endpoint, quota, whitelist và đầu mối hỗ trợ.
- [ ] SMTP/mailbox: đổi owner, tạo credential mới, kiểm tra sender.
- [ ] Sendbird, Telegram/WhatsMate, Zalo: đổi owner và credential mới.
- [ ] Tất cả password/token/API key/connection string cũ đã xoay vòng.
- [ ] Secret production không còn trong repository hoặc lịch sử Git được phân phối.
- [ ] Danh sách webhook/callback URL đã cập nhật sang hạ tầng mới.

## F. Nghiệp vụ và vận hành

- [ ] Ma trận role/quyền đã được xuất và người nghiệp vụ duyệt.
- [ ] Tài khoản quản trị khẩn cấp thuộc bên nhận, bật MFA nếu nền tảng hỗ trợ.
- [ ] Quy trình đơn hàng, xuất SIM, công nợ, kho, đấu giá và báo cáo đã demo.
- [ ] Quy tắc giá, hoa hồng, tiền cọc, trạng thái đơn và dữ liệu hệ thống đã giải thích.
- [ ] Dashboard/log/alert và đầu mối on-call đã bàn giao.
- [ ] Thời gian hỗ trợ sau bàn giao và SLA xử lý lỗi đã ký nhận.

## G. Biên bản nghiệm thu kỹ thuật

| Nội dung | Kết quả | Bằng chứng/Ghi chú |
|---|---|---|
| Build từ tag sạch |  |  |
| Restore DB |  |  |
| CMS/WebClient hoạt động |  |  |
| API auth và endpoint chính |  |  |
| Stored procedure/báo cáo |  |  |
| Worker trên dữ liệu test |  |  |
| Backup/rollback thử nghiệm |  |  |
| Credential đã xoay vòng |  |  |

