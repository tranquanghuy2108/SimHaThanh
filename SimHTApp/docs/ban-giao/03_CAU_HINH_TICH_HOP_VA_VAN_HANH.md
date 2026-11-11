# Cấu hình tích hợp và vận hành

## Nguồn cấu hình chính

| File | Nội dung | Cách xử lý khi bàn giao |
| --- | --- | --- |
| `constants/Config.js` | Base URL, Sendbird app ID/token, support ID và hằng số nghiệp vụ | Tách token khỏi source; phân môi trường dev/staging/prod |
| `app.json` | Expo app, package/bundle ID, permission, SDK và EAS project ID | Bên nhận xác nhận owner/project access |
| `eas.json` | Profile build/submit và App Store Connect metadata | Thay khóa/issuer khi chuyển tài khoản |
| `google-services.json` | Firebase Android | Xác nhận project ownership và app registration |
| `android/app/google-services.json` | Bản Firebase được Gradle sử dụng | Đồng bộ với file root hoặc chỉ giữ một nguồn |
| `fcm.json` | Thông tin FCM nhạy cảm | Chuyển qua secret manager; thu hồi nếu đã chia sẻ rộng |
| `credentials.json` | Ánh xạ Android keystore và mật khẩu | Không commit; bàn giao riêng hoặc tạo lại theo quyền sở hữu |
| `credentials/android/keystore.jks` | Khóa ký Android | Tài sản phát hành tối quan trọng; sao lưu mã hóa và giới hạn quyền |
| `ios/SimHThnh/SimHThnh.entitlements` | APNs environment | Kiểm tra development/production khi archive |

## Backend REST API

Client gọi `https://api.simhathanh.vn`. Endpoint được gọi trực tiếp trong từng context, chủ yếu theo các nhóm:

- `/api/account`: xác thực, đăng ký, xóa tài khoản, đổi mật khẩu, hồ sơ, ngân hàng và cấu hình.
- `/api/sim`: tìm kiếm, danh mục, SIM của đại lý, SIM data, đơn hàng, nhà mạng, loại SIM và khuyến mại.
- `/api/sim-phong-thuy`: xem điểm, tìm kiếm và định giá.
- `/api/auction`: phiên đấu giá, danh sách và đặt giá.
- `/api/tra-gop`: cấu hình và danh sách trả góp.
- `/api/collaborators`: nhóm, yêu cầu tham gia và thành viên.
- `/api/CashBook`: số dư, ký quỹ và giao dịch.
- `/api/post`: bài viết, ảnh, bình luận, thích, báo cáo và chặn.
- `/api/noti`, `/api/vnpt`: thông báo và gói VNPT.

Repository không chứa đặc tả OpenAPI/Swagger, schema response hay backend source. Bên giao cần cung cấp URL tài liệu API, tài khoản test, mã lỗi chuẩn, SLA và đầu mối backend. Nếu chưa có, nên xuất OpenAPI từ backend trước khi kết thúc bàn giao.

## Sendbird

Ứng dụng dùng hai thế hệ SDK: `@sendbird/chat`/UIKit và package `sendbird` v3 cho một số luồng moderation. `SendbirdUIKitContainer` được khởi tạo ở `App.js`. Adapter `SendBirdComponents/ExpoNativeModule.js` nối clipboard, file, media, notification, player và recorder với Expo module.

Các tài sản cần bàn giao qua quyền quản trị:

- Sendbird Application và App ID.
- Tài khoản dashboard và vai trò của bên nhận.
- User hỗ trợ `supportSimHT` và lịch trực.
- Push configuration cho FCM/APNs.
- Chính sách retention, moderation và quota/gói dịch vụ.

`SEND_BIRD_API_TOKEN` đang được hard-code trong client. Token API quản trị không được nhúng vào mobile app vì có thể bị trích xuất từ bundle. Cần thu hồi token hiện tại, chuyển thao tác quản trị sang backend và chỉ để App ID công khai ở client.

## Firebase và push notification

Android sử dụng plugin Google Services và file `android/app/google-services.json`. Expo Notifications cung cấp device token cho Sendbird UIKit; riêng Expo Go Android trả về null theo nhánh fallback. iOS cần APNs entitlement/profile đúng và cấu hình APNs trong Sendbird.

Checklist push:

1. Xác nhận Firebase project và Android app `com.simhathanh.app` thuộc tài khoản bàn giao.
2. Xác nhận FCM credential đang cấu hình tại Sendbird/EAS.
3. Xác nhận Apple key/certificate APNs và bundle ID.
4. Test foreground, background và app bị kill trên thiết bị thật.
5. Test refresh token sau khi cài lại ứng dụng.

## Quyền thiết bị và quyền riêng tư

Ứng dụng yêu cầu camera và thư viện ảnh/video cho avatar, bài đăng và chat. `app.json` chặn các quyền đọc toàn bộ media và `RECORD_AUDIO`; voice message trong Sendbird cũng bị tắt. iOS không cho arbitrary network loads, chỉ cho local networking.

Các thay đổi permission phải được đối chiếu với App Store privacy manifest, Google Play Data safety và nội dung chính sách trong ứng dụng.

## Kiểm duyệt nội dung người dùng

`utils/contentModeration.js` lọc một tập từ khóa cơ bản trước khi đăng. `utils/moderationService.js` hỗ trợ báo cáo bài viết, chặn người dùng và gửi báo cáo tới kênh Sendbird hỗ trợ. Quy trình vận hành chi tiết nằm tại `docs/UGC_MODERATION_RUNBOOK.md` và yêu cầu xử lý trong 24 giờ.

Bộ lọc phía client chỉ là lớp hỗ trợ và có thể bị vượt qua. Backend vẫn phải kiểm tra nội dung, phân quyền gỡ nội dung, ghi audit log và áp dụng rate limit.

## Logging giám sát và sao lưu

Source chưa thể hiện tích hợp crash reporting/observability như Sentry, Crashlytics hoặc log tập trung. Khi bàn giao cần thống nhất:

- nơi theo dõi lỗi mobile, API và Sendbird;
- cách loại bỏ token/PII khỏi log;
- cảnh báo tỷ lệ lỗi đăng nhập, tạo đơn, thanh toán/ký quỹ và push;
- chính sách backup dữ liệu backend, không nằm trong repository mobile;
- quy trình incident và đầu mối liên hệ.

## Ma trận quyền truy cập cần chuyển giao

| Hệ thống | Quyền tối thiểu cho bên nhận | Xác nhận |
| --- | --- | --- |
| Git repository | Maintainer/Owner | Chưa xác nhận |
| Expo/EAS project | Owner/Admin hoặc chuyển project | Chưa xác nhận |
| Google Play Console | Release/Admin phù hợp | Chưa xác nhận |
| Apple Developer và App Store Connect | App Manager/Developer, Certificates khi cần | Chưa xác nhận |
| Firebase | Editor/Admin theo chính sách | Chưa xác nhận |
| Sendbird | Dashboard admin phù hợp | Chưa xác nhận |
| Backend/hosting/database | Theo phạm vi vận hành | Không nằm trong source này |
| Domain/DNS/SSL | Quản trị `simhathanh.vn` nếu thuộc phạm vi | Chưa xác nhận |
