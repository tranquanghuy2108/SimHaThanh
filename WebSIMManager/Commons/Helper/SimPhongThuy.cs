using Commons.Enums;
using Commons.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Commons.Helper
{
    public static class SimPhongThuy
    {
        private static readonly MenhChuInfoModel[] dataNamSinhPT = new MenhChuInfoModel[] {
            new MenhChuInfoModel(){
              NamSinh = 1924,
              CanChi = "Giáp Tý",
              ConGiap= "Ốc Thượng Chi Thử – Chuột ở nóc nhà",
              CungSinh1= "Hải Trung Kim",
              CungSinh2= "Vàng trong biển",
              CungPhi1= "Tốn Mộc",
              CungPhi2= "Khôn Thổ"
            },
            new MenhChuInfoModel(){
              NamSinh = 1925,
              CanChi = "Ất Sửu",
              ConGiap= "Hải Nội Chi Ngưu – Trâu trong biển",
              CungSinh1= "Hải Trung Kim",
              CungSinh2= "Vàng trong biển",
              CungPhi1= "Chấn Mộc",
              CungPhi2= "Chấn Mộc"
            },
            new MenhChuInfoModel(){
              NamSinh = 1926,
              CanChi = "Bính Dần",
              ConGiap= "Sơn Lâm Chi Hổ – Hổ trong rừng",
              CungSinh1= "Lư Trung Hỏa",
              CungSinh2= "Lửa trong lò",
              CungPhi1= "Khôn Thổ",
              CungPhi2= "Tốn Mộc"
            },
            new MenhChuInfoModel(){
              NamSinh = 1927,
              CanChi = "Đinh Mão",
              ConGiap= "Vọng Nguyệt Chi Thố – Thỏ ngắm trăng",
              CungSinh1= "Lư Trung Hỏa",
              CungSinh2= "Lửa trong lò",
              CungPhi1= "Khảm Thuỷ",
              CungPhi2= "Khôn Thổ"
            },
            new MenhChuInfoModel(){
              NamSinh = 1928,
              CanChi = "Mậu Thìn",
              ConGiap= "Thanh Ôn Chi Long – Rồng trong sạch, ôn hoà",
              CungSinh1= "Đại Lâm Mộc",
              CungSinh2= "Gỗ rừng già",
              CungPhi1= "Ly Hoả",
              CungPhi2= "Càn Kim"
            },
            new MenhChuInfoModel(){
              NamSinh = 1929,
              CanChi = "Kỷ Tỵ",
              ConGiap= "Phúc Khí Chi Xà – Rắn có phúc",
              CungSinh1= "Đại Lâm Mộc",
              CungSinh2= "Gỗ rừng già",
              CungPhi1= "Cấn Thổ",
              CungPhi2= "Đoài Kim"
            },
            new MenhChuInfoModel(){
              NamSinh = 1930,
              CanChi = "Canh Ngọ",
              ConGiap= "Thất Lý Chi Mã – Ngựa trong nhà",
              CungSinh1= "Lộ Bàng Thổ",
              CungSinh2= "Đất bên đường",
              CungPhi1= "Đoài Kim",
              CungPhi2= "Cấn Thổ"
            },
            new MenhChuInfoModel(){
              NamSinh = 1931,
              CanChi = "Tân Mùi",
              ConGiap= "Đắc Lộc Chi Dương – Dê có lộc",
              CungSinh1= "Lộ Bàng Thổ",
              CungSinh2= "Đất bên đường",
              CungPhi1= "Càn Kim",
              CungPhi2= "Ly Hoả"
            },
            new MenhChuInfoModel(){
              NamSinh = 1932,
              CanChi = "Nhâm Thân",
              ConGiap= "Thanh Tú Chi Hầu – Khỉ thanh tú",
              CungSinh1= "Kiếm Phong Kim",
              CungSinh2= "Vàng chuôi kiếm",
              CungPhi1= "Khôn Thổ",
              CungPhi2= "Khảm Thuỷ"
            },
            new MenhChuInfoModel(){
              NamSinh = 1933,
              CanChi = "Quý Dậu",
              ConGiap= "Lâu Túc Kê – Gà nhà gác",
              CungSinh1= "Kiếm Phong Kim",
              CungSinh2= "Vàng chuôi kiếm",
              CungPhi1= "Tốn Mộc",
              CungPhi2= "Khôn Thổ"
            },
            new MenhChuInfoModel(){
              NamSinh = 1934,
              CanChi = "Giáp Tuất",
              ConGiap= "Thủ Thân Chi Cẩu – Chó giữ mình",
              CungSinh1= "Sơn Đầu Hỏa",
              CungSinh2= "Lửa trên núi",
              CungPhi1= "Chấn Mộc",
              CungPhi2= "Chấn Mộc"
            },
            new MenhChuInfoModel(){
              NamSinh = 1935,
              CanChi = "Ất Hợi",
              ConGiap= "Quá Vãng Chi Trư – Lợn hay đi",
              CungSinh1= "Sơn Đầu Hỏa",
              CungSinh2= "Lửa trên núi",
              CungPhi1= "Khôn Thổ",
              CungPhi2= "Tốn Mộc"
            },
            new MenhChuInfoModel(){
              NamSinh = 1936,
              CanChi = "Bính Tý",
              ConGiap= "Điền Nội Chi Thử – Chuột trong ruộng",
              CungSinh1= "Giản Hạ Thủy",
              CungSinh2= "Nước khe suối",
              CungPhi1= "Khảm Thuỷ",
              CungPhi2= "Khôn Thổ"
            },
            new MenhChuInfoModel(){
              NamSinh = 1937,
              CanChi = "Đinh Sửu",
              ConGiap= "Hồ Nội Chi Ngưu – Trâu trong hồ nước",
              CungSinh1= "Giản Hạ Thủy",
              CungSinh2= "Nước khe suối",
              CungPhi1= "Ly Hoả",
              CungPhi2= "Càn Kim"
            },
            new MenhChuInfoModel(){
              NamSinh = 1938,
              CanChi = "Mậu Dần",
              ConGiap= "Quá Sơn Chi Hổ – Hổ qua rừng",
              CungSinh1= "Thành Đầu Thổ",
              CungSinh2= "Đất đắp thành",
              CungPhi1= "Cấn Thổ",
              CungPhi2= "Đoài Kim"
            },
            new MenhChuInfoModel(){
              NamSinh = 1939,
              CanChi = "Kỷ Mão",
              ConGiap= "Sơn Lâm Chi Thố – Thỏ ở rừng",
              CungSinh1= "Thành Đầu Thổ",
              CungSinh2= "Đất đắp thành",
              CungPhi1= "Đoài Kim",
              CungPhi2= "Cấn Thổ"
            },
            new MenhChuInfoModel(){
              NamSinh = 1940,
              CanChi = "Canh Thìn",
              ConGiap= "Thứ Tính Chi Long – Rồng khoan dung",
              CungSinh1= "Bạch Lạp Kim",
              CungSinh2= "Vàng sáp ong",
              CungPhi1= "Càn Kim",
              CungPhi2= "Ly Hoả"
            },
            new MenhChuInfoModel(){
              NamSinh = 1941,
              CanChi = "Tân Tỵ",
              ConGiap= "Đông Tàng Chi Xà – Rắn ngủ đông",
              CungSinh1= "Bạch Lạp Kim",
              CungSinh2= "Vàng sáp ong",
              CungPhi1= "Khôn Thổ",
              CungPhi2= "Khảm Thuỷ"
            },
            new MenhChuInfoModel(){
              NamSinh = 1942,
              CanChi = "Nhâm Ngọ",
              ConGiap= "Quân Trung Chi Mã – Ngựa chiến",
              CungSinh1= "Dương Liễu Mộc",
              CungSinh2= "Gỗ cây dương",
              CungPhi1= "Tốn Mộc",
              CungPhi2= "Khôn Thổ"
            },
            new MenhChuInfoModel(){
              NamSinh = 1943,
              CanChi = "Quý Mùi",
              ConGiap= "Quần Nội Chi Dương – Dê trong đàn",
              CungSinh1= "Dương Liễu Mộc",
              CungSinh2= "Gỗ cây dương",
              CungPhi1= "Chấn Mộc",
              CungPhi2= "Chấn Mộc"
            },
            new MenhChuInfoModel(){
              NamSinh = 1944,
              CanChi = "Giáp Thân",
              ConGiap= "Quá Thụ Chi Hầu – Khỉ leo cây",
              CungSinh1= "Tuyền Trung Thủy",
              CungSinh2= "Nước trong suối",
              CungPhi1= "Khôn Thổ",
              CungPhi2= "Tốn Mộc"
            },
            new MenhChuInfoModel(){
              NamSinh = 1945,
              CanChi = "Ất Dậu",
              ConGiap= "Xướng Ngọ Chi Kê – Gà gáy trưa",
              CungSinh1= "Tuyền Trung Thủy",
              CungSinh2= "Nước trong suối",
              CungPhi1= "Khảm Thuỷ",
              CungPhi2= "Khôn Thổ"
            },
            new MenhChuInfoModel(){
              NamSinh = 1946,
              CanChi = "Bính Tuất",
              ConGiap= "Tự Miên Chi Cẩu – Chó đang ngủ",
              CungSinh1= "Ốc Thượng Thổ",
              CungSinh2= "Đất nóc nhà",
              CungPhi1= "Ly Hoả",
              CungPhi2= "Càn Kim"
            },
            new MenhChuInfoModel(){
              NamSinh = 1947,
              CanChi = "Đinh Hợi",
              ConGiap= "Quá Sơn Chi Trư – Lợn qua núi",
              CungSinh1= "Ốc Thượng Thổ",
              CungSinh2= "Đất nóc nhà",
              CungPhi1= "Cấn Thổ",
              CungPhi2= "Đoài Kim"
            },
            new MenhChuInfoModel(){
              NamSinh = 1948,
              CanChi = "Mậu Tý",
              ConGiap= "Thương Nội Chi Trư – Chuột trong kho",
              CungSinh1= "Thích Lịch Hỏa",
              CungSinh2= "Lửa sấm sét",
              CungPhi1= "Đoài Kim",
              CungPhi2= "Cấn Thổ"
            },
            new MenhChuInfoModel(){
              NamSinh = 1949,
              CanChi = "Kỷ Sửu",
              ConGiap= "Lâm Nội Chi Ngưu – Trâu trong chuồng",
              CungSinh1= "Thích Lịch Hỏa",
              CungSinh2= "Lửa sấm sét",
              CungPhi1= "Càn Kim",
              CungPhi2= "Ly Hoả"
            },
            new MenhChuInfoModel(){
              NamSinh = 1950,
              CanChi = "Canh Dần",
              ConGiap= "Xuất Sơn Chi Hổ – Hổ xuống núi",
              CungSinh1= "Tùng Bách Mộc",
              CungSinh2= "Gỗ tùng bách",
              CungPhi1= "Khôn Thổ",
              CungPhi2= "Khảm Thuỷ"
            },
            new MenhChuInfoModel(){
              NamSinh = 1951,
              CanChi = "Tân Mão",
              ConGiap= "Ẩn Huyệt Chi Thố – Thỏ trong hang",
              CungSinh1= "Tùng Bách Mộc",
              CungSinh2= "Gỗ tùng bách",
              CungPhi1= "Tốn Mộc",
              CungPhi2= "Khôn Thổ"
            },
            new MenhChuInfoModel(){
              NamSinh = 1952,
              CanChi = "Nhâm Thìn",
              ConGiap= "Hành Vũ Chi Long – Rồng phun mưa",
              CungSinh1= "Trường Lưu Thủy",
              CungSinh2= "Nước chảy mạnh",
              CungPhi1= "Chấn Mộc",
              CungPhi2= "Chấn Mộc"
            },
            new MenhChuInfoModel(){
              NamSinh = 1953,
              CanChi = "Quý Tỵ",
              ConGiap= "Thảo Trung Chi Xà – Rắn trong cỏ",
              CungSinh1= "Trường Lưu Thủy",
              CungSinh2= "Nước chảy mạnh",
              CungPhi1= "Khôn Thổ",
              CungPhi2= "Tốn Mộc"
            },
            new MenhChuInfoModel(){
              NamSinh = 1954,
              CanChi = "Giáp Ngọ",
              ConGiap= "Vân Trung Chi Mã – Ngựa trong mây",
              CungSinh1= "Sa Trung Kim",
              CungSinh2= "Vàng trong cát",
              CungPhi1= "Khảm Thuỷ",
              CungPhi2= "Khôn Thổ"
            },
            new MenhChuInfoModel(){
              NamSinh = 1955,
              CanChi = "Ất Mùi",
              ConGiap= "Kính Trọng Chi Dương – Dê được quý mến",
              CungSinh1= "Sa Trung Kim",
              CungSinh2= "Vàng trong cát",
              CungPhi1= "Ly Hoả",
              CungPhi2= "Càn Kim"
            },
            new MenhChuInfoModel(){
              NamSinh = 1956,
              CanChi = "Bính Thân",
              ConGiap= "Sơn Thượng Chi Hầu – Khỉ trên núi",
              CungSinh1= "Sơn Hạ Hỏa",
              CungSinh2= "Lửa trên núi",
              CungPhi1= "Cấn Thổ",
              CungPhi2= "Đoài Kim"
            },
            new MenhChuInfoModel(){
              NamSinh = 1957,
              CanChi = "Đinh Dậu",
              ConGiap= "Độc Lập Chi Kê – Gà độc thân",
              CungSinh1= "Sơn Hạ Hỏa",
              CungSinh2= "Lửa trên núi",
              CungPhi1= "Đoài Kim",
              CungPhi2= "Cấn Thổ"
            },
            new MenhChuInfoModel(){
              NamSinh = 1958,
              CanChi = "Mậu Tuất",
              ConGiap= "Tiến Sơn Chi Cẩu – Chó vào núi",
              CungSinh1= "Bình Địa Mộc",
              CungSinh2= "Gỗ đồng bằng",
              CungPhi1= "Càn Kim",
              CungPhi2= "Ly Hoả"
            },
            new MenhChuInfoModel(){
              NamSinh = 1959,
              CanChi = "Kỷ Hợi",
              ConGiap= "Đạo Viện Chi Trư – Lợn trong tu viện",
              CungSinh1= "Bình Địa Mộc",
              CungSinh2= "Gỗ đồng bằng",
              CungPhi1= "Khôn Thổ",
              CungPhi2= "Khảm Thuỷ"
            },
            new MenhChuInfoModel(){
              NamSinh = 1960,
              CanChi = "Canh Tý",
              ConGiap= "Lương Thượng Chi Thử – Chuột trên xà",
              CungSinh1= "Bích Thượng Thổ",
              CungSinh2= "Đất tò vò",
              CungPhi1= "Tốn Mộc",
              CungPhi2= "Khôn Thổ"
            },
            new MenhChuInfoModel(){
              NamSinh = 1961,
              CanChi = "Tân Sửu",
              ConGiap= "Lộ Đồ Chi Ngưu – Trâu trên đường",
              CungSinh1= "Bích Thượng Thổ",
              CungSinh2= "Đất tò vò",
              CungPhi1= "Chấn Mộc",
              CungPhi2= "Chấn Mộc"
            },
            new MenhChuInfoModel(){
              NamSinh = 1962,
              CanChi = "Nhâm Dần",
              ConGiap= "Quá Lâm Chi Hổ – Hổ qua rừng",
              CungSinh1= "Kim Bạch Kim",
              CungSinh2= "Vàng pha bạc",
              CungPhi1= "Khôn Thổ",
              CungPhi2= "Tốn Mộc"
            },
            new MenhChuInfoModel(){
              NamSinh = 1963,
              CanChi = "Quý Mão",
              ConGiap= "Quá Lâm Chi Thố – Thỏ qua rừng",
              CungSinh1= "Kim Bạch Kim",
              CungSinh2= "Vàng pha bạc",
              CungPhi1= "Khảm Thuỷ",
              CungPhi2= "Khôn Thổ"
            },
            new MenhChuInfoModel(){
              NamSinh = 1964,
              CanChi = "Giáp Thìn",
              ConGiap= "Phục Đầm Chi Lâm – Rồng ẩn ở đầm",
              CungSinh1= "Phú Đăng Hỏa",
              CungSinh2= "Lửa đèn to",
              CungPhi1= "Ly Hoả",
              CungPhi2= "Càn Kim"
            },
            new MenhChuInfoModel(){
              NamSinh = 1965,
              CanChi = "Ất Tỵ",
              ConGiap= "Xuất Huyệt Chi Xà – Rắn rời hang",
              CungSinh1= "Phú Đăng Hỏa",
              CungSinh2= "Lửa đèn to",
              CungPhi1= "Cấn Thổ",
              CungPhi2= "Đoài Kim"
            },
            new MenhChuInfoModel(){
              NamSinh = 1966,
              CanChi = "Bính Ngọ",
              ConGiap= "Hành Lộ Chi Mã – Ngựa chạy trên đường",
              CungSinh1= "Thiên Hà Thủy",
              CungSinh2= "Nước trên trời",
              CungPhi1= "Đoài Kim",
              CungPhi2= "Cấn Thổ"
            },
            new MenhChuInfoModel(){
              NamSinh = 1967,
              CanChi = "Đinh Mùi",
              ConGiap= "Thất Quần Chi Dương – Dê lạc đàn",
              CungSinh1= "Thiên Hà Thủy",
              CungSinh2= "Nước trên trời",
              CungPhi1= "Càn Kim",
              CungPhi2= "Ly Hoả"
            },
            new MenhChuInfoModel(){
              NamSinh = 1968,
              CanChi = "Mậu Thân",
              ConGiap= "Độc Lập Chi Hầu – Khỉ độc thân",
              CungSinh1= "Đại Trạch Thổ",
              CungSinh2= "Đất nền nhà",
              CungPhi1= "Khôn Thổ",
              CungPhi2= "Khảm Thuỷ"
            },
            new MenhChuInfoModel(){
              NamSinh = 1969,
              CanChi = "Kỷ Dậu",
              ConGiap= "Báo Hiệu Chi Kê – Gà gáy",
              CungSinh1= "Đại Trạch Thổ",
              CungSinh2= "Đất nền nhà",
              CungPhi1= "Tốn Mộc",
              CungPhi2= "Khôn Thổ"
            },
            new MenhChuInfoModel(){
              NamSinh = 1970,
              CanChi = "Canh Tuất",
              ConGiap= "Tự Quan Chi Cẩu – Chó nhà chùa",
              CungSinh1= "Thoa Xuyến Kim",
              CungSinh2= "Vàng trang sức",
              CungPhi1= "Chấn Mộc",
              CungPhi2= "Chấn Mộc"
            },
            new MenhChuInfoModel(){
              NamSinh = 1971,
              CanChi = "Tân Hợi",
              ConGiap= "Khuyên Dưỡng Chi Trư – Lợn nuôi nhốt",
              CungSinh1= "Thoa Xuyến Kim",
              CungSinh2= "Vàng trang sức",
              CungPhi1= "Khôn Thổ",
              CungPhi2= "Tốn Mộc"
            },
            new MenhChuInfoModel(){
              NamSinh = 1972,
              CanChi = "Nhâm Tý",
              ConGiap= "Sơn Thượng Chi Thử – Chuột trên núi",
              CungSinh1= "Tang Đố Mộc",
              CungSinh2= "Gỗ cây dâu",
              CungPhi1= "Khảm Thuỷ",
              CungPhi2= "Khôn Thổ"
            },
            new MenhChuInfoModel(){
              NamSinh = 1973,
              CanChi = "Quý Sửu",
              ConGiap= "Lan Ngoại Chi Ngưu – Trâu ngoài chuồng",
              CungSinh1= "Tang Đố Mộc",
              CungSinh2= "Gỗ cây dâu",
              CungPhi1= "Ly Hoả",
              CungPhi2= "Càn Kim"
            },
            new MenhChuInfoModel(){
              NamSinh = 1974,
              CanChi = "Giáp Dần",
              ConGiap= "Lập Định Chi Hổ – Hổ tự lập",
              CungSinh1= "Đại Khe Thủy",
              CungSinh2= "Nước khe lớn",
              CungPhi1= "Cấn Thổ",
              CungPhi2= "Đoài Kim"
            },
            new MenhChuInfoModel(){
              NamSinh = 1975,
              CanChi = "Ất Mão",
              ConGiap= "Đắc Đạo Chi Thố – Thỏ đắc đạo",
              CungSinh1= "Đại Khe Thủy",
              CungSinh2= "Nước khe lớn",
              CungPhi1= "Đoài Kim",
              CungPhi2= "Cấn Thổ"
            },
            new MenhChuInfoModel(){
              NamSinh = 1976,
              CanChi = "Bính Thìn",
              ConGiap= "Thiên Thượng Chi Long – Rồng trên trời",
              CungSinh1= "Sa Trung Thổ",
              CungSinh2= "Đất pha cát",
              CungPhi1= "Càn Kim",
              CungPhi2= "Ly Hoả"
            },
            new MenhChuInfoModel(){
              NamSinh = 1977,
              CanChi = "Đinh Tỵ",
              ConGiap= "Đầm Nội Chi Xà – Rắn trong đầm",
              CungSinh1= "Sa Trung Thổ",
              CungSinh2= "Đất pha cát",
              CungPhi1= "Khôn Thổ",
              CungPhi2= "Khảm Thuỷ"
            },
            new MenhChuInfoModel(){
              NamSinh = 1978,
              CanChi = "Mậu Ngọ",
              ConGiap= "Cứu Nội Chi Mã – Ngựa trong chuồng",
              CungSinh1= "Thiên Thượng Hỏa",
              CungSinh2= "Lửa trên trời",
              CungPhi1= "Tốn Mộc",
              CungPhi2= "Khôn Thổ"
            },
            new MenhChuInfoModel(){
              NamSinh = 1979,
              CanChi = "Kỷ Mùi",
              ConGiap= "Thảo Dã Chi Dương – Dê đồng cỏ",
              CungSinh1= "Thiên Thượng Hỏa",
              CungSinh2= "Lửa trên trời",
              CungPhi1= "Chấn Mộc",
              CungPhi2= "Chấn Mộc"
            },
            new MenhChuInfoModel(){
              NamSinh = 1980,
              CanChi = "Canh Thân",
              ConGiap= "Thực Quả Chi Hầu – Khỉ ăn hoa quả",
              CungSinh1= "Thạch Lựu Mộc",
              CungSinh2= "Gỗ cây lựu đá",
              CungPhi1= "Khôn Thổ",
              CungPhi2= "Tốn Mộc"
            },
            new MenhChuInfoModel(){
              NamSinh = 1981,
              CanChi = "Tân Dậu",
              ConGiap= "Long Tàng Chi Kê – Gà trong lồng",
              CungSinh1= "Thạch Lựu Mộc",
              CungSinh2= "Gỗ cây lựu đá",
              CungPhi1= "Khảm Thuỷ",
              CungPhi2= "Khôn Thổ"
            },
            new MenhChuInfoModel(){
              NamSinh = 1982,
              CanChi = "Nhâm Tuất",
              ConGiap= "Cố Gia Chi Khuyển – Chó về nhà",
              CungSinh1= "Đại Hải Thủy",
              CungSinh2= "Nước biển lớn",
              CungPhi1= "Ly Hoả",
              CungPhi2= "Càn Kim"
            },
            new MenhChuInfoModel(){
              NamSinh = 1983,
              CanChi = "Quý Hợi",
              ConGiap= "Lâm Hạ Chi Trư – Lợn trong rừng",
              CungSinh1= "Đại Hải Thủy",
              CungSinh2= "Nước biển lớn",
              CungPhi1= "Cấn Thổ",
              CungPhi2= "Đoài Kim"
            },
            new MenhChuInfoModel(){
              NamSinh = 1984,
              CanChi = "Giáp Tý",
              ConGiap= "Ốc Thượng Chi Thử – Chuột ở nóc nhà",
              CungSinh1= "Hải Trung Kim",
              CungSinh2= "Vàng trong biển",
              CungPhi1= "Đoài Kim",
              CungPhi2= "Cấn Thổ"
            },
            new MenhChuInfoModel(){
              NamSinh = 1985,
              CanChi = "Ất Sửu",
              ConGiap= "Hải Nội Chi Ngưu – Trâu trong biển",
              CungSinh1= "Hải Trung Kim",
              CungSinh2= "Vàng trong biển",
              CungPhi1= "Càn Kim",
              CungPhi2= "Ly Hoả"
            },
            new MenhChuInfoModel(){
              NamSinh = 1986,
              CanChi = "Bính Dần",
              ConGiap= "Sơn Lâm Chi Hổ – Hổ trong rừng",
              CungSinh1= "Lư Trung Hỏa",
              CungSinh2= "Lửa trong lò",
              CungPhi1= "Khôn Thổ",
              CungPhi2= "Khảm Thuỷ"
            },
            new MenhChuInfoModel(){
              NamSinh = 1987,
              CanChi = "Đinh Mão",
              ConGiap= "Vọng Nguyệt Chi Thố – Thỏ ngắm trăng",
              CungSinh1= "Lư Trung Hỏa",
              CungSinh2= "Lửa trong lò",
              CungPhi1= "Tốn Mộc",
              CungPhi2= "Khôn Thổ"
            },
            new MenhChuInfoModel(){
              NamSinh = 1988,
              CanChi = "Mậu Thìn",
              ConGiap= "Thanh Ôn Chi Long – Rồng trong sạch, ôn hoà",
              CungSinh1= "Đại Lâm Mộc",
              CungSinh2= "Gỗ rừng già",
              CungPhi1= "Chấn Mộc",
              CungPhi2= "Chấn Mộc"
            },
            new MenhChuInfoModel(){
              NamSinh = 1989,
              CanChi = "Kỷ Tỵ",
              ConGiap= "Phúc Khí Chi Xà – Rắn có phúc",
              CungSinh1= "Đại Lâm Mộc",
              CungSinh2= "Gỗ rừng già",
              CungPhi1= "Khôn Thổ",
              CungPhi2= "Tốn Mộc"
            },
            new MenhChuInfoModel(){
              NamSinh = 1990,
              CanChi = "Canh Ngọ",
              ConGiap= "Thất Lý Chi Mã – Ngựa trong nhà",
              CungSinh1= "Lộ Bàng Thổ",
              CungSinh2= "Đất đường đi",
              CungPhi1= "Khảm Thuỷ",
              CungPhi2= "Cấn Thổ"
            },
            new MenhChuInfoModel(){
              NamSinh = 1991,
              CanChi = "Tân Mùi",
              ConGiap= "Đắc Lộc Chi Dương – Dê có lộc",
              CungSinh1= "Lộ Bàng Thổ",
              CungSinh2= "Đất đường đi",
              CungPhi1= "Ly Hoả",
              CungPhi2= "Càn Kim"
            },
            new MenhChuInfoModel(){
              NamSinh = 1992,
              CanChi = "Nhâm Thân",
              ConGiap= "Thanh Tú Chi Hầu – Khỉ thanh tú",
              CungSinh1= "Kiếm Phong Kim",
              CungSinh2= "Vàng mũi kiếm",
              CungPhi1= "Cấn Thổ",
              CungPhi2= "Đoài Kim"
            },
            new MenhChuInfoModel(){
              NamSinh = 1993,
              CanChi = "Quý Dậu",
              ConGiap= "Lâu Túc Kê – Gà nhà gác",
              CungSinh1= "Kiếm Phong Kim",
              CungSinh2= "Vàng mũi kiếm",
              CungPhi1= "Đoài Kim",
              CungPhi2= "Cấn Thổ"
            },
            new MenhChuInfoModel(){
              NamSinh = 1994,
              CanChi = "Giáp Tuất",
              ConGiap= "Thủ Thân Chi Cẩu – Chó giữ mình",
              CungSinh1= "Sơn Đầu Hỏa",
              CungSinh2= "Lửa trên núi",
              CungPhi1= "Càn Kim",
              CungPhi2= "Ly Hoả"
            },
            new MenhChuInfoModel(){
              NamSinh = 1995,
              CanChi = "Ất Hợi",
              ConGiap= "Quá Vãng Chi Trư – Lợn hay đi",
              CungSinh1= "Sơn Đầu Hỏa",
              CungSinh2= "Lửa trên núi",
              CungPhi1= "Khôn Thổ",
              CungPhi2= "Khảm Thuỷ"
            },
            new MenhChuInfoModel(){
              NamSinh = 1996,
              CanChi = "Bính Tý",
              ConGiap= "Điền Nội Chi Thử – Chuột trong ruộng",
              CungSinh1= "Giảm Hạ Thủy",
              CungSinh2= "Nước cuối nguồn",
              CungPhi1= "Tốn Mộc",
              CungPhi2= "Khôn Thổ"
            },
            new MenhChuInfoModel(){
              NamSinh = 1997,
              CanChi = "Đinh Sửu",
              ConGiap= "Hồ Nội Chi Ngưu – Trâu trong hồ nước",
              CungSinh1= "Giảm Hạ Thủy",
              CungSinh2= "Nước cuối nguồn",
              CungPhi1= "Chấn Mộc",
              CungPhi2= "Chấn Mộc"
            },
            new MenhChuInfoModel(){
              NamSinh = 1998,
              CanChi = "Mậu Dần",
              ConGiap= "Quá Sơn Chi Hổ – Hổ qua rừng",
              CungSinh1= "Thành Đầu Thổ",
              CungSinh2= "Đất trên thành",
              CungPhi1= "Khôn Thổ",
              CungPhi2= "Tốn Mộc"
            },
            new MenhChuInfoModel(){
              NamSinh = 1999,
              CanChi = "Kỷ Mão",
              ConGiap= "Sơn Lâm Chi Thố – Thỏ ở rừng",
              CungSinh1= "Thành Đầu Thổ",
              CungSinh2= "Đất trên thành",
              CungPhi1= "Khảm Thuỷ",
              CungPhi2= "Cấn Thổ"
            },
            new MenhChuInfoModel(){
              NamSinh = 2000,
              CanChi = "Canh Thìn",
              ConGiap= "Thứ Tính Chi Long – Rồng khoan dung",
              CungSinh1= "Bạch Lạp Kim",
              CungSinh2= "Vàng chân đèn",
              CungPhi1= "Ly Hoả",
              CungPhi2= "Càn Kim"
            },
            new MenhChuInfoModel(){
              NamSinh = 2001,
              CanChi = "Tân Tỵ",
              ConGiap= "Đông Tàng Chi Xà – Rắn ngủ đông",
              CungSinh1= "Bạch Lạp Kim",
              CungSinh2= "Vàng chân đèn",
              CungPhi1= "Cấn Thổ",
              CungPhi2= "Đoài Kim"
            },
            new MenhChuInfoModel(){
              NamSinh = 2002,
              CanChi = "Nhâm Ngọ",
              ConGiap= "Quân Trung Chi Mã – Ngựa chiến",
              CungSinh1= "Dương Liễu Mộc",
              CungSinh2= "Gỗ cây dương",
              CungPhi1= "Đoài Kim",
              CungPhi2= "Cấn Thổ"
            },
            new MenhChuInfoModel(){
              NamSinh = 2003,
              CanChi = "Quý Mùi",
              ConGiap= "Quần Nội Chi Dương – Dê trong đàn",
              CungSinh1= "Dương Liễu Mộc",
              CungSinh2= "Gỗ cây dương",
              CungPhi1= "Càn Kim",
              CungPhi2= "Ly Hoả"
            },
            new MenhChuInfoModel(){
              NamSinh = 2004,
              CanChi = "Giáp Thân",
              ConGiap= "Quá Thụ Chi Hầu – Khỉ leo cây",
              CungSinh1= "Tuyền Trung Thủy",
              CungSinh2= "Nước trong suối",
              CungPhi1= "Khôn Thổ",
              CungPhi2= "Khảm Thuỷ"
            },
            new MenhChuInfoModel(){
              NamSinh = 2005,
              CanChi = "Ất Dậu",
              ConGiap= "Xướng Ngọ Chi Kê – Gà gáy trưa",
              CungSinh1= "Tuyền Trung Thủy",
              CungSinh2= "Nước trong suối",
              CungPhi1= "Tốn Mộc",
              CungPhi2= "Khôn Thổ"
            },
            new MenhChuInfoModel(){
              NamSinh = 2006,
              CanChi = "Bính Tuất",
              ConGiap= "Tự Miên Chi Cẩu – Chó đang ngủ",
              CungSinh1= "Ốc Thượng Thổ",
              CungSinh2= "Đất nóc nhà",
              CungPhi1= "Chấn Mộc",
              CungPhi2= "Chấn Mộc"
            },
            new MenhChuInfoModel(){
              NamSinh = 2007,
              CanChi = "Đinh Hợi",
              ConGiap= "Quá Sơn Chi Trư – Lợn qua núi",
              CungSinh1= "Ốc Thượng Thổ",
              CungSinh2= "Đất nóc nhà",
              CungPhi1= "Khôn Thổ",
              CungPhi2= "Tốn Mộc"
            },
            new MenhChuInfoModel(){
              NamSinh = 2008,
              CanChi = "Mậu Tý",
              ConGiap= "Thương Nội Chi Thư – Chuột trong kho",
              CungSinh1= "Thích Lịch Hỏa",
              CungSinh2= "Lửa sấm sét",
              CungPhi1= "Khảm Thuỷ",
              CungPhi2= "Cấn Thổ"
            },
            new MenhChuInfoModel(){
              NamSinh = 2009,
              CanChi = "Kỷ Sửu",
              ConGiap= "Lâm Nội Chi Ngưu – Trâu trong chuồng",
              CungSinh1= "Thích Lịch Hỏa",
              CungSinh2= "Lửa sấm sét",
              CungPhi1= "Ly Hoả",
              CungPhi2= "Càn Kim"
            },
            new MenhChuInfoModel(){
              NamSinh = 2010,
              CanChi = "Canh Dần",
              ConGiap= "Xuất Sơn Chi Hổ – Hổ xuống núi",
              CungSinh1= "Tùng Bách Mộc",
              CungSinh2= "Gỗ tùng bách",
              CungPhi1= "Cấn Thổ",
              CungPhi2= "Đoài Kim"
            },
            new MenhChuInfoModel(){
              NamSinh = 2011,
              CanChi = "Tân Mão",
              ConGiap= "Ẩn Huyệt Chi Thố – Thỏ",
              CungSinh1= "Tùng Bách Mộc",
              CungSinh2= "Gỗ tùng bách",
              CungPhi1= "Đoài Kim",
              CungPhi2= "Cấn Thổ"
            },
            new MenhChuInfoModel(){
              NamSinh = 2012,
              CanChi = "Nhâm Thìn",
              ConGiap= "Hành Vũ Chi Long – Rồng phun mưa",
              CungSinh1= "Trường Lưu Thủy",
              CungSinh2= "Nước chảy mạnh",
              CungPhi1= "Càn Kim",
              CungPhi2= "Ly Hoả"
            },
            new MenhChuInfoModel(){
              NamSinh = 2013,
              CanChi = "Quý Tỵ",
              ConGiap= "Thảo Trung Chi Xà – Rắn trong cỏ",
              CungSinh1= "Trường Lưu Thủy",
              CungSinh2= "Nước chảy mạnh",
              CungPhi1= "Khôn Thổ",
              CungPhi2= "Khảm Thuỷ"
            },
            new MenhChuInfoModel(){
              NamSinh = 2014,
              CanChi = "Giáp Ngọ",
              ConGiap= "Vân Trung Chi Mã – Ngựa trong mây",
              CungSinh1= "Sa Trung Kim",
              CungSinh2= "Vàng trong cát",
              CungPhi1= "Tốn Mộc",
              CungPhi2= "Khôn Thổ"
            },
            new MenhChuInfoModel(){
              NamSinh = 2015,
              CanChi = "Ất Mùi",
              ConGiap= "Kính Trọng Chi Dương – Dê được quý mến",
              CungSinh1= "Sa Trung Kim",
              CungSinh2= "Vàng trong cát",
              CungPhi1= "Chấn Mộc",
              CungPhi2= "Chấn Mộc"
            },
            new MenhChuInfoModel(){
              NamSinh = 2016,
              CanChi = "Bính Thân",
              ConGiap= "Sơn Thượng Chi Hầu – Khỉ trên núi",
              CungSinh1= "Sơn Hạ Hỏa",
              CungSinh2= "Lửa trên núi",
              CungPhi1= "Khôn Thổ",
              CungPhi2= "Tốn Mộc"
            },
            new MenhChuInfoModel(){
              NamSinh = 2017,
              CanChi = "Đinh Dậu",
              ConGiap= "Độc Lập Chi Kê – Gà độc thân",
              CungSinh1= "Sơn Hạ Hỏa",
              CungSinh2= "Lửa trên núi",
              CungPhi1= "Khảm Thuỷ",
              CungPhi2= "Cấn Thổ"
            },
            new MenhChuInfoModel(){
              NamSinh = 2018,
              CanChi = "Mậu Tuất",
              ConGiap= "Tiến Sơn Chi Cẩu – Chó vào núi",
              CungSinh1= "Bình Địa Mộc",
              CungSinh2= "Gỗ đồng bằng",
              CungPhi1= "Ly Hoả",
              CungPhi2= "Càn Ki"
            }
        };
        private static readonly QueKinhDichModel[] queKinhDich = new QueKinhDichModel[]
        {
            new QueKinhDichModel()
            {
                queSo = 1,
                tuongQue = "",
                queName = "Thuần Càn (乾 qián)",
                loaiQue = "Đại Cát",
                totChoViec = "Có thể xem tốt cho mọi việc là vậy.",
                loiKinh = "乾元亨利貞.",
                dichAm = "Càn nguyền hanh lợi trinh.",
                dichNghia = "Càn: đầu cả, hanh thông, lợi tốt, chính bền.",
                giaiNghia = "Càn tức là trời, đại diện cho khí Dương, là cha, là vua\r\nNguyên, hanh, lợi, trinh là bốn đức tính: nguyên là muôn vật bắt đầu, hanh là muôn vật lớn lên, sinh sôi nảy nở, lợi là muốn vật được thoả, trinh là muốn vật đã thành. Chỉ Càn và Khôn có bốn đức tính ấy. Cho nên nguyên là chuyên làm những điều thiện lớn; lợi thì chủ về những sự chính bền; thể của hanh, trinh, việc nào xứng với việc ấy."
            },
            new QueKinhDichModel()
            {
                queSo = 2,
                tuongQue = "",
                queName = "Thuần Khôn (坤 kūn)",
                loaiQue = "Đại Cát",
                totChoViec = "Công danh sự nghiệp",
                loiKinh = "坤元亨, 利牝馬之貞, 君子有攸往, 先迷, 後 得, 主利, 西南得朋, 東北喪朋, 安貞, 吉.",
                dichAm = "Khôn nguyên hanh, lợi tẫn mã chi trinh. Quân tử hữu du vãng. Tiên mê, hậu đắc, chủ lợi. Tây Nam đắc bằng, Đông Bắc táng bằng, an trinh, cát.",
                dichNghia = "Quẻ Khôn: đầu cả, hanh thông, lợi về nết trinh của ngựa cái. Quân tử có sự đi. Trước mê, sau được. Chủ về lợi. Phía tây nam được bạn, phía Đông Bắc mất bạn. Yên phận giữ nết trinh thì tốt",
                giaiNghia = "Nguyên, hanh, lợi, trinh là bốn đức tính: nguyên là muôn vật bắt đầu, hanh là muôn vật lớn lên, sinh sôi nảy nở, lợi là muốn vật được thoả, trinh là muốn vật đã thành.\r\nKhôn là quẻ đối nhau với Kiền, bốn đức tính giống nhau, mà về thể “trinh” thì khác nhau. Kiền lấy chính bền làm trinh. Khôn thì mềm thuận là trinh (Ngựa cái là giống có đức mềm thuận mà sức đi khỏe cho nên dùng tượng của nó). Việc làm của đấng quân tử mềm thuận mà lợi và trinh, đó là hợp với đức tính của Khôn. Chủ về lợi, nghĩa là lợi cho muốn vật đều chủ ở Khôn. Vì cuộc sinh thành đều là công của đất cả."
            },
            new QueKinhDichModel()
            {
                queSo = 3,
                tuongQue = "",
                queName = "Thủy Lôi Truân (屯 chún)",
                loaiQue = "Hung",
                totChoViec = "",
                loiKinh = "屯元亨利貞, 勿用有攸往, 利建候.",
                dichAm = "Truân nguyên hanh lợi trinh, vật dụng hữu du vãng, lợi kiến hầu.",
                dichNghia = "Truân đầu cả, hanh thông, lợi tốt, chính bền, chớ dùng có thửa đi, lợi về dựng tước hầu.",
                giaiNghia = "Truân là đầy, truân là muốn vật mới sinh. Muốn vật mới sinh, uất kết chưa thông, cho nên thành ra đầy tắc ở trong trời đất; đến khi nó đã vọt tốt, thì ý đầy tắc mất rồi. Nghĩa nó là khó, tức là cái ý các vật mới mọc mà chưa thông đạt, cho nên chữ 屯(truân) do ở chữ 屮中(thảo) mà ra, giống như mầm cỏ dùi đất mới mọc mà chưa duỗi thẳng.\r\nTruân là thời kỳ gian nan, vất vả lúc ban đầu, khác với Khôn là gian nan lúc giữa cuộc, khác với Khốn là khốn khổ lúc chung cuộc, khác với Khảm là gian nan, hoạn nạn nói chung.\r\nQuẻ này là Chấn gặp Khảm, Kiền Khôn mới giao với nhau mà gặp chỗ hiểm hãm, cho nên tên nó là Truân. Trong chỗ hiểm mà còn động được, tuy là có thể hanh thông, mà ở chỗ hiểm, thì nên giữ đường ngay thẳng, chưa thể vội tiến, cho nên bói được quẻ này, thì lời Chiêm là cả hanh và lợi về đường ngay thẳng"
            },
            new QueKinhDichModel()
            {
                queSo = 4,
                tuongQue = "",
                queName = "Sơn Thủy Mông (蒙 méng)",
                loaiQue = "Hung",
                totChoViec = "",
                loiKinh = "蒙亨, 匪我求童蒙, 童蒙求我.初筮吿, 再三瀆, 瀆則不吿, 利貞.",
                dichAm = "Mông hanh, phỉ ngã cầu đồng mông, đồng mông cầu ngã. Sơ phệ cốc, tái tam độc, độc tắc bất cốc, lợi trinh.",
                dichNghia = "Quẻ Mông hanh, chẳng phải ta tìm trẻ thơ, trẻ thơ tìm ta. Mới bói bảo; hai, ba lần nhàm, không bảo. Lợi về sự chính.",
                giaiNghia = "Mông nghĩa là tối, các vật mới sinh, mờ tối chưa sáng. Quẻ này là Khảm gặp Cấn, dưới núi có chỗ hiểm, tức là cái đất mờ tối; trong hiểm ngoài đỗ tức là cái ý mờ tối, cho nên đặt tên là Mông. Dưới núi có chỗ hiểm là tượng của quẻ, Hiểm mà đỗ là Đức của quẻ.\r\nQuẻ Mông có hai nghĩa, Hiểm mà đỗ là hiểm ở trong, đỗ ở ngoài, trong nhà đã không yên ổn, mặt ngoài lại đi không được – Đó là cái tượng tối tăm."
            },
            new QueKinhDichModel()
            {
                queSo = 5,
                tuongQue = "",
                queName = "Thủy Thiên Nhu (需 xū)",
                loaiQue = "Cát",
                totChoViec = "Công danh sự nghiệp và Tình duyên – Gia đạo",
                loiKinh = "需, 有学, 光, 予, 貞, 吉, 利涉大川.",
                dichAm = "Nhu, hữu phu, quang, hanh, trinh, cát, lợi thiệp đại xuyên.",
                dichNghia = "Quẻ Nhu, có đức tín, sáng láng, hanh thông, chính bền, tốt! Lợi sang sông lớn.",
                giaiNghia = "Nhu là chờ đợi. Nói về hai thể, thì Kiền cứng mạnh cần tiến lên, mà gặp chỗ hiểm, chưa thể tiến được, cho nên là nghĩa chờ đợi. Nói về tài quẻ, thì hào Năm ở ngôi vua, là chủ sự chờ đợi, có đức cứng mạnh, trung chính, mà sự thành tín đầy đặc bên trong, tức là bên trong đầy đặc có đức tin; có đức tin thì sáng láng mà có thể hanh thông, được trinh chính và tốt. Dùng những cái đó mà chờ đợi, thì gì mà không qua: dù hiểm cũng không khó. Cho nên, kẻ xem, nếu là có sự chờ đợi mà tự mình sẵn có đức tin thì sẽ sáng láng hanh thông; nếu lại được chính thì tốt mà lợi về việc sang sông lớn (Việc Đại sự – Đại nghiệp). Chính bền thì không cái gì không tốt, mà sự sang sông lại càng quý ở chờ đợi."
            },
            new QueKinhDichModel()
            {
                queSo = 6,
                tuongQue = "",
                queName = "Thiên Thủy Tụng (訟 sòng)",
                loaiQue = "Hung",
                totChoViec = "",
                loiKinh = "訟, 有孚窒惕, 中吉, 終凶, 利見大人, 不利涉大川.",
                dichAm = "Tụng, hữu phu chất dịch, trung cát, chung hung, lợi kiến đại nhân, bất lợi thiệp đại xuyên.",
                dichNghia = "Kiện, có thật, bị lấp, phải Sợ, vừa phải, tốt; theo đuổi đến chót, xấu; lợi về sự thấy người lớn, không lợi về sự sang sông lớn.",
                giaiNghia = "Tụng là tranh kiện. Trên Kiền dưới Khảm, Kiền cứng Khảm hiểm, người trên dùng sự cứng để chê kẻ dưới, kẻ dưới dùng sự hiểm để nhòm người trên, lại là mình hiểm mà nó mạnh, đều là đạo kiện. Quẻ này hào Chín Hai giữa đặc mà không có kẻ ứng cùng, lại là thêm lo. Vả, theo quái biến, nó tự quẻ Độn mà hại, tức là kẻ cứng đến ở hào Hai mà nhằm vào giữa thể dưới, có tượng có sự thật bị lấp, biết sợ mà hợp với lẽ vừa phải; hào Chín Trên quá cứng ở cuối sự kiện, có tượng theo đuổi việc kiện đến cùng! Hào Chín Năm cứng mạnh, trung chính ở ngôi tôn, có tượng người lớn; lấy tư cách Dương cương cưỡi lên chỗ hiểm, ấy là sự đầy đặc xéo vào chỗ hãm, có tượng không lợi về sự sang sông lớn, cho nên mới răn kẻ xem ắt có sự tranh biện và tuỳ theo chỗ của họ ở mà thành ra lành hay dữ."
            },
            new QueKinhDichModel()
            {
                queSo = 7,
                tuongQue = "",
                queName = "Địa Thủy Sư (師 shī)",
                loaiQue = "Cát",
                totChoViec = "Công danh sự nghiệp",
                loiKinh = "師貞, 丈人吉无咎.",
                dichAm = "Sư trinh, trượng nhân cát, vô cữu.",
                dichNghia = "Quân chính, bậc trượng nhân tốt, không lỗi.",
                giaiNghia = "Sư là quân chúng. Quẻ này dưới Khảm trên Khôn, Khảm hiểm mà Khôn thuận, Khảm là nước mà Khôn là đất, đời xưa ngụ hình ở nông, núp cái rất hiểm chỗ cả thuận, giấu cái không thể lường trong chỗ rất tĩnh. Lại nữa, trong quẻ chỉ hào Chín Hai là một hào Dương ở giữa quẻ dưới, là tượng làm tướng; trên dưới năm hào Âm đều phải thuận mà theo, là tượng làm quân. Hào Chín Hai lấy tư cách Dương cương ở dưới làm việc, hào Sáu Năm là hạng mềm yếu ở trên mà dùng người, tức là cái tượng ông vua sai tướng ra quân, cho nên quẻ này gọi tên là Sư. Trượng nhân là tiếng để gọi bậc trưởng lão, cái đạo dùng quân lợi về được chính đính, mà phải dùng người lão thành, mới được tốt mà không có lỗi."
            },
            new QueKinhDichModel()
            {
                queSo = 8,
                tuongQue = "",
                queName = "Thủy Địa Tỷ (比 bǐ)",
                loaiQue = "Cát",
                totChoViec = "Công danh sự nghiệp và Tình Duyên – Gia đạo",
                loiKinh = "比吉, 原策元, 永, 貞, 无咎, 不寧方來, 後夫凶",
                dichAm = "Tỷ cát, nguyên phệ nguyên, vĩnh, trinh, vô cữu. Bất ninh phương lai, hậu phu hung.",
                dichNghia = "Liền nhau tốt, truy nguyên việc bói, đầu cả, lâu dài, chính bền, không lỗi!",
                giaiNghia = "Tỷ là gần nhau liền nhau, hào Chín Năm lấy tư cách Dương cương ở giữa quẻ trên mà được chỗ chính, năm hào Ảm ở trên và dưới đều gần lại mà theo đó là cái tượng một người vỗ về muôn nước, bốn bề trông lên một người.\r\n\r\nQuẻ này trên Khảm, dưới Khôn, nói về hai thể, thì là nước ở trên đất; các vật liền khít với nhau không có ngăn cách, không gì bằng nước ở trên đất, cho nên mới là quẻ Tỷ. Lại nữa, các hào đều thuộc về Âm, riêng có hào Năm là Dương cương, ở ngôi vua, chúng đều thân phụ, mà kẻ trên cũng thân với người dưới."
            },
            new QueKinhDichModel()
            {
                queSo = 9,
                tuongQue = "",
                queName = "Phong Thiên Tiểu Súc (小畜 xiǎo chù)",
                loaiQue = "Bình hòa",
                totChoViec = "",
                loiKinh = "小畜亨, 密雲不雨, 自我西郊.",
                dichAm = "Tiểu súc hanh, mật vân bất vũ, tự ngã tây giao.",
                dichNghia = "Chứa nhỏ hanh thông, mây dày không mưa, tự cõi tây ta.",
                giaiNghia = "Súc tức là đậu, đậu thì là hợp. Nó là quẻ Tôn trên Kiền dưới, Kiền là vật ở trên, thế mà lại ở dưới Tốn. Ôi chứa đậu sự cứng mạnh, không gì bằng sự nhún thuận; bị sự nhún thuận chứa đậu, cho nên là súc. Nhưng mà Tốn thuộc về Âm, thể nó mềm thuận, chỉ biết dùng sự nhún thuận để làm cho mềm sự cứng mạnh, không phải sức nó có thể ngăn được. Đó là cách chứa còn nhỏ. Lại, hào Tư là một hào Âm, bị năm hào Dương đẹp lòng, được ngôi, tức là được đạo mềm thuận, có thể nuôi được chí ý của các hào Dương, cho nên là súc. Tiểu súc là lấy cái nhỏ mà chứa cái lớn, thì cái chứa hợp cũng nhỏ."
            },
            new QueKinhDichModel()
            {
                queSo = 10,
                tuongQue = "",
                queName = "Thiên Trạch Lý (履 lǚ)",
                loaiQue = "Cát",
                totChoViec = "Công danh sự nghiệp và Tình duyên – Gia đạo: Nhu thuận, hòa hợp",
                loiKinh = "履虎尾, 不哇人, 亨.",
                dichAm = "Lý hổ vĩ, bất chất nhân, hanh",
                dichNghia = "Xéo đuôi cọp, không cắn người, hanh!",
                giaiNghia = "Lý tức là lễ, lễ là cái mà người ta xéo lên. Nó là quẻ trời trên chầm dưới, trời mà ở trên, chầm mà ở dưới, đó là phận trên dưới, là nghĩa tôn ty, lẽ phải như thế. Lễ là gốc của đạo làm người và là con đường người ta thường thường xéo lên, cho nên mới là quẻ Lý.\r\n\r\nVề tượng quẻ: Trên là dương cương, là Càn, là trời: dưới là âm nhu, là Đoài, là chằm, vậy là trên dưới phân minh lại hợp lẽ âm dương tức là lễ, là lý. Có tính âm nhu, vui vẻ đi theo sau dương cương thì dù người đi trước mình dữ như cọp, cũng tỏ ra hiền từ với mình, cho nên bảo rằng dẫm lên đuôi cọp mà cọp không cắn. Ba chữ “lý hổ vĩ” chính nghĩa là dẫm lên đuôi cọp, chỉ nên hiểu là đi theo sau cọp, lấy sự nhu thuận, vui vẻ mà ứng phó với sự cương cường.\r\n\r\nQuẻ Lý là mềm xéo theo cứng. Đẹp lòng mà ứng với trời, thế cho nên xéo đuôi cọp, không cần người, hanh. Dương cương trung chính, xéo ngôi vua mà không mỏi mệt, sáng láng vậy."
            },
            new QueKinhDichModel()
            {
                queSo = 11,
                tuongQue = "",
                queName = "Địa Thiên Thái (泰 tài)",
                loaiQue = "Cát hanh",
                totChoViec = "- Công danh sự nghiệp: Tài lộc (kinh doanh); Quan lộc\r\n– Thi cử, khoa bảng\r\n– Tình duyên gia đạo: Hòa thuận, trong ấm ngoài êm",
                loiKinh = "泰, 小往, 大來, 吉亨.",
                dichAm = "Thái, tiểu vãng, đại lai, cát hanh.",
                dichNghia = "Quẻ Thái, nhỏ đi, lớn lại, lành tốt hanh thông.",
                giaiNghia = "Thái là hanh thông, nó là quẻ trời đất giao nhau mà hai khí thông nhau, cho nên là thái, quẻ tháng giêng đó. Nhỏ là Âm, lớn là Dương, ý nói Khôn đi ở ngoài, Kiền đến ở trong. Quẻ Thái, nhỏ đi lớn lại, tốt và hanh thông, trời đất giao nhau mà muôn vật hanh thông vậy; trên dưới giao nhau mà chí giống nhau vậy. Trong Dương mà ngoài Âm, trong mạnh mà ngoài thuận."
            },
            new QueKinhDichModel()
            {
                queSo = 12,
                tuongQue = "",
                queName = "Thiên Địa Bĩ (否 pǐ)",
                loaiQue = "Hung",
                totChoViec = "",
                loiKinh = "否之匪人, 不利君子貞, 大往小來.",
                dichAm = "Bĩ chi phỉ nhân. Bất lợi quân tử trinh, đại vãng tiểu lai.",
                dichNghia = "Bĩ đấy, chẳng phải người. Chẳng lợi cho sự chính bền của đấng quân tử, lớn đi nhỏ lại.",
                giaiNghia = "Bĩ là bế tắc, tức là quẻ tháng bảy, trái nhau với quẻ Thái, cho nên nói là “phỉ nhân”, nghĩa là không phải đạo người. Lời chiêm của nó không lợi về chính đạo của quân tử. Trời đất không giao nhau, thì không sinh ra muôn vật, ấy là không có đạo người. Trinh tức là chính đạo của đấng quân tử, bị bĩ tắc mà không thực hành được, lớn đi nhỏ lại, tức là Dương đi mà Âm lại. Đó là tượng “đạo kẻ tiểu nhân lớn lên, đạo người quân tử tiêu đi”, cho nên là bĩ."
            },
            new QueKinhDichModel()
            {
                queSo = 13,
                tuongQue = "",
                queName = "Thiên Hỏa Đồng Nhân (同人 tóng rén)",
                loaiQue = "Cát",
                totChoViec = "Công danh sự nghiệp: Tài lộc, có quý nhân phù trợ\r\nTình duyên gia đạo: Hòa hợp, hạnh phúc\r\nCải vận – Giải hạn: Có quý nhân phù trợ",
                loiKinh = "同人于野, 亨, 利涉大川, 利君子貞.",
                dichAm = "Đồng nhân vu dã, hanh, lợi thiệp đại xuyên; lợi quân tử trinh.",
                dichNghia = "Cùng người ở đồng, hanh thông, lợi về sự sang sông lờn, lợi cho sự chính bền của đấng quân tử.",
                giaiNghia = "Đồng là nơi rộng rỗng, lấy nghĩa ở xa và ở ngoài. Ôi chung cùng với người bằng đạo đại đồng của thiên hạ là lòng rất công của thánh hiền. Hễ đã có thể đại đồng với thiên hạ thì thiên hạ cũng chung cùng với mình; thiên hạ đã chung cùng, thì còn sự hiểm trở nào không thể vượt qua? Còn sự gian nguy nào không thể hanh thông? Cho nên lợi về sự sang sông lớn, lợi cho sự chính bền của đấng quân tử."
            },
            new QueKinhDichModel()
            {
                queSo = 14,
                tuongQue = "",
                queName = "Hỏa Thiên Đại Hữu (大有 dà yǒu)",
                loaiQue = "Nguyên Hanh (Đại cát)",
                totChoViec = "Công danh sự nghiệp: Tài lộc, có quý nhân phò tá\r\nCải vận: Tránh tật ách",
                loiKinh = "大有元亨.",
                dichAm = "Đại hữu nguyên hanh.",
                dichNghia = "Quẻ Đại hữu cả lớn hanh thông.",
                giaiNghia = "Đại hữu tức là sự “có” cả lớn. Ly ở trên Càn, ấy là lửa ở trên trời, không gì không soi. Nó là quẻ lửa ở trên trời, lửa ở chỗ cao, ánh sáng của nó tới xa, thì dẫu nhiều đến muôn vật cũng không vật nào mà không soi thấy, ấy là cái tượng cả có. Lại nữa, một hào mềm ở ngôi tôn, các hào dương cùng ứng với nó, ở ngôi tôn mà giữ đạo mềm mỏng, tức là kẻ mà người ta theo về, trên dưới ứng nhau, ấy là nghĩa cả có, cả có nghĩa là thịnh cả giàu có. Tức là tài quẻ có thể cả lớn hanh thông. Vì nó cương kiên văn minh, ứng nhau với trời mà làm việc phải thì, cho nên có thể cả lớn hanh thông."
            },
            new QueKinhDichModel()
            {
                queSo = 15,
                tuongQue = "",
                queName = "Địa Sơn Khiêm (謙 qiān)",
                loaiQue = "Cát",
                totChoViec = "– Công danh sự nghiệp: Có phúc lộc nhờ khiêm nhường, sáng suốt\r\n– Tình duyên gia đạo: Hòa thuận",
                loiKinh = "謙亨, 君子有終.",
                dichAm = "Khiêm hanh, quân tử hữu chung.",
                dichNghia = "Quẻ Khiêm hanh thông, đấng quân tử có sau chót.",
                giaiNghia = "Khiêm là có mà không ở. Đỗ ở trong, thuận ở ngoài, tức là ý khiêm. Quẻ Khiêm là quẻ có đạo hanh thông. Có đức mà không tự nhận, gọi là Khiêm. Người ta lấy sự khiêm tốn tự xử thì đi đâu mà không hanh thông? “Đấng quân tử có sau chót”, nghĩa là đấng quân tử chí ở khiêm tốn hiểu lẽ, cho nên vui với mệnh trời mà không cạnh tranh; bên trong đầy đủ, cho nên tự mình lui nhún, mà không khoe khoang, yên lặng xéo noi sự khiêm suốt đời không đổi, mình tự hạ mình mà người ta càng tôn lên, mình tự che cho tôi đi, mà đức càng sáng tỏ; đó là đấng quân tử có sau chót."
            },
            new QueKinhDichModel()
            {
                queSo = 16,
                tuongQue = "",
                queName = "Lôi Địa Dự (豫 yù)",
                loaiQue = "Lợi (có lợi cho việc)",
                totChoViec = "– Công danh sự nghiệp: Có lợi trong việc mở rộng cơ sở, chi nhánh, phân hiệu",
                loiKinh = "豫, 利建侯, 行師.",
                dichAm = "Dự, lợi kiến hầu, hành sư.",
                dichNghia = "Quẻ Dự, lợi cho sự dựng nước hầu, trẩy quân.",
                giaiNghia = "Dự là hoà vui, tức là lòng người hoà vui để ứng nhau với người trên. Dự là thuận mà động, nghĩa của quẻ Dự lợi ở sự dựng nước hầu, trẩy quân. Dựng nước là dựng phên tường để cho cùng yên, thiên hạ chư hầu hoà thuận thì muốn dân vui phục; quân lữ dấy lên, lòng người hoà đẹp, thì sẽ thuận theo mà có công, cho nên cái đạo đẹp vui lợi ở sự dựng nước hầu trẩy quân. Lại, trên động mà dưới thuận, đó là cái tượng chư hầu theo nhà vua, binh chúng thuận theo mệnh lệnh."
            },
            new QueKinhDichModel()
            {
                queSo = 17,
                tuongQue = "",
                queName = "Trạch Lôi Tùy (隨 suí)",
                loaiQue = "Bình hòa (vô cữu – Không lỗi)",
                totChoViec = "",
                loiKinh = "隨元亨利貞, 无咎.",
                dichAm = "Tuỳ nguyên hanh lợi trinh, vô cữu.",
                dichNghia = "Quẻ Tuỳ cả, lợi, trinh, không lỗi.",
                giaiNghia = "Tuỳ tức là theo. Lấy lẽ quái biến mà nói, thì quẻ này vốn tự quẻ Khốn, hào Chín đến ở ngôi Đầu; lại tự quẻ Phệ hạp, hào Chín đến ở ngôi Năm; mà tự quẻ Vị tế lại, thì kiêm cả hai sự biến đổi đó; tất cả đều là nghĩa cứng đến theo mềm. Lấy hai thể mà nói, thì thể này động mà thể kia đẹp lòng, cũng là nghĩa của sự theo, cho nên mới là quẻ Tuỳ. Mình hay theo người, người đến theo mình, đằng nọ đằng kia theo nhau thì sự hanh thông rất dễ, cho nên lời chiêm của nó mới là cả hanh. Nhưng phải lợi về sự trinh thì mới không lỗi."
            },
            new QueKinhDichModel()
            {
                queSo = 18,
                tuongQue = "",
                queName = "Sơn Phong Cổ (蠱 gǔ)",
                loaiQue = "Hung",
                totChoViec = "",
                loiKinh = "蠱元亨, 利涉大川, 先甲三日, 後甲三日.",
                dichAm = "Cổ nguyên hanh, lợi thiệp đại xuyên, tiên giáp tam nhật, hậu giáp tam nhật.",
                dichNghia = "Quẻ Cổ cả, hanh, lợi về sang sông lớn. Trước giáp ba ngày, sau giáp ba ngày.",
                giaiNghia = "Cổ là nát hỏng đến cực điểm mà phải có việc. Quẻ có Cấn cứng ở trên, Tôn mềm ở dưới, trên dưới không giao với nhau, dưới mềm nhún mà trên cẩu thả dừng đậu, cho nên là cổ. Cổ là nát hỏng cực điểm, loạn rồi thì phải lại trị, cho nên lời chiêm của nó là cả hanh mà lợi về sang sông lớn."
            },
            new QueKinhDichModel()
            {
                queSo = 19,
                tuongQue = "",
                queName = "Địa Trạch Lâm (臨 lín)",
                loaiQue = "Vô Hối (Cẩn trọng, phòng ngừa rủi ro thì không hối hận)",
                totChoViec = "",
                loiKinh = "臨元亨利貞, 至于八月有凶",
                dichAm = "Lâm nguyên hanh lợi trinh, chí vu bát nguyệt hữu",
                dichNghia = "Quẻ Lâm, cả, hanh, lợi, trinh, đến chưng tám tháng, có hung.",
                giaiNghia = "Lâm là tiến lên mà lấn sát, đến một vật gì. Hai khí Dương đương lớn, dần dần lấn bức khí Âm. Hai khí Dương đương lớn lên ở dưới, là lúc Dương đạo sắp thịnh, thánh nhân răn sần mà rằng: “Khí Dương tuy đương thịnh, đến tám tháng thì nó tiêu đi, ấy là có hung”. Đại để thánh nhân răn là tự lúc đương thịnh mà lo rằng suy, thì mới có thể ngăn ngừa sự quá đầy mà mưu tính cuộc lâu dài."
            },
            new QueKinhDichModel()
            {
                queSo = 20,
                tuongQue = "",
                queName = "Phong Địa Quan (觀 guān)",
                loaiQue = "Bình hòa",
                totChoViec = "",
                loiKinh = "觀, 盥而不薦, 有孚顒若.",
                dichAm = "Quan, quán nhi bất tiến, hữu phu ngung nhược.",
                dichNghia = "Quẻ quan, rửa mà không cứng, có tin, dường cung kính vậy.",
                giaiNghia = "觀(Quán) là lấy sự trung chính bảo người, bị người ngửa lên mà trông. Trông xem các vật là quan, làm cái xem cho kẻ dưới là quán. Ông vua trên xem đạo trời, dưới xem tục dân là quan, sửa đức làm chính, bị dân ngửa xem là quán. Gió đi trên đất, đụng khắp muôn loài, là tượng “khắp xem”;"
            },
            new QueKinhDichModel()
            {
                queSo = 21,
                tuongQue = "",
                queName = "Hỏa Lôi Phệ Hạp (噬嗑 shì kè)",
                loaiQue = "Bình hòa",
                totChoViec = "",
                loiKinh = "噬嗑亨, 利用獄.",
                dichAm = "Phệ hạp hanh, lợi dụng ngục.",
                dichNghia = "Quẻ Phệ hạp hanh, lợi dùng việc ngục.",
                giaiNghia = "Phệ là cắn, hạp là hợp, vật có chỗ cách, phải cắn mới hợp lại được. Quẻ này trên dưới hai hào Dương mà giữa trông rỗng, là tượng cái miệng. Quẻ Phệ hạp hanh, vì quẻ tự có nghĩa hanh. Việc trong thiên hạ, sở dĩ không được hanh thông là vì có chỗ ngăn cách; cắn mà hợp lại, thì hanh thông rồi. Lợi dùng việc ngục, nghĩa là cái đạo “cắn mà hợp lại” nên dùng về việc hình ngục vậy. Lại, ngăn cách ở thiên hạ, phi hình ngục lấy gì mà trừ bỏ được? không nói “lợi dùng việc hình” mà nói “lợi dùng việc ngục” là vì trong quẻ có tượng sáng soi, lợi về sự xét ngục vậy. Ngục là để xét trị sự thật sự dối. Biết được tình thật, thì biết cái đạo làm cho ngăn cách, rồi mới có thể đặt cách ngăn ngừa và dùng hình phạt."
            },
            new QueKinhDichModel()
            {
                queSo = 22,
                tuongQue = "",
                queName = "Sơn Hỏa Bí (賁 bì)",
                loaiQue = "Cát",
                totChoViec = "Công danh sự nghiệp: Thuận lợi hanh thông, làm việc nhỏ mà kết quả lớn.",
                loiKinh = "賁亨, 小有攸往.",
                dichAm = "Bí hanh, tiểu lợi hữu du vãng.",
                dichNghia = "Quẻ Bí danh, hơi lợi có thửa đi.",
                giaiNghia = "Bí là trang sức. Các vật có trang sức mới có thể hanh thông, cho nên nói rằng: “Không gốc không đứng, không có văn vẻ thì không làm được”, có sự thực mà thêm văn sức, thì có thể hanh. Cái đạo văn sức, có thể thêm phần sáng sủa văn vẻ, cho nên hơi lợi về sự tiến lên."
            },
            new QueKinhDichModel()
            {
                queSo = 23,
                tuongQue = "",
                queName = "Sơn Địa Bác (剝 bō)",
                loaiQue = "Hung",
                totChoViec = "",
                loiKinh = "剝不利有攸往.",
                dichAm = "Bác bất lợi hữu du vãng.",
                dichNghia = "Quẻ Bác không lợi có thửa đi.",
                giaiNghia = "Bác nghĩa là rụng. Quẻ Bác là lúc các khí Âm lớn thịnh, tiều gọt khí dương, cũng tức là lúc những kẻ tiểu nhân gọt đẽo quân tử, cho nên đấng quân tử không lợi có thửa đi, chỉ nên nhún lời nói, giấu tung tích, tuỳ thời nghe ngóng, cho khỏi bị kẻ tiểu nhân làm hại."
            },
            new QueKinhDichModel()
            {
                queSo = 24,
                tuongQue = "",
                queName = "Địa Lôi Phục (復 fù)",
                loaiQue = "Bình hòa (vô cữu – Không lỗi)",
                totChoViec = "",
                loiKinh = "復亨, 出入無疾, 朋來无咎.",
                dichAm = "Phục hanh, xuất nhập vô tật, bằng lai vô cữu.",
                dichNghia = "Quẻ Phục hanh, ra vào không tật, bạn đến không lỗi.",
                giaiNghia = "Phục hanh nghĩa là đã trở lại thì hanh thông. Khí Dương đã sinh ở dưới, dần dần hanh thịnh mà sinh nuôi muôn vật; đạo đấng quân tử đã trở lại thì dần dần hanh thông, tưới tắm cho thiên hạ, cho nên quẻ Phục có lẽ hanh thịnh. “Ra vào không tật” nghĩa là cái khí Dương nhỏ sinh rồi lớn, không có cái gì hại nó. Đã không có cái gì hại nó mà loại của nó dần dần tiến đến, thì là sắp sửa hanh thịnh, cho nên không lỗi."
            },
            new QueKinhDichModel()
            {
                queSo = 25,
                tuongQue = "",
                queName = "Thiên Lôi Vô Vọng (無妄 wú wàng)",
                loaiQue = "Vô lợi (không tốt)",
                totChoViec = "",
                loiKinh = "無妄元亨, 利貞, 其匪正, 有眚, 不利有攸往",
                dichAm = "Vô vọng nguyên hanh, lợi trinh, kỳ phỉ chính, hữu sảnh, bất lợi hữu du vãng.",
                dichNghia = "Quẻ Vô Vọng cả hanh, lợi về sự chính bền; thửa chẳng chính có tội, không lợi có thửa đi.",
                giaiNghia = "Vô Vọng nghĩa là thực lý tự nhiên, sách Sử ký chép là 無望(vô vọng) nghĩa là “không cần kỳ vọng mà cũng có được”. Quẻ Vô Vọng tức là đạo trời, trong quẻ cốt nói về lẽ người ta theo đạo “không càn”. Lợi trinh nghĩa là cái cách bắt chước đạo không càn, lợi ở sự trinh chính, không trinh chính là càn. Tuy không tà tâm, mà nếu không hợp chính lý thì là càn, là có tà tâm, cho nên chẳng chính thì là tội lỗi. Đã không càn thì không nên có sự đi, đi thì là càn."
            },
            new QueKinhDichModel()
            {
                queSo = 26,
                tuongQue = "",
                queName = "Sơn Thiên Đại Súc (大畜 dà chù)",
                loaiQue = "Cát",
                totChoViec = "– Công danh sự nghiệp: nhiều tài lộc\r\n– Khoa bảng: Thi cử đỗ đạt",
                loiKinh = "大畜利貞, 不家食, 吉, 利涉大川.",
                dichAm = "Đại Xúc lợi trinh, bất gia thực, cát, lợi thiệp đại xuyên.",
                dichNghia = "Quẻ Đại Xúc lợi về sự chính, chẳng ăn ở nhà, tốt lợi sang sông lớn.",
                giaiNghia = "Xúc là chứa ngăn, lại là chứa họp, Phàm sự chứa họp, đều chuyên nói về cái lớn hơn. Sự chứa đựng, nên được chính đạo, cho nên nói là lợi về sự chính. Đã có đạo đức đầy chứa ở trong, nên ở ngôi trên, để hưởng lộc trời, thi thố với thiên hạ, thì chẳng những là tốt một mình, mà lại tốt cả thiên hạ."
            },
            new QueKinhDichModel()
            {
                queSo = 27,
                tuongQue = "",
                queName = "Sơn Lôi Di (頤 yí)",
                loaiQue = "Cát hanh",
                totChoViec = "Công danh sự nghiệp: Tài lộc, quan lộc hanh thông",
                loiKinh = "頤 : 貞 吉 . 觀 頤 . 自 求 口 實 .",
                dichAm = "Di Trinh cát. Quan Di. Tự cầu khẩu thật.",
                dichNghia = "Quẻ Di, chính tốt, xem sự nuôi, tự tìm cái thật của miệng.",
                giaiNghia = "Di là chỗ cạnh miệng, miệng ăn đồ ăn để tự nuôi, cho nên mới là nghĩa nuôi. Nó là quẻ trên dưới hai hào Dương, trong ngậm bốn hào Âm, ngoài đặc, trong rỗng. trên đậu dưới động, là Tượng cái mép, và có nghĩa là xem cách thửa nuôi.\r\n\r\nĐây là thánh nhân nói cho cùng tận đạo nuôi mà tán dương sự lớn của nó. Đạo của trời đất là nuôi nấng muôn vật, mà đạo nuôi nâng muôn vật chỉ có sự chính mà thôi. Đấng thánh nhân thì nuôi nấng những bậc hiền tài, cùng họ chung ngôi trời, để họ ăn lộc trời, khiến họ thi ân với thiên hạ, đó là nuôi người hiền để tới muôn dân, nuôi người hiền là nuôi muôn dân vậy."
            },
            new QueKinhDichModel()
            {
                queSo = 28,
                tuongQue = "",
                queName = "Trạch Phong Đại Quá (大過 dà guò)",
                loaiQue = "Đại Cát",
                totChoViec = "",
                loiKinh = "大過, 棟撓, 利有攸往, 亨.",
                dichAm = "Đại quá, đống nạo, lợi hữu du vãng, hanh.",
                dichNghia = "Quẻ Đại Quá, cột ỏe, lợi có thửa đi, hanh.",
                giaiNghia = "Quẻ Tiểu Quá khí Âm quá ở trên và dưới, quẻ Đại Quá khí Dương quá ở giữa. Dương quá ở giữa mà trên, dưới yếu rồi, cho nên là tượng cột ỏe. Cột là lấy nghĩa chịu nổi sự nặng, bốn hào Dương họp cả ở giữa, có thể bảo là nặng rồi. Hào Chín Ba và hào Chín Tư đều lấy tượng cái cột, ý nói nó gánh việc nặng, ỏe là lấy nghĩa gốc ngọn đều yếu, giữa mạnh mà gốc ngọn yếu, cho nên mới ỏe. Khí Âm yếu mà khí Dương mạnh, đấng quân tử thịnh mà kẻ tiểu nhân thì suy, cho nên lợi có thửa đi mà hanh."
            },
            new QueKinhDichModel()
            {
                queSo = 29,
                tuongQue = "",
                queName = "Thuần Khảm (坎 kǎn)",
                loaiQue = "Bình Hòa (vô hối)",
                totChoViec = "",
                loiKinh = "習坎有孚維心, 亨, 行有尚.",
                dichAm = "Tập khảm hữu phu duy tâm, hanh, hành hữu thượng.",
                dichNghia = "Quẻ Khảm kép, có tin, bui lòng, hanh, đi có chuộng.",
                giaiNghia = "Khảm là hiểm hãm, tượng nó là nước. Dương hãm trong Âm, ngoài hư mà trong thực vậy. Quẻ này trên dưới là thể Khảm, đó là hai lần hiểm; Dương đặc ỗ giữa, là trong có sự phu tín. Bui lòng hanh, nghĩa là chỉ vì trong lòng thành thực chuyên nhất, cho nên có thể hanh thông. Lòng chí thành có thể suốt được vàng đá, nhảy vào nước lửa còn sự hiểm nạn nào mà không thể hanh? Đi có chuộng ý nói lấy sự thành thật chuyên nhất mà đi, thì có thể ra khỏi chỗ hiểm đáng được khen chuộng, tức là có công vậy."
            },
            new QueKinhDichModel()
            {
                queSo = 30,
                tuongQue = "",
                queName = "Thuần Ly (離 lí)",
                loaiQue = "Hanh",
                totChoViec = "Công danh sự nghiệp",
                loiKinh = "離利貞, 亨, 畜牝牛, 吉.",
                dichAm = "Ly lợi trinh, hanh, xúc tẫn ngưu, cát.",
                dichNghia = "Quẻ Ly lợi về sự chính, hanh, nuôi trâu cái, tốt.",
                giaiNghia = "Ly là bám, Âm bám vào Dương, Tượng nó là lửa; thể là Âm mà dụng là Dương. Sự dính bám của các vật quý được chính đạo. Muôn vật chẳng vật nào không có chỗ bám. Có hình thì có bám, ở người ta, thì là: những kẻ thân phụ những đường noi theo, những việc chủ trương, đều là bám cả. Cái mà người ta vẫn bám, lợi về trinh chính, được chính thì có thể hanh thông, cho nên nói rằng quẻ Ly lợi về sự chính, hanh. Nuôi trâu cái tốt, nghĩa là: tính trâu đã thuận, mà lại cái nữa, tức là thuận đến tột bậc."
            },
            new QueKinhDichModel()
            {
                queSo = 31,
                tuongQue = "",
                queName = "Trạch Sơn Hàm (咸 xián)",
                loaiQue = "Cát Hanh",
                totChoViec = "Công danh sự nghiệp: nhiều tài lộc, thăng tiến\r\nTình duyên – Gia đạo: Hôn nhân hòa hợp, viên mãn",
                loiKinh = "咸亨, 利貞, 取女, 吉。",
                dichAm = "Hàm hanh, lợi trinh, thù nữ, cát.",
                dichNghia = "Quẻ Hàm hanh, lợi chính, lấy con gái, tốt.",
                giaiNghia = "Hàm là giao cảm. Đoái mềm ở trên, Cấn cứng ở dưới, mà cùng cảm ứng với nhau. Lại, Cấn chủ đậu, thì sự cảm được chuyên nhất. Đoái chủ đẹp lòng thì sự ứng đến tột bậc. Hàm tức là cảm, nhưng không nói cảm, vì hàm còn có nghĩa nữa là đều, tức là trai gái cảm lẫn nhau vậy. Các vật cảm nhau, không gì thiết tha bằng trai với gái mà hạng tuổi trẻ càng thiết tha hơn. Các vật cảm nhau thì có lẽ hanh thông, cho nên quẻ Hàm mới có lẽ hanh. Lợi trinh nghĩa là cái đạo cảm nhau, lợi về sự chính."
            },
            new QueKinhDichModel()
            {
                queSo = 32,
                tuongQue = "",
                queName = "Lôi Phong Hằng (恆 héng)",
                loaiQue = "Cát",
                totChoViec = "– Công danh sự nghiệp: Tài lộc bền vững\r\n– Tình duyên gia đạo: Yên bình, ổn định",
                loiKinh = "恆亨, 无咎, 利貞, 利有攸往.",
                dichAm = "Hằng hanh, vô cữu, lợi trinh, lợi hữu du vãng.",
                dichNghia = "Quẻ Hằng hanh, lợi về sự chính, lợi có thửa đi.",
                giaiNghia = "Hằng là thường lâu, đạo hằng có thể hanh thông, hễ thường thường theo giữ đạo ấy mà có thể hanh thông mới là không đổi. Ví như đấng quân tử thường thường theo giữ điều thiện, đó là cái đạo có thể thường thường theo giữ; Đạo hằng sở dĩ hanh được, là vì trinh chính, cho nên nói là “lợi trinh”.\r\nCứng lên mà mềm xuống, sấm gió cùng nhau, nhún mà động, cứng mềm đều ứng nhau, là quẻ Hằng."
            },
            new QueKinhDichModel()
            {
                queSo = 33,
                tuongQue = "",
                queName = "Thiên Sơn Độn (遯 dùn)",
                loaiQue = "Vô cữu (không lỗi)",
                totChoViec = "",
                loiKinh = "遯亨, 小利貞.",
                dichAm = "Độn hanh, tiểu lợi trinh.",
                dichNghia = "Quẻ Độn hanh, nhỏ lợi trinh.",
                giaiNghia = "Độn là lui tránh, nó là quẻ hai khí Âm lớn dần, khí Dương nên lui tránh, cho nên là trốn, tức là quẻ thuộc về tháng sáu. Quẻ Độn là lúc Âm lớn Dương tiêu, đấng quân tử trốn nấp. Đấng quân tử lui nấp, là để làm cho đạo của mình thẳng ra. Đạo không bị khuất thì là hanh, cho nên quẻ Độn có nghĩa hanh. Trong việc, cũng có khi vì sự trốn lánh mà hanh thông, dẫu là lúc đạo kẻ tiểu nhân đương lớn, đấng quân tử biết cơ lui tránh vẫn phải, nhưng mà việc đời có lúc không giống nhau, phải tuỳ theo thời thế, không cần phải ắt như nhau. Âm mềm đương lớn mà nó chưa đến thịnh lắm, đấng quân tử cũng có cách từ từ ra sức, tuy không thể trinh lớn mà còn lợi cho sự trinh nhỏ vậy."
            },
            new QueKinhDichModel()
            {
                queSo = 34,
                tuongQue = "",
                queName = "Lôi Thiên Đại Tráng (大壯 dà zhuàng)",
                loaiQue = "Lợi",
                totChoViec = "",
                loiKinh = "大壯利貞.",
                dichAm = "Đại tráng lợi trinh.",
                dichNghia = "Quẻ Đại tráng lợi về sự chính.",
                giaiNghia = "Đại tráng thì là khí Dương mạnh thịnh. Nó là quẻ Chấn trên Kiền dưới, Kiền cứng mà Chấn động, lấy đức cứng mà động là nghĩa lớn mạnh. Dương cứng là lớn tức là khí Dương lớn lên quá bậc giữa rồi. Lớn là mạnh thịnh. Lại, oai dữ như sấm mà ở trên trời, cũng là nghĩa lớn mạnh."
            },
            new QueKinhDichModel()
            {
                queSo = 35,
                tuongQue = "",
                queName = "Hỏa Địa Tấn (晉 jìn)",
                loaiQue = "Cát Hanh",
                totChoViec = "Công danh sự nghiệp: Thời cuộc cực thịnh, vạn việc chảy trôi, hoàn thành đại nghiệp",
                loiKinh = "晉, 康侯用錫馬蕃庶, 晝日三接.",
                dichAm = "Tấn, khang hầu dụng tích mã phồn thứ, trú nhật tam tiếp.",
                dichNghia = "Quẻ Tấn, tước hầu yên dùng cho ngựa giậm nhiều, ban ngày ba lần tiếp.",
                giaiNghia = "Quẻ Tấn là thì tiến thịnh, sự sáng lớn ở trên, mà thể dưới êm thuận phụ vào, tức là tượng chư hầu vâng theo nhà vua, cho nên là tước hầu yên. Tước hầu yên nghĩa là tước hầu trị an, gặp được bề trên cả sáng, mà biết dốc lòng để thuận theo, đó là tước hầu trị an, vì vậy mới được bề trên yêu đương, cho ngựa rất nhiều. Xe ngựa là của ban thưởng long trọng, “giậm nhiều” nghĩa là đông nhiều, chẳng những nhà vua ban cho hậu hỹ, lại được thân mật kính lễ, trong buổi ban ngày, đến ba lần tiếp, ý nói yêu đương đãi đoạ đến tột bậc vậy. Quẻ Tấn là thì tiến thịnh, trên sáng dưới thuận, vua tôi hợp nhau, nói về người trên, thì là tiến về đường sáng thịnh, nói về bề tôi, thì là tiến lên mà ắt được sự vẻ vang yêu đương vậy."
            },
            new QueKinhDichModel()
            {
                queSo = 36,
                tuongQue = "",
                queName = "Địa Hỏa Minh Di (明夷 míng yí)",
                loaiQue = "Hung",
                totChoViec = "",
                loiKinh = "明夷利艱貞.",
                dichAm = "Minh di lợi gian trinh.",
                dichNghia = "Quẻ Minh di lợi về khó nhọc trinh chính.",
                giaiNghia = "Di nghĩa là đau. Là quẻ dưới Ly trên Khôn, mặt trời vào trong đất, tức là cái tượng sáng mà bị đau, cho nên gọi là Minh di. Minh di là quẻ tối tăm, ông vua tối tăm ở trên là lúc kẻ sáng bị đau. Mặt trời vào trong đất, tức là sự sáng bị thương mà tối tăm, cho nên gọi là Minh di."
            },
            new QueKinhDichModel()
            {
                queSo = 37,
                tuongQue = "",
                queName = "Phong Hỏa Gia Nhân (家人 jiā rén)",
                loaiQue = "Cát",
                totChoViec = "Công danh sự nghiệp: Quan lộc rộng mở\r\nTình duyên gia đạo: Hòa thuận, hạnh phúc",
                loiKinh = "家人利女貞",
                dichAm = "Gia nhân lợi nữ trinh.",
                dichNghia = "Quẻ Gia nhân lợi về gái chính.",
                giaiNghia = "Gia nhân là người một nhà. Trong quẻ, hào Chín Năm và hào Sáu Hai, bên trong, bên ngoài, đều được chỗ chính, cho nên là quẻ “người nhà”. Đạo người nhà lợi ở con gái chính, con gái chính thì đạo nhà chính. vợ ra vợ, chồng ra chồng thì đạo nhà mới chính, nay chỉ còn con gái chính, là vì chính là cái thân chính đính, con gái chính, thì nhà chính, con gái chính thì chắc con trai cũng chính."
            },
            new QueKinhDichModel()
            {
                queSo = 38,
                tuongQue = "",
                queName = "Hỏa Trạch Khuê (睽 kuí)",
                loaiQue = "Hung",
                totChoViec = "",
                loiKinh = "睽. 小 事 吉.",
                dichAm = "Khuê. Tiểu sự cát.",
                dichNghia = "Quẻ Khuê, việc nhỏ tốt.",
                giaiNghia = "Khuê là trái khác. Là quẻ trên lửa dưới chằm, tính trái khác nhau; con gái giữa, con gái út, chí không cùng về với nhau, cho nên là lìa. Nhưng lấy quẻ mà nói, thì trong đẹp lòng mà ngoài sáng sủa; lấy sự biển đối của quẻ mà nói, thì: ở quẻ Ly lại, là hào mềm tiến lên ở ngôi Ba; ở quẻ Trung Phu lại, là hào mềm tiến lên ở ngôi Năm, ở quẻ Gia Nhân lại, thì gồm cả hai kiểu đó; lấy thể quẻ mà nói thì hào Sáu Nam được chỗ giữa mà phía dưới ứng với hào Chín Hai là hào cứng, cho nên lời Chiêm của nó không thể làm việc lớn mà nhỏ còn có cách tốt."
            },
            new QueKinhDichModel()
            {
                queSo = 39,
                tuongQue = "",
                queName = "Thủy Sơn Kiển (蹇 jiǎn)",
                loaiQue = "Hung",
                totChoViec = "",
                loiKinh = "蹇利西南, 不利東北, 利見大人, 貞吉.",
                dichAm = "Kiển lợi Tây Nam, bất lợi Đông Bắc, lợi kiến đại nhân, trinh cát.",
                dichNghia = "Quẻ Kiển, lợi Tây Nam không lợi Đông Bắc, lợi về sự thấy người lớn, chính thì tốt.",
                giaiNghia = "Kiển nghĩa là nạn, cái nạn chân không đi được- Nó là quẻ cấn dưới Khảm trên, thấy chỗ hiểm mà đậu lại, cho nên là Kiển, Tây Nam là chỗ bình dị, Đông Bắc là chỗ hiểm trở, đương ở trong hồi Kiển, không nên chạy vào chỗ hiểm. Lại quẻ này tự quẻ Tiểu quá mà lại, khí Dương tiến lên thì ở ngôi Năm mà được giữa, lui xuống thì vào thể Cấn mà không tiến được, cho nên lời chiêm của nó là lợi Tây Nam, mà không lợi Đông Bắc. Đương thì Kiền phải thấy người lớn, rồi mới có thể qua nạn, lại phải giữ cho chính đính, thì mới được tốt."
            },
            new QueKinhDichModel()
            {
                queSo = 40,
                tuongQue = "",
                queName = "Lôi Thủy Giải (解 xiè)",
                loaiQue = "Cát Hanh",
                totChoViec = "– Công danh sự nghiệp: Khắc tà khí, hộ mệnh\r\n– Cái vận – giải hạn: Tai qua nạn khỏi",
                loiKinh = "解利西南, 无所往, 其來復, 吉, 有攸往, 夙吉.",
                dichAm = "Giải lợi Tây Nam, vô sở vãng, kỳ lai phục, cát; hữu du vãng, túc cát.",
                dichNghia = "Quẻ Giải lợi về phương Tây Nam, không thửa đi, thì lại lại; có thửa đi, sớm thì tốt.",
                giaiNghia = "Giải là nạn đã tan rồi. Nó là quẻ Chan trên Khảm dưới, Chấn là động, Khảm là hiểm, động ở ngoài chỗ hiểm, tức là ra khỏi chỗ hiểm, cho nên là tượng hoạn nạn giải tán. Lại, Chấn là sấm, Khảm là mưa, sấm mưa nổi lên, tức là Âm Dương cảm nhau, hoà khắp, giãn tan, cho nên là giải. Giải tức là lúc hoạn nạn của thiên hạ đã giải tán vậy."
            },
            new QueKinhDichModel()
            {
                queSo = 41,
                tuongQue = "",
                queName = "Sơn Trạch Tổn (損 sǔn)",
                loaiQue = "Bình Hòa (Vô cữu – Không lỗi)",
                totChoViec = "",
                loiKinh = "損有孚, 元吉, 无咎, 可貞, 利有攸往.",
                dichAm = "Tốn hữu phu, nguyên cát, vô cữu, khả trinh, lợi hữu du vãng.",
                dichNghia = "Quẻ Tốn, có tin, cả tốt, không lỗi, khá trinh, lợi",
                giaiNghia = "Tốn là giảm bớt, phàm việc nén bớt sự thái quá, để tới nghĩa lý, đều là đạo “bớt” vậy. Đạo “bớt” ắt có thành tín, nghĩa là chí thành thuận lý vậy. Bớt mà thuận lý thì cả thiện mà tốt. Cái đã bớt mà không quá sai, thì có thể chính bền, thường làm mà lợi có thửa đi vậy."
            },
            new QueKinhDichModel()
            {
                queSo = 42,
                tuongQue = "",
                queName = "Phong Lôi Ích (益 yì)",
                loaiQue = "Cát",
                totChoViec = "– Công danh sự nghiệp: Tài lộc rộng mở\r\n– Cải vận – Giải hạn: có Quý nhân phù trợ, tai qua nạn khỏi",
                loiKinh = "益利有攸往, 利涉大川",
                dichAm = "ích lợi hữu du vãng, lợi thiệp đại xuyên.",
                dichNghia = "Quẻ ích lợi có thửa đi, lợi về sang sông lớn.",
                giaiNghia = "Quẻ ích là đạo làm ích cho thiên hạ, cho nên lợi có thửa đi. Đạo ích, trong lúc bình thường vô sự, cái ích của nó còn nhỏ, đến khi gian nguy hiểm nạn, thì cái ích của nó càng lớn, cho nên lợi về sự sang sông lớn. Khi qua được chỗ hiểm nạn tức là lúc đạo ích cả được thi hành. Nó là quẻ Tôn trên Chấn dưới, đó là hai vật sấm gió làm ích cho nhau. Gió dữ thì sấm mạnh, sấm động thì gió gắt, hai đằng giúp ích cho nhau"
            },
            new QueKinhDichModel()
            {
                queSo = 43,
                tuongQue = "",
                queName = "Trạch Thiên Quải (夬 guài)",
                loaiQue = "Vô Du Lợi (không có lợi)",
                totChoViec = "",
                loiKinh = "夬, 揚于王庭, 孚號有厲, 吿自邑, 不利即戎, 利有攸往.",
                dichAm = "Quyết, dương vu vương đình, phu hiệu hữu lệ. Cáo tự ấp, bất lợi tức nhung, lợi hữu du vãng.",
                dichNghia = "Quẻ Quải, giơ chưng sân vua, tin gọi, có nguy. Bảo từ làng, chẳng lợi tới quân, lợi có thửa đi.",
                giaiNghia = "Quải nghĩa là quyết, tức là khí Dương khơi tháo khí Âm, nó là quẻ về tháng ba. Lấy năm hào Dương trừ một hào Âm, chẳng qua khơi tháo nó đi mà thôi. Nhưng khi khơi tháo nó đi, ắt phải nêu rõ tội nó, mà hết lòng thành thực để hò gọi quân mình hợp sức với mình, và cũng còn phải lo sợ, không thể yên ổn phóng tứ, lại nên trị trước chỗ riêng tây mà không thể chuyên chuộng oai vũ, thì lợi có thửa đi."
            },
            new QueKinhDichModel()
            {
                queSo = 44,
                tuongQue = "",
                queName = "Thiên Phong Cấu (姤 gòu)",
                loaiQue = "Bình Hòa (vô Cữu – Không lỗi)",
                totChoViec = "",
                loiKinh = "垢, 女壯, 勿用取女.",
                dichAm = "Cấu, nữ tráng, vật dụng thú nữ.",
                dichNghia = "Quẻ Cấu, con gái mạnh, chớ dùng lấy con gái.",
                giaiNghia = "Cấu nghĩa là gặp, quyết hết thì là quẻ thuận Càn, tức là quẻ về tháng tư, đến quẻ cấu, rồi một khí Âm có thể hiện được, mới quẻ tháng tám. Trong kinh Dịch cổ, chữ 垢(cấu) viết làm chữ 遘(cấu), nghĩa là gặp, cũng là dâu gia, lấy sự con gái gặp con trai làm tượng.\r\n\r\nCấu nghĩa là gặp, quyết hết thì là quẻ thuận Càn, tức là quẻ về tháng tư, đến quẻ cấu, rồi một khí Âm có thể hiện được, mới quẻ tháng tám. Vì nó vốn không phải cái là mong đợi, thình lình gặp nó, như kẻ chẳng hẹn mà gặp, cho nên là gặp, sự gặp, như thế đã bất chính rồi."
            },
            new QueKinhDichModel()
            {
                queSo = 45,
                tuongQue = "",
                queName = "Trạch Địa Tụy (萃 cuì)",
                loaiQue = " Hanh",
                totChoViec = "Mọi việc đều thuận lợi",
                loiKinh = "萃亨, 王假有廟.",
                dichAm = "Tuy hanh, vương cách hữu miếu.",
                dichNghia = "Quẻ Tuy hanh, vua đền có miếu.",
                giaiNghia = "Tụy là họp, Nó là quẻ Đoái trên Khôn dưới, chầm lên trên đất, tức là nước tụ, cho nên là họp. Ông vua có đạo tụ họp thiên hạ đến chưng có miếu là tột bậc rồi. Các loài là thứ rất nhiều, mà có thể thống nhất sự quy ngưỡng của chúng, lòng người là thứ không biết đâu là nơi chốn, mà có thể làm cho họ phải thành kính; quỷ thần là đấng không thể lường biết, mà có làm cho các ngài lại đến; cái đạo tụ họp lòng người, tóm thu chí dân, không phải chỉ có một đường, nhưng trong đó, không gì lớn bằng tôn miếu, cho nên đạo họp thiên hạ của kẻ làm vua, đến chưng có miếu thì là tột bậc của sự họp.\r\nQuẻ Tụy có chữ 亨(hanh), tức là lời khen ngợi"
            },
            new QueKinhDichModel()
            {
                queSo = 46,
                tuongQue = "",
                queName = "Địa Phong Thăng (升 shēng)",
                loaiQue = "Cát Hanh",
                totChoViec = "Công danh sự nghiệp: Quan lộc thăng tiến, tài lộc đi lên",
                loiKinh = "升元亨, 用見大人, 勿恤, 南正吉.",
                dichAm = "Thăng nguyên hanh, dụng kiến đại nhân, vật tuất, nam chinh cát.",
                dichNghia = "Quẻ Thăng, cả hanh, dùng thấy người lớn, chớ lo, đi về phương Nam tốt.",
                giaiNghia = "Thăng là tiến mà lên, tiến lên thì có nghĩa hanh, mà vì tài quẻ hay khéo, cho nên cả hanh. Dùng cách đó để thấy người lớn, không cần lo lắng, tiến lên phía trước thì tốt. Đi về phương Nam tức là tiến lên phía trước vậy. Phàm đạo “lên” ắt bởi các bậc người lớn, lên về ngôi thì bởi tước vương, tước công, lên về đạo thì bởi ông thánh ông hiền."
            },
            new QueKinhDichModel()
            {
                queSo = 47,
                tuongQue = "",
                queName = "Trạch Thủy Khốn (困 kùn)",
                loaiQue = "Bình hòa",
                totChoViec = "",
                loiKinh = "困, 亨貞, 大人吉, 无咎, 有言不信.",
                dichAm = "Khốn, hanh trinh, đại nhân cát, vô cữu, hữu ngôn bất",
                dichNghia = "Quẻ Khốn hanh, chính bền, người lớn tốt , không lỗi",
                giaiNghia = "Khốn là nghĩa khốn thiếu. Nó là quẻ Đoài trên Khảm dưới, nước ở trên chằm, thì là trong chằm khô cạn không nước, nhưng nước lại ở dưới chằm, thì tức là Tượng dưới chằm khô cạn không nước, đó là nghĩa khốn thiếu. Lạo Đoái là Âm ở trên. Khảm là Dương ở dưới và hào Sáu Trên ở trên hai hào Dương, mà hào Chín Hai bị hãm trong hai hào Âm, mềm lấp lên Dương cứng, vì vậy mới là khốn. Đấng quân tử bị kẻ tiểu nhân che lấp, là thời cùng khốn.\r\n\r\nKhốn là khốn đốn. Khốn đốn trước mắt phàm phu, thời là cùng cực lao lung, nhưng trước mắt Thánh hiền, thì khốn vẫn mang lại sự hanh thông. Thật vậy, thân tuy khốn, nhưng phẩm giá vẫn vẹn toàn. Đạo vẫn cao, đức vẫn trọng, vẫn để được tiếng thơm muôn thuở. Khốn mà vẫn Hanh, vì sự khốn khổ là một phương tiện để đào luyện tâm thần một cách hữu hiệu."
            },
            new QueKinhDichModel()
            {
                queSo = 48,
                tuongQue = "",
                queName = "Thủy Phong Tỉnh (井 jǐng)",
                loaiQue = "Bình hòa",
                totChoViec = "",
                loiKinh = "井, 改邑不改井, 无得5B喪, 往來井井.",
                dichAm = "Tỉnh, cải ấp bất cải tỉnh, vô đắc vô táng, vãng lai tỉnh tỉnh.",
                dichNghia = "Quẻ Tỉnh, đổi làng chẳng đổi giếng, không mất không được, đi lại giếng giếng.",
                giaiNghia = "Khảm là nước, mà tượng của Tôn là cây, nghĩa của Tốn thì là vào. Cái tượng đồ gỗ vào dưới nước mà lên khỏi nước, ấy là tượng múc nước giếng. Đức của giếng là trời đất vậy, mà nó lấy sự chẳng đổi làm đức riêng. Thể dưới vốn là Kiền, thể trên vốn là Khôn, hào Đầu hào Năm cứng mềm đôi nhau mà thành quẻ Tỉnh. Khôn là làng, đổi Khôn ra Khảm là đổi làng. Nước Khảm là giếng, hào Năm lấy chất cứng ở ngôi giữa mà không thay đổi, thế là không đổi giếng. Làng ở nơi chốn của nó mà họp được, có thể dời đi tới giếng; giếng ở nơi chốn của nó mà có thường, không thể dời đi tới làng. Múc nó không hết cho nên không mất;"
            },
            new QueKinhDichModel()
            {
                queSo = 49,
                tuongQue = "",
                queName = "Trạch Hỏa Cách (革 gé)",
                loaiQue = "Cát",
                totChoViec = "Công danh sự nghiệp: Có biến chuyển, hanh thông\r\nGiải hạn – cải vận: Vận may tới",
                loiKinh = "革, 已日乃孚, 元亨利貞, 悔亡",
                dichAm = "Cách, dĩ nhật nãi phu, nguyên hanh lợi trinh, hối vong.",
                dichNghia = "Quẻ Cách, hết ngày bèn tin, cả hanh lợi trinh",
                giaiNghia = "Cách là đổi cái cũ, đổi cái cũ thì người ta chưa chịu tin ngay, cho nên phải đợi hết ngày, lòng người mới tin theo. “Cả hanh lợi trinh, ăn năn mất” là sao? Có hỏng nát mới phải thay đổi, mà thay đổi là để làm cho hanh thông, cho nên, đổi đi mà có thể cả hanh, đổi đi mà lợi về chính đạo, thì có lâu dài mà được cái nghĩa “bỏ cũ”."
            },
            new QueKinhDichModel()
            {
                queSo = 50,
                tuongQue = "",
                queName = "Hỏa Phong Đỉnh (鼎 dǐng)",
                loaiQue = "Cát Hanh",
                totChoViec = "– Công danh sự nghiệp: Tài lộc sáng lạn\r\n– Giải hạn – cải vận: Có quý nhân phù trợ",
                loiKinh = "鼎元吉亨.",
                dichAm = "Đỉnh nguyên cát hanh.",
                dichNghia = "Quẻ Đỉnh, cả tốt hanh.",
                giaiNghia = "Quẻ Đỉnh, Tự quái nói rằng: Thay đổi các vật, không gì bằng cái vạc, cho nên tiếp đến quẻ Đỉnh. Sự dùng của cái vạc, là để thay đổi các vật, biến thứ sống ra thứ chín, đổi cái rắn thành cái mềm. Đây lấy tài quẻ mà nói. Như tài quẻ này, có thể đem đến được sự cả hanh vậy. Chỉ nên nói “nguyên hanh”, chữ “cát” là thừa. Vì tài quẻ này có thể đem đến được sự cả hanh. Lời Thoán nói “nguyên hanh” nghĩa đó rõ lắm."
            },
            new QueKinhDichModel()
            {
                queSo = 51,
                tuongQue = "",
                queName = "Thuần Chấn (震 zhèn)",
                loaiQue = "Bình hòa",
                totChoViec = "",
                loiKinh = "震亨, 震來虢虢, 笑言啞啞, 震驚百里, 不喪匕鬯.",
                dichAm = "Chấn hanh, Chấn lai khích khích, tiếu ngôn ách ách, chấn kinh bách lý, bất táng chuỷ Xưởng.",
                dichNghia = "Quẻ Chấn hanh, sợ lại ngơm ngớp, cười nói khanh khách, nhức kinh trăm dặm, chẳng mất môi và rượu Xưởng.",
                giaiNghia = "Chấn nghĩa là động, một khí Dương mới sinh dưới hai khí Âm, nhức mà tự động; tượng nó là sấm, loại nó là con lớn, nhức thì là cách hanh thông. “Sợ lại” nghĩa là lúc sự nhức sợ kéo lại. “Ngơm ngớp” là dáng khiếp sợ ngó đi ngó lại. “Nhức sợ trăm dặm” là nói về sấm. “Môi” là cái để múc đồ nấu trong vạc. “Xưởng” là thứ rượu dùng rượu gạo nếp hoà lộn với nghệ, để đổ lộn xuống đất mà cầu thần xuống. “Chẳng mất môi và rượu Xưởng” là lấy con lớn mà nói. Lời chiêm quẻ này là biết lo sợ thì đem được phúc đến mà chẳng bị mất cái sở chủ hệ trọng của mình."
            },
            new QueKinhDichModel()
            {
                queSo = 52,
                tuongQue = "",
                queName = "Thuần Cấn (艮 gèn)",
                loaiQue = "Bình hòa",
                totChoViec = "",
                loiKinh = "艮其背, 不獲其身, 行其庭, 不見其人, 无咎.",
                dichAm = "Cấn kỳ bôi, bất hoạch kỳ thân, hành kỳ đình, bất kiến kỳ nhân, vô cữu.",
                dichNghia = "Đậu thửa lưng, chẳng được thửa mình, đi thửa sân, chẳng thấy thửa người, không lỗi.",
                giaiNghia = "Cấn là đậu, không nói đậu mà nói cấn, là vì quẻ Cấn là tượng núi, có ý yên nặng rắn đặc, nghĩa chữ “đậu” không thể hết được. Kiền Khôn giao nhau, ba lần tìm mà thành quẻ Cấn, một khí Dương ở trên hai khí Âm, Dương là vật động mà tiến lên, đã đến bậc trên thì phải đậu lại. Âm là im lặng, trên đậu mà dưới im lặng, cho nên là Cấn. Thế thì với nghĩa “chứa đậu” khác nhau thế nào? Đáp rằng: Chứa đậu là nghĩa ngăn chế mà chứa lại, lấy sức mà làm cho đậu; cấn đậu là nghĩa yên ổn mà đậu."
            },
            new QueKinhDichModel()
            {
                queSo = 53,
                tuongQue = "",
                queName = "Phong Sơn Tiệm (漸 jiàn)",
                loaiQue = "Cát",
                totChoViec = "Công danh sự nghiệp: Quan lộc thăng tiến",
                loiKinh = "漸, 女歸, 吉, 利貞.",
                dichAm = "Tiệm, nữ quy, cát, lợi trinh.",
                dichNghia = "Quẻ Tiệm, con gái về, tốt, lợi về chính bền.",
                giaiNghia = "Tiệm là tiến lên dần dần. Nó là quẻ đậu ở dưới mà nhún ở trên, tức là nghĩa không tiến gấp vội, có tượng con gái về nhà chồng. Lại, từ hào Hai đến hào Năm, ngôi đều được chính, cho nên lời chiêm của nó lợi về chính bền."
            },
            new QueKinhDichModel()
            {
                queSo = 54,
                tuongQue = "",
                queName = "Lôi Trạch Quy Muội (歸妹 guī mèi)",
                loaiQue = "Hung",
                totChoViec = "",
                loiKinh = "歸妹征凶, 无攸利",
                dichAm = "Qui muội chinh hung, vô du lợi.",
                dichNghia = "Quẻ Qui Muội đi hung không thửa lợi.",
                giaiNghia = "Qui Muội tức là con gái về nhà chồng, chữ “muội” là tiếng để gọi những người thiếu nữ. Đoái lấy tư cách gái trẻ theo Chấn là trai lớn, mà tình của nó lại là lấy sự đẹp lòng mà động, không phải chính đạo. Cho nên quẻ là “em gái lấy chồng” mà các hào trong quẻ, từ hào Hai đến hào Năm đều không được chính, hào Ba hào Năm lại lấy chất mềm cưỡi chất cứng, cho nên lời chiêm của nó là đi thì hung mà không lợi về sự gì."
            },
            new QueKinhDichModel()
            {
                queSo = 55,
                tuongQue = "",
                queName = "Lôi Hỏa Phong (豐 fēng)",
                loaiQue = "Cát Hanh",
                totChoViec = "– Công danh sự nghiệp: Tài lộc sáng sủa, hanh thông\r\n– Tình duyên – Gia đạo: Gia đình hòa thuận, vui vẻ",
                loiKinh = "豐亨, 王假之, 勿憂宜日中.",
                dichAm = "Phong hanh, vương giá chi, vật ưu nghi nhật trung.",
                dichNghia = "Quẻ Phong hanh thông, vua đến đấy, chớ lo, nên mặt trời giữa.",
                giaiNghia = "Phong là thịnh lớn, nghĩa nó vẫn hanh thông. Làm cho tột bậc sáng lớn ở gầm trời, chỉ đấng vương giả có thể được thế. Đến là tột bậc vậy. Cao đến như ngôi trời, giàu đến như bốn bể, nhiều đến như các loài, lớn đến như đạo vương, làm cho cùng tột đạo thịnh, chỉ có đấng vương giả."
            },
            new QueKinhDichModel()
            {
                queSo = 56,
                tuongQue = "",
                queName = "Hỏa Sơn Lữ (旅 lǚ)",
                loaiQue = "Bình Hòa ",
                totChoViec = "",
                loiKinh = "旅小亨, 旅貞吉.",
                dichAm = "Lữ tiểu hanh, lữ trinh cát.",
                dichNghia = "Quẻ Lữ nhỏ hanh thông sự đi đường chính bền tốt.",
                giaiNghia = "Lữ là ky lữ, núi đậu ở dưới, lửa bốc ở trên, là tượng “bỏ chỗ ngưng đậu không ở” cho nên là lữ. Lấy hào Sáu Năm được chỗ giữa ở ngoài, mà thuận với hào Dương ở trên và dưới Cấn đậu mà Ly thì bám vào chỗ sáng, cho nên lời chiêm của nó là thể nho nhỏ hanh thông. Hành lữ không phải chỗ ở thường, hình như có thể cẩu thả, song “đạo” không chỗ nào không ở, cho nên việc hành lữ cũng có chỗ chính của nó."
            },
            new QueKinhDichModel()
            {
                queSo = 57,
                tuongQue = "",
                queName = "Thuần Tốn (巽 xùn)",
                loaiQue = "Bình hòa",
                totChoViec = "",
                loiKinh = "巽小亨, 利有攸往, 利見大人.",
                dichAm = "Tốn tiểu hanh, lợi hữu du vãng, lợi kiến đại nhân.",
                dichNghia = "Quẻ Tốn nhỏ hanh thông, lợi có thửa đi, lợi thấy người lớn.",
                giaiNghia = "Tốn là nghĩa là “vào”, một hào Âm nấp dưới hai hào Dương, tính nó biết nhún để vào; tượng nó là gió, cũng là lấy về nghĩa “vào”. Quẻ này hào Âm làm chủ, cho nên lời chiêm của nó là sự hanh nhỏ; lấy Âm theo Dương, cho nên lại “lợi có thửa đi”. Nhưng ắt biết chỗ đáng theo mới được chính đính, vì vậy lại nói “lợi thấy người lớn”."
            },
            new QueKinhDichModel()
            {
                queSo = 58,
                tuongQue = "",
                queName = "Thuần Đoài (兌 duì)",
                loaiQue = "Cát hanh",
                totChoViec = "– Công danh sự nghiệp: Tài lộc, quan lộc rộng mở",
                loiKinh = "予利貞.",
                dichAm = "Đoài hanh lợi trinh.",
                dichNghia = "Quẻ Đoài hanh, lợi về chính bền.",
                giaiNghia = "Đoài là đẹp lòng. Một Âm tiến lên trên hai Dương, tức là sự mừng hiện ra bên ngoài. Tượng nó là chầm lấy nghĩa đẹp lòng muôn vật, lại lấy về tượng nước Khảm mà lấp dòng dưới. Thể quẻ cứng trong mà mềm ngoài, cứng trong cho nên đẹp lòng mà hanh, mềm ngoài cho nên lợi về chính bền. Bởi vì sự đẹp lòng vẫn có cách hanh thông"
            },
            new QueKinhDichModel()
            {
                queSo = 59,
                tuongQue = "",
                queName = "Phong Thủy Hoán (渙 huàn)",
                loaiQue = "Hanh",
                totChoViec = "",
                loiKinh = "渙亨, 王假有廟, 利涉大川, 利貞.",
                dichAm = "Hoán hanh, vương giá hữu miếu, lợi thiệp đại xuyên, lợi trinh.",
                dichNghia = "Quẻ Hoán hanh, vua đến có miếu, lợi sang sông lớn, lợi về chính bền.",
                giaiNghia = "Hoán là tan, là thời kỳ ly tan, chia rẽ, tưởng chừng như mọi sự sẽ đi đến chỗ bế tắc. Những bậc quân vương, có thể giải tỏa được bế tắc ấy, có thể đem lại sự đoàn kết cho dân, làm cho tình thế lại trở nên thông suốt (Hoán. Hanh). Nó là quẻ dưới Khảm trên Tốn, gió đi trên nước, là tượng tơi tả giải tán, cho nên là tan. Sự biến hoá của nó thì vốn tự quẻ Tiệm, hào Chín đến ở ngôi Hai mà được giữa, hào Sáu đi ở ngôi Ba được ngôi của hào Chín, mà phía trên cùng nhau với hào Tư, cho nên lời chiêm của nó là có thể hanh."
            },
            new QueKinhDichModel()
            {
                queSo = 60,
                tuongQue = "",
                queName = "Thủy Trạch Tiết (節 jié)",
                loaiQue = "Cát",
                totChoViec = "Công danh sự nghiệp: Ổn định, bền vững",
                loiKinh = "節亨, 苦節不可貞",
                dichAm = "Tiết hanh, khổ tiết bất khả trinh.",
                dichNghia = "Quẻ Tiết hanh, sự dè dặt khổ không thể chính bền.",
                giaiNghia = "Tiết là có hạn mà ngừng lại. Việc mà đã có tiết độ, thì có thể đem đến được sự hanh thông, cho nên quẻ Tiết có nghĩa hanh."
            },
            new QueKinhDichModel()
            {
                queSo = 61,
                tuongQue = "",
                queName = "Phong Trạch Trung Phu (中孚 zhōng fú)",
                loaiQue = "Cát hanh",
                totChoViec = "– Công danh sự nghiệp: Đặt chữ tín hàng đầu, tài lộc rộng mở\r\n– Cải vận – giải hạn: Tai qua nạn khỏi, may mắn đến.",
                loiKinh = "中孚, 豚魚吉, 利涉大川, 利貞.",
                dichAm = "Trung phu, đồn ngư cát, lợi thiệp đại xuyên, lợi trinh.",
                dichNghia = "Quẻ Trung phu, cá lợn tốt, lợi sang sông lớn, lợi về chính bền.",
                giaiNghia = "Phu là tin. Nó là quẻ hai hào Âm ở trong, bốn hào Dương ở ngoài, mà hai hào Dương Hai và Năm đều được chỗ giữa. Nói về cả quẻ là giữa rỗng, nói về hai thể thì là giữa đặc, đều là tượng phu tín. Lợn nóng nảy, cá lờ mờ, là giống khó cảm trong loài vật. Sự tin có thể cảm đến cá lợn, thì không đâu không tới, vì vậy mới tốt. Lòng trung tin có thể xéo lên nước sôi, lửa bỏng huống chi sang sông, cái đạo giữ đức tin, cốt ở kiên chính, cho nên lợi về chính bền."
            },
            new QueKinhDichModel()
            {
                queSo = 62,
                tuongQue = "",
                queName = "Lôi Sơn Tiểu Quá (小過 xiǎo guò)",
                loaiQue = "Bình hòa",
                totChoViec = "",
                loiKinh = "小過亨, 利貞.",
                dichAm = "Tiểu quá hanh, lợi trinh.",
                dichNghia = "Quẻ Tiểu Quá hanh, lợi về chính bền.",
                giaiNghia = "Quá là vượt qua mực thường. Nếu uốn cong mà quá thẳng, sự quá đó cốt để tới sự chính vậy, việc cũng có khi nên thế, phải đợi quá đi mới hanh được, cho nên quẻ Tiểu Quá tự nó đã có nghĩa hanh. Lợi trinh nghĩa là đạo quá lợi về chính bền. Chẳng lỗi với lẽ nên phải của đương thì, thì gọi là chính."
            },
            new QueKinhDichModel()
            {
                queSo = 63,
                tuongQue = "",
                queName = "Thủy Hỏa Ký Tế (既濟 jì jì)",
                loaiQue = "Cát Hanh",
                totChoViec = "Công danh sự nghiệp: Tài lộc rộng mở, may mắn",
                loiKinh = "旣濟亨, 小利貞, 初吉, 終亂.",
                dichAm = "Ký tế hanh, tiểu lợi trinh, sơ cát, chung loạn.",
                dichNghia = "Quẻ Ký Tế hanh, nhỏ lợi về chính bền, đầu tốt",
                giaiNghia = "Trong thì đã sang, cái lớn đã hanh thông rồi. Tuy là trong thì đã sang, không thể không có cái nhỏ chưa hanh thông. Chữ “nhỏ” ở dưới lời nói nên thế. Nếu nói “nhỏ hanh” thì là sự hanh thông nhỏ. “Lợi về chính bền” là vì ở thì đã sang, lợi ở gìn giữ bằng cách chính bền."
            },
            new QueKinhDichModel()
            {
                queSo = 64,
                tuongQue = "",
                queName = "Hỏa Thủy Vị Tế (未濟 wèi jì)",
                loaiQue = "Vô du lợi",
                totChoViec = "",
                loiKinh = "未濟亨, 小狐汔濟, 濡其尾, 无攸利",
                dichAm = "Vị Tế hanh, tiểu hồ ngật tế, nhu kỳ vĩ, vô du lợi.",
                dichNghia = "Quẻ Vị Tế hanh, con cáo nhỏ hầu sang, ướt thửa đuôi, không thửa lợi.",
                giaiNghia = "Quẻ Vị Tế là lúc việc chưa thành. Nước lửa chẳng giao nhau, chẳng làm sự dùng cho nhau. Sáu hào trong quẻ đều mất ngôi, cho nên là chưa sang. Chữ 乾 nên đổi làm chữ 4乞 Kinh Thư nói ngật ngật dũng phu – hăng hái kẻ mạnh, con cáo nhỏ quả quyết về sự sang, thì ướt thửa đuôi mà không sang được."
            },
        };
        //private static readonly
        public static FengShuiSimModel TinhDiemPhongThuy(string simNumber)
        {
            simNumber = simNumber.Replace(".", "");
            FengShuiSimModel fengShuiSim = new FengShuiSimModel();
            float point = 0;
            var nguHanhSim = GetNguHanhSim(simNumber, "Kim").nguHanhSim;
            //Tìm mệnh tương sinh
            var nguHanhTuongSinh = "";
            switch (nguHanhSim)
            {
                case "Kim":
                    nguHanhTuongSinh = "Thủy";
                    break;
                case "Thổ":
                    nguHanhTuongSinh = "Kim";
                    break;
                case "Hỏa":
                    nguHanhTuongSinh = "Thổ";
                    break;
                case "Mộc":
                    nguHanhTuongSinh = "Hỏa";
                    break;
                case "Thủy":
                    nguHanhTuongSinh = "Mộc";
                    break;
            }
            fengShuiSim.nguHanhSim = nguHanhSim;
            fengShuiSim.nguHanhTuongSinh = nguHanhTuongSinh;
            //Thêm điểm phong thủy tương sinh
            var nguHanh = GetNguHanhSim(simNumber, nguHanhTuongSinh);
            point += nguHanh.point;
            //Thêm điểm cửu tinh đồ
            if (simNumber.Contains("9")) point += 2;
            else point += 1;

            var simNumberArr = simNumber.ToCharArray();
            int soAmAmount = 0;
            int soDuongAmount = 0;
            for (int i = 0; i < simNumberArr.Length; i++)
            {
                if (simNumberArr[i] % 2 == 0)
                {
                    soAmAmount++;
                }
                else
                {
                    soDuongAmount++;
                }
            }
            var amDuongTuongSinh = "Cân bằng";
            if (soAmAmount < soDuongAmount)
                amDuongTuongSinh = "Âm";
            else if (soAmAmount > soDuongAmount)
                amDuongTuongSinh = "Dương";
            fengShuiSim.amDuongTuongSinh = amDuongTuongSinh;
            //Thêm điểm vận số âm dương
            var amDuong = GetAmDuongTuongPhoi(simNumber, amDuongTuongSinh, true);
            point += amDuong.point;
            //Tính điểm nút
            int tongNut = 0;
            for (int i = 0; i < simNumberArr.Length; i++)
            {
                tongNut += int.Parse(simNumberArr[i].ToString());
            }
            string soNut = tongNut.ToString();
            if (tongNut.ToString().Length == 2)
                soNut = tongNut.ToString().Substring(1, 1);
            if (("8,9,0").Contains(soNut)) point += 1;
            if (("4,5,6,7").Contains(soNut)) point += 0.5f;
            //Thêm điểm sim theo quan niệm dan gian
            var listSoDep = new List<string>() { "79", "39", "68", "86", "99", "88", "89", "66", "78", "38" };
            var soDepInSim = listSoDep.Where(x => simNumber.Contains(x)).ToList();
            if (soDepInSim.Count() > 0)
                point += 1;
            //
            var batQuai = GetQueBatQuaiInfo(simNumber);
            //Thêm điểm bát quái
            point += batQuai.point;
            fengShuiSim.point = point;

            return fengShuiSim;
        }
        public static MenhChuInfoModel GetUserFengShuiInfo(int namSinh)
        {
            MenhChuInfoModel menhChu = dataNamSinhPT.Where(x => x.NamSinh == namSinh).FirstOrDefault();
            var nguHanh = menhChu.CungSinh1.Split(' ')[2].ToString();
            menhChu.NguHanh = nguHanh;
            return menhChu;
        }
        public static string GetMenhAmDuong(string canChi, bool isMale)
        {
            var gender = "Nam";
            if (!isMale) gender = "Nữ";
            var canChiArr = canChi.Split(' ');
            var can = canChiArr[0];
            var chi = canChiArr[1];
            var canChiPhoi = "Dương";
            if (("Ất,Đinh,Kỷ,Tân,Quý").Contains(can) && ("Sửu,Mẹo,Tỵ,Mùi,Dậu,Hợi").Contains(chi)) canChiPhoi = "Âm";

            return canChiPhoi + " " + gender;
        }
        public static DateTime GetDateOfChinese(int y, int m, int d)
        {
            ChineseLunisolarCalendar chinese = new ChineseLunisolarCalendar();

            DateTime date = new DateTime(y, m, d);

            //Chuyển đổi sang lịch âm
            Int32 year = chinese.GetYear(date);
            Int32 month = chinese.GetMonth(date);
            Int32 day = chinese.GetDayOfMonth(date);

            return new DateTime(year, month, day);
        }
        public static AmDuongTuongPhoiModel GetAmDuongTuongPhoi(string simNumber, string canChi, bool isMale)
        {
            AmDuongTuongPhoiModel result = new();
            var amDuongTuongPhoi = new List<string>();
            var simNumberArr = simNumber.ToCharArray();
            int soAmAmount = 0;
            int soDuongAmount = 0;
            for (int i = 0; i < simNumberArr.Length; i++)
            {
                if (simNumberArr[i] % 2 == 0)
                {
                    amDuongTuongPhoi.Add("-");
                    soAmAmount++;
                }
                else
                {
                    amDuongTuongPhoi.Add("+");
                    soDuongAmount++;
                }
            }
            result.amDuongTuongPhoi = amDuongTuongPhoi;
            result.soAmAmount = soAmAmount;
            result.soDuongAmount = soDuongAmount;

            //Kiểm tra xem số sim là Âm hay Dương
            var vanSo = "Cân bằng";
            if (soAmAmount > soDuongAmount)
                vanSo = "Âm";
            else if (soAmAmount < soDuongAmount)
                vanSo = "Dương";

            result.vanSo = vanSo;

            //Tính điểm sim
            //Điểm âm dương
            float point = 0;
            if (soAmAmount == 4 || soAmAmount == 5 || soAmAmount == 6)
            {
                point += 1;
            }
            else if (soAmAmount == 2 || soAmAmount == 3 || soAmAmount == 7 || soAmAmount == 8)
            {
                point += 0.5f;
            }
            //Điểm hợp mệnh
            var menh = canChi;
            if (canChi.Contains(" "))
                menh = GetMenhAmDuong(canChi, isMale);
            if (vanSo == "Cân bằng")
            {
                point += 1;
            }
            else
            {
                if ((menh.Contains("Âm") && vanSo.Contains("Dương")) || (menh.Contains("Dương") && vanSo.Contains("Âm")))
                {
                    point += 1;
                }
            }
            result.point = point;
            result.menhAmDuong = menh;

            return result;
        }
        public static NguHanhSimModel GetNguHanhSim(string simNumber, string nguHanhMenhChu)
        {
            NguHanhSimModel nguHanhSim = new NguHanhSimModel();
            var simNumberArr = simNumber.ToCharArray();
            var numberOfSim = new List<string>();
            var nguHanhOfnumber = new List<string>();
            var nguHanhSinhKhac = new List<string>();
            float point = 0;
            for (int i = 0; i < simNumberArr.Length; i++)
            {
                switch (simNumberArr[i])
                {
                    case '0':
                        numberOfSim.Add("0");
                        nguHanhOfnumber.Add("Thủy");
                        break;
                    case '1':
                        numberOfSim.Add("1");
                        nguHanhOfnumber.Add("Thủy");
                        break;
                    case '2':
                        numberOfSim.Add("2");
                        nguHanhOfnumber.Add("Thổ");
                        break;
                    case '3':
                        numberOfSim.Add("3");
                        nguHanhOfnumber.Add("Mộc");
                        break;
                    case '4':
                        numberOfSim.Add("4");
                        nguHanhOfnumber.Add("Mộc");
                        break;
                    case '5':
                        numberOfSim.Add("5");
                        nguHanhOfnumber.Add("Thổ");
                        break;
                    case '6':
                        numberOfSim.Add("6");
                        nguHanhOfnumber.Add("Kim");
                        break;
                    case '7':
                        numberOfSim.Add("7");
                        nguHanhOfnumber.Add("Kim");
                        break;
                    case '8':
                        numberOfSim.Add("8");
                        nguHanhOfnumber.Add("Thổ");
                        break;
                    case '9':
                        numberOfSim.Add("9");
                        nguHanhOfnumber.Add("Hỏa");
                        break;
                }
            }
            nguHanhSim.numberOfSim = numberOfSim;
            nguHanhSim.nguHanhOfnumber = nguHanhOfnumber;
            var most = nguHanhOfnumber.GroupBy(i => i).OrderByDescending(grp => grp.Count()).Select(grp => grp.Key).First();
            nguHanhSim.nguHanhSim = most;
            // Tinh điểm sim
            // Sim sinh khắc với người dùng
            var nguHanhSimSinhKhac = CheckNguHanhXungKhac(most, nguHanhMenhChu);
            nguHanhSim.simSinhKhac = nguHanhSimSinhKhac;
            if (nguHanhSimSinhKhac == "Tương sinh")
            {
                point += 1;
            }
            else if (nguHanhSimSinhKhac == "Bình Hòa")
            {
                point += 0.5f;
            }
            //Sinh khắc trong sim
            for (int i = 0; i < simNumberArr.Length / 2; i++)
            {
                nguHanhSinhKhac.Add(CheckNguHanhXungKhac(simNumberArr[i * 2].ToString(), simNumberArr[(i * 2) + 1].ToString()));
            }
            nguHanhSim.nguHanhSinhKhac = nguHanhSinhKhac;
            var tuongSinh = nguHanhSinhKhac.Where(x => x == "Tương sinh").ToList().Count;
            if (tuongSinh == 5)
                point += 1;
            else if (tuongSinh >= 3)
                point += 0.5f;
            nguHanhSim.point = point;

            return nguHanhSim;
        }
        public static string CheckNguHanhXungKhac(string nguHanh1, string nguHanh2)
        {
            string result = "Bình Hòa";
            if ((nguHanh1 == "Kim" && nguHanh2 == "Thủy")
            || (nguHanh1 == "Thủy" && nguHanh2 == "Mộc")
            || (nguHanh1 == "Mộc" && nguHanh2 == "Hỏa")
            || (nguHanh1 == "Hỏa" && nguHanh2 == "Thổ")
            || (nguHanh1 == "Thổ" && nguHanh2 == "Kim"))
                result = "Tương sinh";

            if ((nguHanh1 == "Kim" && nguHanh2 == "Mộc")
            || (nguHanh1 == "Mộc" && nguHanh2 == "Thổ")
            || (nguHanh1 == "Thổ" && nguHanh2 == "Thủy")
            || (nguHanh1 == "Thủy" && nguHanh2 == "Hỏa")
            || (nguHanh1 == "Hỏa" && nguHanh2 == "Kim"))
                result = "Tương khắc";

            return result;
        }

        public static QueBatQuaiModel GetQueBatQuaiInfo(string simNumber)
        {
            QueBatQuaiModel batQuai = new();
            var simNumberArr = simNumber.ToCharArray();
            int tongThuong = 0;
            int tongHa = 0;
            for (int i = 0; i < simNumberArr.Length; i++)
            {
                if (i < 5)
                    tongThuong += int.Parse(simNumberArr[i].ToString());
                else
                    tongHa += int.Parse(simNumberArr[i].ToString());
            }
            int thuongQuai = tongThuong % 8;
            if (thuongQuai == 0) thuongQuai = 8;
            int haQuai = tongHa % 8;
            if (haQuai == 0) haQuai = 8;
            QueKinhDichModel queChu = new QueKinhDichModel();
            QueKinhDichModel queHo = new QueKinhDichModel();
            float point = 0;
            switch (thuongQuai, haQuai)
            {
                case (1, 1):
                    queChu = queKinhDich.FirstOrDefault(x => x.queSo == 1);
                    queHo = queKinhDich.FirstOrDefault(x => x.queSo == 1);
                    break;
                case (1, 2):
                    queChu = queKinhDich.FirstOrDefault(x => x.queSo == 10);
                    queHo = queKinhDich.FirstOrDefault(x => x.queSo == 37);
                    break;
                case (1, 3):
                    queChu = queKinhDich.FirstOrDefault(x => x.queSo == 13);
                    queHo = queKinhDich.FirstOrDefault(x => x.queSo == 1);
                    break;
                case (1, 4):
                    queChu = queKinhDich.FirstOrDefault(x => x.queSo == 25);
                    queHo = queKinhDich.FirstOrDefault(x => x.queSo == 1);
                    break;
                case (1, 5):
                    queChu = queKinhDich.FirstOrDefault(x => x.queSo == 44);
                    queHo = queKinhDich.FirstOrDefault(x => x.queSo == 54);
                    break;
                case (1, 6):
                    queChu = queKinhDich.FirstOrDefault(x => x.queSo == 6);
                    queHo = queKinhDich.FirstOrDefault(x => x.queSo == 1);
                    break;
                case (1, 7):
                    queChu = queKinhDich.FirstOrDefault(x => x.queSo == 33);
                    queHo = queKinhDich.FirstOrDefault(x => x.queSo == 1);
                    break;
                case (1, 8):
                    queChu = queKinhDich.FirstOrDefault(x => x.queSo == 12);
                    queHo = queKinhDich.FirstOrDefault(x => x.queSo == 1);
                    break;
                case (2, 1):
                    queChu = queKinhDich.FirstOrDefault(x => x.queSo == 43);
                    queHo = queKinhDich.FirstOrDefault(x => x.queSo == 1);
                    break;
                case (2, 2):
                    queChu = queKinhDich.FirstOrDefault(x => x.queSo == 58);
                    queHo = queKinhDich.FirstOrDefault(x => x.queSo == 1);
                    break;
                case (2, 3):
                    queChu = queKinhDich.FirstOrDefault(x => x.queSo == 49);
                    queHo = queKinhDich.FirstOrDefault(x => x.queSo == 1);
                    break;
                case (2, 4):
                    queChu = queKinhDich.FirstOrDefault(x => x.queSo == 17);
                    queHo = queKinhDich.FirstOrDefault(x => x.queSo == 1);
                    break;
                case (2, 5):
                    queChu = queKinhDich.FirstOrDefault(x => x.queSo == 28);
                    queHo = queKinhDich.FirstOrDefault(x => x.queSo == 54);
                    break;
                case (2, 6):
                    queChu = queKinhDich.FirstOrDefault(x => x.queSo == 47);
                    queHo = queKinhDich.FirstOrDefault(x => x.queSo == 1);
                    break;
                case (2, 7):
                    queChu = queKinhDich.FirstOrDefault(x => x.queSo == 31);
                    queHo = queKinhDich.FirstOrDefault(x => x.queSo == 6);
                    break;
                case (2, 8):
                    queChu = queKinhDich.FirstOrDefault(x => x.queSo == 45);
                    queHo = queKinhDich.FirstOrDefault(x => x.queSo == 1);
                    break;
                case (3, 1):
                    queChu = queKinhDich.FirstOrDefault(x => x.queSo == 14);
                    queHo = queKinhDich.FirstOrDefault(x => x.queSo == 1);
                    break;
                case (3, 2):
                    queChu = queKinhDich.FirstOrDefault(x => x.queSo == 38);
                    queHo = queKinhDich.FirstOrDefault(x => x.queSo == 1);
                    break;
                case (3, 3):
                    queChu = queKinhDich.FirstOrDefault(x => x.queSo == 30);
                    queHo = queKinhDich.FirstOrDefault(x => x.queSo == 1);
                    break;
                case (3, 4):
                    queChu = queKinhDich.FirstOrDefault(x => x.queSo == 21);
                    queHo = queKinhDich.FirstOrDefault(x => x.queSo == 1);
                    break;
                case (3, 5):
                    queChu = queKinhDich.FirstOrDefault(x => x.queSo == 50);
                    queHo = queKinhDich.FirstOrDefault(x => x.queSo == 1);
                    break;
                case (3, 6):
                    queChu = queKinhDich.FirstOrDefault(x => x.queSo == 64);
                    queHo = queKinhDich.FirstOrDefault(x => x.queSo == 1);
                    break;
                case (3, 7):
                    queChu = queKinhDich.FirstOrDefault(x => x.queSo == 56);
                    queHo = queKinhDich.FirstOrDefault(x => x.queSo == 6);
                    break;
                case (3, 8):
                    queChu = queKinhDich.FirstOrDefault(x => x.queSo == 35);
                    queHo = queKinhDich.FirstOrDefault(x => x.queSo == 1);
                    break;
                case (4, 1):
                    queChu = queKinhDich.FirstOrDefault(x => x.queSo == 34);
                    queHo = queKinhDich.FirstOrDefault(x => x.queSo == 1);
                    break;
                case (4, 2):
                    queChu = queKinhDich.FirstOrDefault(x => x.queSo == 54);
                    queHo = queKinhDich.FirstOrDefault(x => x.queSo == 1);
                    break;
                case (4, 3):
                    queChu = queKinhDich.FirstOrDefault(x => x.queSo == 55);
                    queHo = queKinhDich.FirstOrDefault(x => x.queSo == 1);
                    break;
                case (4, 4):
                    queChu = queKinhDich.FirstOrDefault(x => x.queSo == 51);
                    queHo = queKinhDich.FirstOrDefault(x => x.queSo == 1);
                    break;
                case (4, 5):
                    queChu = queKinhDich.FirstOrDefault(x => x.queSo == 32);
                    queHo = queKinhDich.FirstOrDefault(x => x.queSo == 1);
                    break;
                case (4, 6):
                    queChu = queKinhDich.FirstOrDefault(x => x.queSo == 40);
                    queHo = queKinhDich.FirstOrDefault(x => x.queSo == 1);
                    break;
                case (4, 7):
                    queChu = queKinhDich.FirstOrDefault(x => x.queSo == 62);
                    queHo = queKinhDich.FirstOrDefault(x => x.queSo == 6);
                    break;
                case (4, 8):
                    queChu = queKinhDich.FirstOrDefault(x => x.queSo == 16);
                    queHo = queKinhDich.FirstOrDefault(x => x.queSo == 1);
                    break;
                case (5, 1):
                    queChu = queKinhDich.FirstOrDefault(x => x.queSo == 9);
                    queHo = queKinhDich.FirstOrDefault(x => x.queSo == 38);
                    break;
                case (5, 2):
                    queChu = queKinhDich.FirstOrDefault(x => x.queSo == 61);
                    queHo = queKinhDich.FirstOrDefault(x => x.queSo == 12);
                    break;
                case (5, 3):
                    queChu = queKinhDich.FirstOrDefault(x => x.queSo == 37);
                    queHo = queKinhDich.FirstOrDefault(x => x.queSo == 64);
                    break;
                case (5, 4):
                    queChu = queKinhDich.FirstOrDefault(x => x.queSo == 42);
                    queHo = queKinhDich.FirstOrDefault(x => x.queSo == 23);
                    break;
                case (5, 5):
                    queChu = queKinhDich.FirstOrDefault(x => x.queSo == 57);
                    queHo = queKinhDich.FirstOrDefault(x => x.queSo == 38);
                    break;
                case (5, 6):
                    queChu = queKinhDich.FirstOrDefault(x => x.queSo == 59);
                    queHo = queKinhDich.FirstOrDefault(x => x.queSo == 36);
                    break;
                case (5, 7):
                    queChu = queKinhDich.FirstOrDefault(x => x.queSo == 53);
                    queHo = queKinhDich.FirstOrDefault(x => x.queSo == 1);
                    break;
                case (5, 8):
                    queChu = queKinhDich.FirstOrDefault(x => x.queSo == 20);
                    queHo = queKinhDich.FirstOrDefault(x => x.queSo == 23);
                    break;
                case (6, 1):
                    queChu = queKinhDich.FirstOrDefault(x => x.queSo == 5);
                    queHo = queKinhDich.FirstOrDefault(x => x.queSo == 38);
                    break;
                case (6, 2):
                    queChu = queKinhDich.FirstOrDefault(x => x.queSo == 60);
                    queHo = queKinhDich.FirstOrDefault(x => x.queSo == 39);
                    break;
                case (6, 3):
                    queChu = queKinhDich.FirstOrDefault(x => x.queSo == 63);
                    queHo = queKinhDich.FirstOrDefault(x => x.queSo == 64);
                    break;
                case (6, 4):
                    queChu = queKinhDich.FirstOrDefault(x => x.queSo == 3);
                    queHo = queKinhDich.FirstOrDefault(x => x.queSo == 23);
                    break;
                case (6, 5):
                    queChu = queKinhDich.FirstOrDefault(x => x.queSo == 48);
                    queHo = queKinhDich.FirstOrDefault(x => x.queSo == 38);
                    break;
                case (6, 6):
                    queChu = queKinhDich.FirstOrDefault(x => x.queSo == 29);
                    queHo = queKinhDich.FirstOrDefault(x => x.queSo == 36);
                    break;
                case (6, 7):
                    queChu = queKinhDich.FirstOrDefault(x => x.queSo == 39);
                    queHo = queKinhDich.FirstOrDefault(x => x.queSo == 64);
                    break;
                case (6, 8):
                    queChu = queKinhDich.FirstOrDefault(x => x.queSo == 8);
                    queHo = queKinhDich.FirstOrDefault(x => x.queSo == 23);
                    break;
                case (7, 1):
                    queChu = queKinhDich.FirstOrDefault(x => x.queSo == 26);
                    queHo = queKinhDich.FirstOrDefault(x => x.queSo == 1);
                    break;
                case (7, 2):
                    queChu = queKinhDich.FirstOrDefault(x => x.queSo == 41);
                    queHo = queKinhDich.FirstOrDefault(x => x.queSo == 1);
                    break;
                case (7, 3):
                    queChu = queKinhDich.FirstOrDefault(x => x.queSo == 22);
                    queHo = queKinhDich.FirstOrDefault(x => x.queSo == 1);
                    break;
                case (7, 4):
                    queChu = queKinhDich.FirstOrDefault(x => x.queSo == 27);
                    queHo = queKinhDich.FirstOrDefault(x => x.queSo == 1);
                    break;
                case (7, 5):
                    queChu = queKinhDich.FirstOrDefault(x => x.queSo == 18);
                    queHo = queKinhDich.FirstOrDefault(x => x.queSo == 54);
                    break;
                case (7, 6):
                    queChu = queKinhDich.FirstOrDefault(x => x.queSo == 4);
                    queHo = queKinhDich.FirstOrDefault(x => x.queSo == 1);
                    break;
                case (7, 7):
                    queChu = queKinhDich.FirstOrDefault(x => x.queSo == 52);
                    queHo = queKinhDich.FirstOrDefault(x => x.queSo == 64);
                    break;
                case (7, 8):
                    queChu = queKinhDich.FirstOrDefault(x => x.queSo == 23);
                    queHo = queKinhDich.FirstOrDefault(x => x.queSo == 1);
                    break;
                case (8, 1):
                    queChu = queKinhDich.FirstOrDefault(x => x.queSo == 11);
                    queHo = queKinhDich.FirstOrDefault(x => x.queSo == 1);
                    break;
                case (8, 2):
                    queChu = queKinhDich.FirstOrDefault(x => x.queSo == 19);
                    queHo = queKinhDich.FirstOrDefault(x => x.queSo == 1);
                    break;
                case (8, 3):
                    queChu = queKinhDich.FirstOrDefault(x => x.queSo == 36);
                    queHo = queKinhDich.FirstOrDefault(x => x.queSo == 1);
                    break;
                case (8, 4):
                    queChu = queKinhDich.FirstOrDefault(x => x.queSo == 24);
                    queHo = queKinhDich.FirstOrDefault(x => x.queSo == 1);
                    break;
                case (8, 5):
                    queChu = queKinhDich.FirstOrDefault(x => x.queSo == 46);
                    queHo = queKinhDich.FirstOrDefault(x => x.queSo == 54);
                    break;
                case (8, 6):
                    queChu = queKinhDich.FirstOrDefault(x => x.queSo == 7);
                    queHo = queKinhDich.FirstOrDefault(x => x.queSo == 1);
                    break;
                case (8, 7):
                    queChu = queKinhDich.FirstOrDefault(x => x.queSo == 15);
                    queHo = queKinhDich.FirstOrDefault(x => x.queSo == 1);
                    break;
                case (8, 8):
                    queChu = queKinhDich.FirstOrDefault(x => x.queSo == 2);
                    queHo = queKinhDich.FirstOrDefault(x => x.queSo == 1);
                    break;
            }
            if (queChu != null)
            {
                if (queChu.loaiQue.ToLower().Contains("cát")) point += 2;
                else if (queChu.loaiQue.ToLower().Contains("bình hòa") || queChu.loaiQue.ToLower().Contains("hanh")) point += 1;
            }
            batQuai.queChu = queChu;
            batQuai.queHo = queHo;
            batQuai.point = point;

            return batQuai;
        }
        public static QuanNiemDanGianModel GetQuanNiemDanGianInfo(string simNumber)
        {
            QuanNiemDanGianModel quanNiemDanGian = new();
            //Tính số nút của sim
            var simNumberArr = simNumber.ToCharArray();
            float point = 0;
            int tongNut = 0;
            for (int i = 0; i < simNumberArr.Length; i++)
            {
                tongNut += int.Parse(simNumberArr[i].ToString());
            }
            string soNut = tongNut.ToString();
            if (tongNut.ToString().Length == 2)
                soNut = tongNut.ToString().Substring(1, 1);
            quanNiemDanGian.soNut = soNut;
            if (("8,9,0").Contains(soNut)) point += 1;
            if (("4,5,6,7").Contains(soNut)) point += 0.5f;

            //Tính điểm sim theo quan niệm dan gian
            var listSoDep = new List<string>() { "79", "39", "68", "86", "99", "88", "89", "66", "78", "38" };
            var soDepInSim = listSoDep.Where(x => simNumber.Contains(x)).ToList();
            quanNiemDanGian.soDepInSim = String.Join(",", soDepInSim);
            if (soDepInSim.Count() > 0)
                point += 1;

            quanNiemDanGian.point = point;
            return quanNiemDanGian;
        }
    }
}
