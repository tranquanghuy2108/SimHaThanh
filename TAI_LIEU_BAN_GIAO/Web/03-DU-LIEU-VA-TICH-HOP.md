# 03. DỮ LIỆU VÀ TÍCH HỢP

## 1. Tổng quan dữ liệu

`SIMCenterDbContext` kế thừa `IdentityDbContext<AppUser, AppRole, Guid>`. Source có 62 file entity và 91 file migration/migration metadata tại thời điểm kiểm kê. Các miền dữ liệu chính:

| Miền | Entity tiêu biểu |
|---|---|
| Identity/phân quyền | `AppUser`, `AppRole`, `AppGroup`, `AppUserGroup`, `AppRoleGroup` |
| SIM | `SIMDetail`, `SIMNetwork`, `SIMType`, `TypeOfSIM`, `ProductType`, `FlashSale` |
| Bán hàng | `SIMOrder`, `SIMWithOrder`, `GoodsDeliveryNoteOfSim`, `SimInfosInOrder` |
| Kho vật tư | `Warehouse`, `Material`, `MaterialType`, `MaterialGroup`, `MaterialSeria`, phiếu nhập/xuất |
| Tài chính | `Debt*`, `Receipt`, `TransferMoney`, `CashBook`, `Bank`, `Shipping` |
| Nội dung/cộng đồng | `News`, `Post`, `PostComment`, `PostLikes`, `PostImage*`, `Category`, `Tag` |
| Đấu giá/thông báo | `Auction`, `AuctionUserBidding`, `Notification`, `NotificationUser` |
| Hệ thống | `SystemConfig`, `LogAction`, `LogException`, `SystemAction`, `CountIPLogin` |

Nhiều report model và view model được cấu hình `HasNoKey().ToView(null)` để nhận kết quả stored procedure.

## 2. Stored procedure bắt buộc

Source gọi nhiều stored procedure nhưng định nghĩa không nằm đầy đủ trong migration. Bản dump database bàn giao phải gồm routine và quyền `EXECUTE`. Danh sách quan sát được gồm:

- Tìm kiếm/kho SIM: `GetSIMOnHome`, `GetSIMOnHomePaging`, `GetSIMForApp`, `GetSIMDataForApp`, `GetSimOfAgentOnApp`, `GetSimOfAgentOnCMS`, `GetSimForCheckSimVNPT`, `GetSimPTOfMenhChu`.
- Công nợ: `GetAgencyGroupReport`, `GetDebtStaffDetail`, `GetDebtBankDetail`, `GetDebtAgentDetail`, `GetDebtShippingDetail`, `GetDebtDetail`.
- Báo cáo: `GetSimInventoryCompanyReport`, `GetWarehouseOutboundReport`, `GetSoldSimReport`, `GetProfitSituationReport`, `GetCashFundBalanceReport`, `GetBankFundBalanceReport`, `GetShippingFundBalanceReport`, `GetBankBalanceReport`, `GetProfitStatementReport`, `GetOrderProfitReport`, `GetBankTransactionReport`, `GetCashFundReport`, `GetSimInventoryReport`, `GetOrderImportExportReport`, `GetInventoryMovementReport`, `GetCustomerDebtReport`, `GetLogSYS`.

Khi restore cần kiểm tra collation/timezone, `DEFINER` của routine và `sql_mode` để tránh lỗi khác môi trường.

## 3. Tích hợp ngoài

| Tích hợp | Mục đích quan sát được | Cần bàn giao |
|---|---|---|
| VNPT sandbox/payment API | Lấy/kiểm tra kho SIM và nghiệp vụ gói cước | endpoint production, credential, IP whitelist, tài liệu hợp đồng, quota |
| SMTP/Google SMTP | Mail đấu giá và nhắc trả góp | mailbox/service account, app password mới, sender policy |
| Sendbird | Kênh chat/message | app ID, API token mới, dashboard owner |
| Telegram/WhatsMate | Gửi thông báo/tin nhắn | bot/channel/account, token mới, quota |
| Zalo SDK | Khả năng tích hợp Zalo trong Commons | app/account, phạm vi sử dụng thực tế |

Không bàn giao credential cũ qua Git/email. Hai bên nên tạo credential mới dưới quyền sở hữu của bên nhận, kiểm thử, sau đó thu hồi credential bên giao.

## 4. Backup và dữ liệu bàn giao

Gói database tối thiểu gồm:

- Schema, bảng, index, foreign key, dữ liệu cần thiết.
- Stored procedure/routine, trigger, event scheduler nếu có.
- Danh sách user/quyền ở dạng mô tả, không xuất mật khẩu thô.
- Phiên bản MySQL, charset, collation, timezone và `sql_mode`.
- Checksum file backup, thời điểm chốt dữ liệu và hướng dẫn restore đã kiểm chứng.
- Chính sách ẩn/mã hóa dữ liệu cá nhân nếu dùng bản production cho UAT.

## 5. Lưu ý tính toàn vẹn

- `WS_CheckSimVNPT` có hành vi xóa SIM khỏi `SIMDetails` khi VNPT không trả kết quả; phải thử trên staging và có backup trước khi chạy.
- `WS_SendMail` vừa gửi mail vừa tạo đơn, notification và bút toán quỹ; chạy lặp có nguy cơ tạo dữ liệu trùng nếu thiếu cơ chế idempotency.
- Một số worker gọi `SaveChanges()` nhiều lần trong vòng lặp, chưa có transaction bao toàn nghiệp vụ.
- Worker và ứng dụng dùng `DateTime.Now`; phải thống nhất timezone máy chủ với nghiệp vụ Việt Nam.

