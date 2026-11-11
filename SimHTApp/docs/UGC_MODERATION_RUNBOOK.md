# Quy trình kiểm duyệt nội dung do người dùng tạo

Áp dụng cho bài viết, bình luận và tin nhắn trong ứng dụng Sim Hà Thành.

## Tiếp nhận báo cáo

1. Tài khoản Sendbird `supportSimHT` phải được đội ngũ hỗ trợ trực hàng ngày.
2. Mỗi báo cáo từ ứng dụng được gửi vào cuộc trò chuyện hỗ trợ với tiền tố `[UGC REPORT]`, mã nội dung hoặc kênh chat, người báo cáo, người bị báo cáo, trích đoạn và thời gian.
3. Ghi nhận người phụ trách và thời hạn xử lý không quá 24 giờ kể từ lúc nhận báo cáo.

## Xử lý trong 24 giờ

1. Đánh giá nội dung theo Điều khoản sử dụng và Quy tắc cộng đồng.
2. Nếu vi phạm: gỡ bài viết/bình luận khỏi backend, hoặc xóa tin nhắn trên Sendbird; đình chỉ hoặc khóa tài khoản vi phạm khi cần.
3. Nếu người dùng đã bị chặn, giữ nguyên trạng thái chặn và không hiển thị lại nội dung cho người báo cáo.
4. Lưu quyết định, thời điểm xử lý và người thực hiện vào nhật ký nội bộ.

## Xác nhận trước khi phát hành

- `supportSimHT` tồn tại, có thể nhận tin nhắn và có ít nhất một nhân sự trực.
- Nhân sự có quyền gỡ bài/bình luận trong backend và hạn chế hoặc khóa người dùng trên Sendbird Dashboard.
- Kiểm thử một báo cáo từ thiết bị thật; xác nhận chi tiết `[UGC REPORT]` tới tài khoản hỗ trợ.
