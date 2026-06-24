using Commons.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ViewModels
{
    public class TimSimPhongThuyRequestModel
    {
        public int pageIndex { get; set; }
        public int pageSize { get; set; }
        public int yearOfBirth { get; set; }
        public int monthOfBirth { get; set; }
        public int dateOfBirth { get; set; }
        public int hourOfBirth { get; set; }
        public int minuteOfBirth { get; set; }
        public bool isMale { get; set; }
    }
    public class TimSimPhongThuyResponseModel
    {
        public string BirthDay { get; set; }
        public string LunarBirthDay { get; set; }
        public MenhChuInfoModel menhchu { get; set; }
        public List<SimPhongThuyResultModel> simPhongThuys { get; set; }
    }
    public class SimPhongThuyResultModel
    {
        public int simId { get; set; }
        public int networkId { get; set; }
        public string simNumber { get; set; }
        public double price { get; set; }
        public float point { get; set; }
        public string nguHanhSim { get; set; }
        public string queKinhDich { get; set; }
        public string yNghiaQue { get; set; }
        public int TotalCount { get; set; }
    }

    public class XemDiemSimRequestModel
    {
        public string simNumber { get; set; }
        public int yearOfBirth { get; set; }
        public int monthOfBirth { get; set; }
        public int dateOfBirth { get; set; }
        public int hourOfBirth { get; set; }
        public int minuteOfBirth { get; set; }
        public bool isMale { get; set; }
    }
    public class DinhGiaSimRequestModel
    {
        public string simNumber { get; set; }
    }
    public class XemDiemSimrResponseModel
    {
        public string BirthDay { get; set; }
        public string LunarBirthDay { get; set; }
        public MenhChuInfoModel menhchu { get; set; }
        public AmDuongTuongPhoiModel amDuongTuongPhoi { get; set; }
        public NguHanhSimModel nguHanhSim { get; set; }
        public QueBatQuaiModel queBatQuai { get; set; }
        public float pointCuuTinhDo { get; set; }
        public QuanNiemDanGianModel quanNiemDanGian { get; set; }
    }
}
