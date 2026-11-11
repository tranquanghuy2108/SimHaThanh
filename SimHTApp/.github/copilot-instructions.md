# Quy Chuẩn Lập Trình Dự Án Expo & React Native (JavaScript)

## 1. Công Nghệ & Thư Viện (Tech Stack)

- **Framework:** React Native sử dụng Expo (EAS Build / Expo Router hoặc React Navigation).
- **Ngôn ngữ:** JavaScript (ES6+ chuẩn, sạch sẽ, không dùng TypeScript).
- **Styling:** Sử dụng StyleSheet mặc định của React Native hoặc Tailwind CSS (NativeWind) nếu có.
- **Quản lý trạng thái:** Ưu tiên sử dụng React Context API cho các tác vụ thông thường, hoặc Zustand / Redux Toolkit cho dự án lớn.

## 2. Kiến Trúc & Phong Cách Code (Code Style)

- **Component:** Luôn sử dụng Functional Components và Arrow Functions.
- **Đặt tên:**
  - File và Tên Component: Theo chuẩn `PascalCase` (Ví dụ: `HomeScreen.js`, `CustomButton.js`).
  - Biến, Hàm, Props: Theo chuẩn `camelCase` (Ví dụ: `isLoggedIn`, `handlePress`).
- **Xử lý bất đồng bộ:** Luôn sử dụng cú pháp `async/await` đi kèm với khối `try/catch` để bắt lỗi, không dùng `.then().catch()`.
- **Props Validation:** Không ép kiểu nghiêm ngặt, nhưng cần viết chú thích rõ ràng ở đầu component về các props nhận vào để dễ quản lý.
- **Hiệu năng (Performance):** Sử dụng `useCallback` cho các hàm truyền qua props và `useMemo` cho các tác vụ tính toán nặng để tránh ứng dụng bị giật lag trên thiết bị di động.

## 3. Quy Tắc Đặc Thù Cho Expo & Mobile App

- **Giao diện di động:** Luôn sử dụng `SafeAreaView` để tránh bị che khuất bởi tai thỏ (notch) trên iPhone và camera đục lỗ trên Android.
- **Expo APIs:** Luôn ưu tiên dùng các thư viện trong hệ sinh thái của Expo (Ví dụ: `expo-status-bar`, `expo-image`, `expo-file-system`) thay vì các thư viện React Native thuần của bên thứ ba để đảm bảo tính tương thích và mượt mà.
- **Assets:** Khi import hình ảnh local, luôn sử dụng cú pháp `require('./assets/images/...')`.
- **Responsive:** Tránh cố định kích thước (width/height) bằng pixel lớn. Sử dụng phần trăm, Flexbox hoặc `Dimensions` từ React Native để giao diện tự co giãn theo mọi màn hình điện thoại.

## 4. Quy Định Phản Hồi Của Gemini Agent

- **Ngôn ngữ:** Luôn phản hồi, giải thích và viết chú thích (comments) trong code bằng **Tiếng Việt**.
- **Định dạng đầu ra:** Chỉ tập trung hiển thị đoạn code cần chỉnh sửa hoặc file mới tạo. Tuyệt đối không viết code theo chuẩn TypeScript. Không copy lại toàn bộ file cũ dài dòng nếu không cần thiết.
- **Tối ưu mã nguồn:** Code sinh ra phải sạch sẽ, không chứa các dòng debug thừa (như `console.log`) trừ khi được yêu cầu để tìm lỗi.
