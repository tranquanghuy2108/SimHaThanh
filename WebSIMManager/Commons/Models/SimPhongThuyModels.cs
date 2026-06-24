using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons.Models
{
    public class QueKinhDichModel
    {
        public int queSo { get; set; }
        public string queName { get; set; }
        public string tuongQue { get; set; }
        public string loiKinh { get; set; }
        public string dichAm { get; set; }
        public string dichNghia { get; set; }
        public string giaiNghia { get; set; }
        public string loaiQue { get; set; }
        public string totChoViec { get; set; }
    }
    public class MenhChuInfoModel
    {
        public int NamSinh { get; set; }
        public string CanChi { get; set; }
        public string ConGiap { get; set; }
        public string CungSinh1 { get; set; }
        public string CungSinh2 { get; set; }
        public string NguHanh { get; set; }
        public string CungPhi1 { get; set; }
        public string CungPhi2 { get; set; }
    }
    public class AmDuongTuongPhoiModel
    {
        public List<string> amDuongTuongPhoi { get; set; }
        public int soAmAmount { get; set; }
        public int soDuongAmount { get; set; }
        public string vanSo { get; set; }
        public string menhAmDuong { get; set; }
        public float point { get; set; }
    }
    public class NguHanhSimModel
    {
        public List<string> numberOfSim { get; set; }
        public List<string> nguHanhOfnumber { get; set; }
        public List<string> nguHanhSinhKhac { get; set; }
        public string simSinhKhac { get; set; }
        public string nguHanhSim { get; set; }
        public float point { get; set; }
    }
    public class QueBatQuaiModel
    {
        public QueKinhDichModel queChu { get; set; }
        public QueKinhDichModel queHo { get; set; }
        public float point { get; set; }
    }
    public class QuanNiemDanGianModel
    {
        public string soNut { get; set; }
        public string soDepInSim { get; set; }
        public float point { get; set; }
    }
    public class FengShuiSimModel
    {
        public string nguHanhSim { get; set; }
        public string nguHanhTuongSinh { get; set; }
        public string amDuongTuongSinh { get; set; }
        public float point { get; set; }
    }

}
