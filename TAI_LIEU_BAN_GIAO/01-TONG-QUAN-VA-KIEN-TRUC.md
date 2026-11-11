# 01. TỔNG QUAN VÀ KIẾN TRÚC

## 1. Phạm vi nghiệp vụ

Hệ thống Sim Hà Thành là nền tảng quản trị và kinh doanh SIM, gồm các nhóm chức năng quan sát được trong controller, entity và view:

- Kho SIM, nhà mạng, loại sản phẩm, loại/số đẹp, SIM data/eSIM và SIM ký gửi.
- Đơn hỏi mua, xuất SIM, phiếu xuất SIM, trả góp, flash sale và đấu giá.
- Khách hàng, đại lý, cộng tác viên/nhóm cộng tác viên, chiết khấu và phân quyền.
- Kho vật tư: mặt hàng, nhóm/loại, serial, phiếu nhập và phiếu xuất.
- Công nợ, phiếu thu, chuyển tiền, sổ quỹ, ngân hàng và đơn vị vận chuyển.
- Tin tức, bài viết, tương tác, thông báo và liên hệ hỗ trợ.
- Báo cáo tồn kho, xuất nhập, bán hàng, lợi nhuận, quỹ, ngân hàng, công nợ và nhật ký hệ thống.
- Tra cứu/chấm điểm SIM phong thủy.

## 2. Kiến trúc logic

```text
Người dùng CMS / Website / Ứng dụng
            |
            v
WebSIMManager / WebClient / WebSIMAPI
            |
            v
Repositories + Services
            |
            v
EFCoreMySQL (DbContext, Entity, Migration) ---> MySQL + Stored Procedures
            ^
            |
Windows Workers ----> VNPT / SMTP / các dịch vụ ngoài
```

Đây là kiến trúc nhiều project theo lớp, nhưng business logic phân bổ chủ yếu ở repository, controller và worker. `Services` hiện thiên về upload/mail; repository truy cập trực tiếp `SIMCenterDbContext`.

## 3. Thành phần trong solution

| Project | Loại | Vai trò |
|---|---|---|
| `WebSIMManager` | ASP.NET Core MVC | CMS/quản trị nội bộ; cookie authentication; 27 controller |
| `WebClient` | ASP.NET Core MVC | Website khách hàng/public |
| `WebSIMAPI` | ASP.NET Core Web API | API cho client/app; JWT; Swagger; 10 controller |
| `WorkerService` (`WS_GetSimVNPT`) | Worker | Lấy SIM từ VNPT, định dạng/chấm điểm và ghi vào kho |
| `WS_CheckSimVNPT` | Worker | Kiểm tra SIM còn tồn tại ở VNPT; xóa SIM không còn |
| `WS_SendMail` | Worker | Mail/notification nhắc nợ và xử lý kết quả đấu giá |
| `WS_UpdatePTSim` | Worker | Cập nhật phân loại/trạng thái dữ liệu SIM trong đơn |
| `Commons` | Thư viện* | helper, enum, model tích hợp, gọi VNPT/Sendbird/Telegram |
| `Models` | Thư viện* | request/response, view model và lớp cấu hình |
| `EFCoreMySQL` | Thư viện* | DbContext, 62 entity, migration và hạ tầng repository cơ sở |
| `Repositories` | Thư viện* | interface và 20 implementation truy cập dữ liệu/nghiệp vụ |
| `Services` | Thư viện* | dịch vụ upload local và mail |

`*` Các project thư viện đang khai báo `OutputType=Exe` và có `Program.cs` mẫu; nên chuẩn hóa về class library.

Ngoài solution còn có `WebApplicationAPI`, `WorkerService1`, `WorkerServiceSimHT` và thư mục `publish`. Đây có vẻ là project mẫu/cũ hoặc artifact; cần chủ sở hữu xác nhận giữ hay loại bỏ.

## 4. Luồng khởi động

### CMS và WebClient

1. Đọc section `Settings` từ `appsettings.json`.
2. Đăng ký MySQL `SIMCenterDbContext` bằng Pomelo.
3. Đăng ký ASP.NET Core Identity và các repository/service qua DI.
4. Cấu hình session 2 giờ, cookie Secure/SameSite=None và forwarded headers.
5. Tự gọi `Database.Migrate()` khi ứng dụng khởi động.
6. Khởi tạo middleware static file, session, authentication, routing và authorization.

### API

1. Kết nối cùng database.
2. Xác thực JWT bằng `Settings:Issuer`, `Settings:Audience`, `Settings:Key`.
3. Đăng ký Identity Core, repository, Swagger và controller.
4. Phần lớn controller có `[Authorize]`; login/register là anonymous.

Lưu ý: JWT đang đặt `ValidateLifetime = false`, nghĩa là token hết hạn vẫn có thể được chấp nhận. CORS cuối pipeline cho phép mọi origin/method/header, làm mất tác dụng policy origin được khai báo trước đó.

## 5. Xác thực và phân quyền

- CMS/WebClient dùng ASP.NET Core Identity với khóa người dùng kiểu `Guid`.
- CMS dùng cookie authentication và role name tiếng Việt như “Xem kho sim”, “Tạo mới đơn hỏi mua”, “Duyệt công nợ”.
- API dùng JWT Bearer; khóa ký hiện lấy từ cấu hình.
- Tài khoản bị khóa rất lâu sau 5 lần đăng nhập sai (`365 * 100` ngày); cần xác nhận đây có phải chủ đích nghiệp vụ.
- Một số attribute phân quyền trong CMS đang bị comment; cần kiểm tra ma trận quyền thực tế trước nghiệm thu.

## 6. Quy ước source cần biết

- Namespace và tên project chưa đồng nhất ở một số worker (`WS_SendMail` dùng namespace `WS_CheckSimVNPT`).
- Có file mang khoảng trắng trong tên như `DbFactory .cs`, `LogExceptionRepository .cs`; lưu ý khi viết script CI/CD.
- Culture mặc định của CMS là `en-US`, dù giao diện/nghiệp vụ dùng tiếng Việt. Điều này ảnh hưởng parse/format số và ngày.
- CMS bỏ giới hạn request/multipart; cần giới hạn lại theo nhu cầu upload thực tế.

