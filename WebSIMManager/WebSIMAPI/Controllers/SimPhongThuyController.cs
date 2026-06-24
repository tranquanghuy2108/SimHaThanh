using System.Drawing;
using System.Numerics;
using Commons.Helper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.ViewModels;
using Repositories.Interface;

namespace WebSIMAPI.Controllers
{
    [Route("api/sim-phong-thuy")]
    [ApiController]
    [Authorize]
    public class SimPhongThuyController : Controller
    {
        private readonly ISIMRepository _simRepository;

        public SimPhongThuyController(ISIMRepository simRepository)
        {
            _simRepository = simRepository;
        }

        [HttpPost("dinh-gia-sim")]
        public double DinhGiaSim(string simNumber)
        {
            simNumber = simNumber.Replace(".", "");
            var formatSimLst = FileHelper.CheckFormatTypeOfSim(simNumber, out _);
            var estimatePrice = _simRepository.GetEstimatedPrice(formatSimLst);
            double pricePT = 300000;
            var diemSim = SimPhongThuy.TinhDiemPhongThuy(simNumber);
            if (diemSim.point > 8)
                pricePT = 800000;
            if (pricePT >= estimatePrice)
                return pricePT;
            else
                return estimatePrice;
        }

        [HttpPost("tim-sim-phong-thuy")]
        public TimSimPhongThuyResponseModel TimSimPhongThuy(TimSimPhongThuyRequestModel request)
        {
            TimSimPhongThuyResponseModel result = new();
            var lunarBirthDay = SimPhongThuy.GetDateOfChinese(
                request.yearOfBirth,
                request.monthOfBirth,
                request.dateOfBirth
            );
            result.BirthDay =
                request.dateOfBirth + "/" + request.monthOfBirth + "/" + request.yearOfBirth;
            result.LunarBirthDay = lunarBirthDay.ToString("dd/MM/yyyy");
            var menhchu = SimPhongThuy.GetUserFengShuiInfo(lunarBirthDay.Year);
            result.menhchu = menhchu;
            var amDuong = SimPhongThuy.GetMenhAmDuong(menhchu.CanChi, request.isMale);
            result.simPhongThuys = new();
            var simPTs = _simRepository.GetSimPTOfMenhChu(
                amDuong.Substring(0, amDuong.IndexOf(" ")),
                menhchu.NguHanh,
                request.pageIndex,
                request.pageSize
            );
            result.simPhongThuys = simPTs;
            //var simPT =
            return result;
        }

        [HttpPost("xem-diem-sim")]
        public XemDiemSimrResponseModel XemDiemSim(XemDiemSimRequestModel request)
        {
            XemDiemSimrResponseModel diemSim = new();
            diemSim.BirthDay =
                request.dateOfBirth + "/" + request.monthOfBirth + "/" + request.yearOfBirth;
            var lunarBirthDay = SimPhongThuy.GetDateOfChinese(
                request.yearOfBirth,
                request.monthOfBirth,
                request.dateOfBirth
            );
            diemSim.LunarBirthDay = lunarBirthDay.ToString("dd/MM/yyyy");
            var menhchu = SimPhongThuy.GetUserFengShuiInfo(lunarBirthDay.Year);
            diemSim.menhchu = menhchu;
            diemSim.amDuongTuongPhoi = SimPhongThuy.GetAmDuongTuongPhoi(
                request.simNumber,
                menhchu.CanChi,
                request.isMale
            );
            diemSim.nguHanhSim = SimPhongThuy.GetNguHanhSim(request.simNumber, menhchu.NguHanh);
            diemSim.queBatQuai = SimPhongThuy.GetQueBatQuaiInfo(request.simNumber);
            float pointCuuTinhDo = 0;
            if (request.simNumber.Contains("9"))
                pointCuuTinhDo += 2;
            else
                pointCuuTinhDo += 1;
            diemSim.pointCuuTinhDo = pointCuuTinhDo;
            diemSim.quanNiemDanGian = SimPhongThuy.GetQuanNiemDanGianInfo(request.simNumber);

            return diemSim;
        }
    }
}
