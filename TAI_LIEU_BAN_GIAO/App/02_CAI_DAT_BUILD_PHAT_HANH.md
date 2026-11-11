# Cài đặt build và phát hành

## Yêu cầu môi trường

- Node.js phiên bản tương thích Expo SDK 55; nên chốt phiên bản bằng `.nvmrc` hoặc trường `engines` trước khi bàn giao.
- npm vì repository có `package-lock.json`. README cũ dùng Yarn nhưng repository không có `yarn.lock`; không nên trộn hai package manager.
- Android Studio, JDK theo yêu cầu của Expo/RN 0.83 và Android SDK 36.
- Xcode phiên bản hỗ trợ iOS 15.1 trở lên và CocoaPods.
- Expo CLI/EAS CLI; tài khoản Expo của owner hiện được cấu hình là `huongnx`.
- Quyền truy cập Firebase, Sendbird, Apple Developer/App Store Connect và Google Play Console.

## Cài đặt source

```bash
git clone <repository-url>
cd SimHTApp
npm ci
```

Không copy lại thư mục `node_modules`, `.expo`, `ios/build` hoặc artifact build từ máy cũ. Nếu native dependency thay đổi, chạy prebuild có kiểm soát và review diff vì repository đang lưu cả `android/` và `ios/`.

## Chạy môi trường phát triển

```bash
npm start
npm run android
npm run ios
```

Script `start` chạy `expo start --dev-client`. Ứng dụng dùng nhiều native module và Sendbird UIKit; development build là đường chạy chính. Expo Go trên Android không đăng ký FCM token, và source đã có nhánh fallback để tránh lỗi trong trường hợp này.

## Cấu hình nền tảng

| Thông số | Android | iOS |
| --- | --- | --- |
| Application ID | `com.simhathanh.app` | `com.simhathanh.app` |
| Phiên bản hiển thị | `1.0.4` | `1.0.4` |
| Build number | versionCode 4 | CFBundleVersion 1 |
| OS tối thiểu | API 28 | iOS 15.1 theo Expo/Podfile |
| Target/compile SDK | 36 | Xcode/EAS image latest |
| Engine | Hermes | Hermes |
| Kiến trúc mới | Bật | Bật |

`app.json`, `android/app/build.gradle`, Xcode project và `Info.plist` đều chứa thông tin phiên bản. Khi tăng version cần kiểm tra sự đồng bộ giữa các nguồn này. EAS đặt `appVersionSource: remote` và production `autoIncrement: true`, nên số build thực tế trên EAS có thể cao hơn file local.

## EAS Build

```bash
eas login
eas build --platform android --profile development
eas build --platform android --profile preview
eas build --platform android --profile production
eas build --platform ios --profile production
```

- `development`: development client, phân phối nội bộ.
- `preview`: Android APK, phân phối nội bộ.
- `production`: tự tăng build number; Android lấy credentials local; iOS dùng image mới nhất.

Production Android khai báo `credentialsSource: local`, vì vậy phải có file cấu hình credentials hợp lệ và keystore tương ứng trên máy/CI. Không gửi keystore và mật khẩu chung trong email hoặc trong gói source công khai.

## Android local build

```bash
cd android
./gradlew assembleDebug
./gradlew bundleRelease
```

Lưu ý quan trọng: `android/app/build.gradle` hiện đang gán build type `release` cho signing config `debug`. Cấu hình này không phù hợp để phát hành chính thức. Trước nghiệm thu, cần nối release build với keystore production thực tế hoặc xác nhận EAS đã override đúng bằng credentials local.

## iOS local build

```bash
cd ios
pod install
open SimHThnh.xcworkspace
```

Luôn mở workspace, không mở riêng `.xcodeproj`. Podfile có phần sửa build setting `REACT_NATIVE_PATH` cho RN 0.83/EAS Archive; không xóa nếu chưa kiểm tra archive trên EAS. Entitlement hiện ghi `aps-environment = development`; cần kiểm tra profile và entitlement của bản Archive/Distribution để push production hoạt động.

## Submit iOS

`eas.json` có cấu hình App Store Connect API key ID, issuer ID, app ID và đường dẫn file `.p8`. File `.p8` đã được `.gitignore`, vì vậy phải bàn giao riêng khóa hoặc tạo khóa mới cho bên nhận. Cách an toàn hơn là bên nhận tự tạo API key và cập nhật EAS Secrets/CI.

## Trạng thái kiểm thử tự động

`package.json` không có script `test`, `lint` hoặc `typecheck`. Jest và TypeScript có trong devDependencies nhưng chưa thấy cấu hình/test suite tương ứng. Việc nghiệm thu hiện phụ thuộc chủ yếu vào build và kiểm thử thủ công.

## Kiểm tra trước khi phát hành

1. Chạy cài đặt sạch bằng `npm ci`.
2. Build development cho Android và iOS.
3. Kiểm thử đăng nhập, đăng xuất, xóa tài khoản và phiên hết hạn.
4. Kiểm thử tìm kiếm/mua SIM, tạo/hủy đơn, đấu giá, trả góp và ví ký quỹ bằng tài khoản test.
5. Kiểm thử Sendbird chat, upload ảnh/video và số tin chưa đọc.
6. Kiểm thử push trên thiết bị thật cho Android và iOS distribution build.
7. Kiểm thử báo cáo/chặn bài viết, bình luận và người dùng; xác nhận support nhận `[UGC REPORT]`.
8. Kiểm tra permission camera/photo và việc app không yêu cầu microphone.
9. Kiểm tra version/build number, icon, splash, privacy text và policy URL/nội dung.
10. Ký xác nhận artifact APK/AAB/IPA/TestFlight và lưu checksum cùng tag Git.

