# Tổng quan và kiến trúc source code Sim Hà Thành

## Phạm vi ứng dụng

Sim Hà Thành là ứng dụng di động phục vụ tìm kiếm và mua SIM, SIM data, gói cước, đấu giá, trả góp, cộng tác viên, ví ký quỹ, phong thủy SIM, bài đăng cộng đồng, thông báo và chat. Ứng dụng hỗ trợ Android và iOS; cấu hình web tồn tại trong Expo nhưng không thấy quy trình phát hành web riêng.

## Nền tảng kỹ thuật

| Hạng mục | Giá trị trong source |
| --- | --- |
| Framework | Expo SDK 55, React Native 0.83.10, React 19.2.0 |
| Ngôn ngữ chính | JavaScript; có TypeScript trong devDependencies nhưng source nghiệp vụ hiện là `.js` |
| Điều hướng | React Navigation 7, kết hợp native stack, bottom tabs và drawer |
| Quản lý trạng thái | React Context và hooks, 23 file context |
| Gọi API | Axios tới `https://api.simhathanh.vn` |
| Lưu cục bộ | AsyncStorage |
| Chat | Sendbird UIKit React Native và Sendbird SDK |
| Push notification | Expo Notifications, Firebase Cloud Messaging và APNs qua Sendbird UIKit |
| UI | React Native, Galio, React Native Paper, Elements, NativeWind và icon/image assets |
| Build | Expo prebuild/run, Gradle, CocoaPods và EAS Build |
| Kiến trúc native | New Architecture bật; Hermes bật |

## Sơ đồ kiến trúc logic

```text
Người dùng
   |
Màn hình và custom components
   |
React Navigation
   |
React Context providers
   |--------------------------|
Axios REST API                Sendbird UIKit SDK
   |                          |
api.simhathanh.vn             Sendbird Cloud
   |
Backend nghiệp vụ

AsyncStorage giữ phiên đăng nhập, điều khoản đã đọc và danh sách người dùng bị chặn.
Firebase/APNs cấp push token cho Sendbird trong development build và production build.
```

Đây là kiến trúc client nhiều context. Mỗi nhóm nghiệp vụ có một provider chứa state và hàm gọi API. Screen lấy dữ liệu hoặc gọi hành động bằng `useContext`. Source chưa có lớp API client tập trung, dependency injection, repository layer hoặc store dùng chung.

## Điểm vào và quá trình khởi động

1. `index.js` đăng ký component gốc.
2. `App.js` giữ splash screen, nạp font Argon và khởi tạo `SendbirdUIKitContainer`.
3. `App.js` lồng các provider nghiệp vụ, sau đó render `AppNav`.
4. `navigation/AppNav.js` đọc `UserInfo` và `UserToken` từ AsyncStorage, đồng thời kiểm tra phiên bản điều khoản cộng đồng.
5. `navigation/AppStack.js` khởi tạo navigation container, bottom tabs, native stack, drawer và cơ chế yêu cầu đăng nhập.
6. Người chưa đăng nhập vẫn có thể xem các chức năng công khai. Các tab mua/bán, chat và hồ sơ gọi `LoginRequiredContext` để mở màn hình đăng nhập khi cần.

## Cấu trúc thư mục

| Đường dẫn | Vai trò |
| --- | --- |
| `App.js`, `index.js` | Điểm vào, khởi tạo SDK và provider |
| `screens/` | 56 màn hình theo nghiệp vụ; `FengShui/` và `PostScreens/` là nhóm con |
| `components/` | 16 component dùng lại, gồm modal điều khoản và component bài đăng |
| `customComponents/` | 21 component giao diện đặc thù trang chủ và tìm kiếm |
| `context/` | 23 context quản lý state và gọi API |
| `navigation/` | Cấu hình stack, tab và drawer |
| `SendBirdComponents/` | Adapter platform service, fragment và đăng nhập Sendbird |
| `utils/` | Lọc nội dung người dùng và dịch vụ báo cáo/chặn |
| `constants/` | URL backend, Sendbird, hằng số màn hình và theme |
| `assets/` | Logo, splash, icon, font và bộ ảnh phong thủy |
| `android/` | Dự án Android native/Gradle |
| `ios/` | Dự án iOS/Xcode/CocoaPods |
| `credentials/` | Keystore Android; đây là dữ liệu nhạy cảm, không nên nằm trong Git |
| `docs/` | Tài liệu vận hành kiểm duyệt và bộ tài liệu bàn giao |

## Các miền nghiệp vụ

- Tài khoản: đăng nhập, đăng ký, hồ sơ, đổi mật khẩu, xóa tài khoản, thông tin ngân hàng và liên hệ hỗ trợ.
- SIM: danh mục, tìm kiếm, bộ lọc, SIM theo nhà mạng, giá, loại và khuyến mại.
- SIM data và gói cước: tìm kiếm SIM data, quốc gia, gói theo thuê bao, gói du lịch và VNPT.
- Thương mại: đặt SIM, đặt SIM data, danh sách đơn và hủy đơn.
- Đấu giá và trả góp: phiên đấu giá, đặt giá, lịch sử/của tôi, cấu hình và danh sách trả góp.
- Cộng tác viên: tạo nhóm, xin tham gia, phê duyệt và quản lý thành viên.
- Tài chính: số dư quỹ, nạp/rút và lịch sử ký quỹ.
- Phong thủy: chấm điểm, tìm SIM phong thủy và định giá SIM.
- Cộng đồng: bài viết, ảnh, bình luận, thích, báo cáo và chặn người dùng.
- Chat và thông báo: group channel Sendbird, số tin chưa đọc, push notification và thông báo backend.

## Dữ liệu và phiên đăng nhập

Backend trả token sau `/api/account/authenticate`. Ứng dụng lưu cả token và thông tin người dùng vào AsyncStorage dưới khóa `UserToken` và `UserInfo`; các context thêm header `Authorization: Bearer <token>` cho API cần xác thực. Khi logout, ứng dụng xóa gần như toàn bộ AsyncStorage nhưng giữ phiên bản điều khoản cộng đồng và danh sách người dùng bị chặn.

AsyncStorage không phải kho bảo mật dành cho credential. Đối tác nên chuyển token sang SecureStore/Keychain/Keystore ở một đợt hardening sau bàn giao.

## Nhận xét về kiến trúc

- Ưu điểm: phân nhóm chức năng rõ theo screen/context; có dự án native đầy đủ; quy trình Expo/EAS tương đối chuẩn; chat và push được bọc trong adapter riêng.
- Hạn chế: `App.js` lồng nhiều provider; API và xử lý lỗi phân tán; một số context dài; navigation có nhiều drawer lồng nhau và tên route lịch sử; chưa thấy kiểm thử tự động cho code ứng dụng.
- Hướng cải tiến: tạo `services/apiClient`, chuẩn hóa lỗi và timeout; gom provider theo domain; đưa secrets sang biến môi trường/EAS Secrets; thêm lint, type checking và test cho auth, API mapping, moderation và navigation.
