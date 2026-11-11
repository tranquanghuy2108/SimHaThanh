# Bộ tài liệu bàn giao source code Sim Hà Thành

Tài liệu này mô tả trạng thái repository tại nhánh `main`, commit `723a3b932d1e3a8d9386312e0e77b2f40f92b0c2` ngày 31/10/2026, đồng thời có tính đến các thay đổi chưa commit đang tồn tại trong working tree tại thời điểm rà soát ngày 10/11/2026.

## Thành phần tài liệu

- `01_TONG_QUAN_VA_KIEN_TRUC.md`: phạm vi hệ thống, cấu trúc source, kiến trúc và các luồng chính.
- `02_CAI_DAT_BUILD_PHAT_HANH.md`: yêu cầu môi trường, cách chạy, build và phát hành Android/iOS.
- `03_CAU_HINH_TICH_HOP_VA_VAN_HANH.md`: cấu hình, tích hợp ngoài, dữ liệu cục bộ, kiểm duyệt và vận hành.
- `04_CHECKLIST_BAN_GIAO_VA_RUI_RO.md`: danh sách tài sản cần bàn giao, kiểm tra nghiệm thu và các rủi ro đã phát hiện.
- `BAN_GIAO_SOURCE_CODE_SIM_HA_THANH.docx`: bản tổng hợp định dạng Word để gửi đối tác.

## Kết luận bàn giao

Source có đủ mã ứng dụng React Native/Expo, dự án native Android và iOS, tài nguyên giao diện và cấu hình EAS để tiếp tục phát triển. Tuy nhiên, chưa nên chuyển nguyên trạng repository cho đối tác trước khi xử lý các mục mức khẩn cấp trong checklist, gồm thu hồi hoặc xoay vòng Sendbird API token, tách thông tin xác thực khỏi Git, xác nhận khóa ký ứng dụng và chốt một commit/tag bàn giao sạch.

## Quy ước bảo mật

Tài liệu không ghi giá trị token, mật khẩu, private key hoặc nội dung keystore. Các tài sản này phải được chuyển bằng kho bí mật hoặc kênh mã hóa, tách khỏi gói source.
