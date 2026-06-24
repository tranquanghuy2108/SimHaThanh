using Commons.CallAPIs;
using Commons.Helper;
using EFCoreMySQL.DataContext;
using EFCoreMySQL.EntityModels;
using Microsoft.EntityFrameworkCore;
using Models.ViewModels;
using MySqlConnector;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WS_CheckSimVNPT
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly IServiceProvider _provider;
        private readonly IHostApplicationLifetime _hostApplicationLifetime;

        public Worker(ILogger<Worker> logger, IServiceProvider provider, IHostApplicationLifetime hostApplicationLifetime)
        {
            _logger = logger;
            _provider = provider;
            _hostApplicationLifetime = hostApplicationLifetime;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _logger.LogInformation("Checking sim in VNPT running at: {time}", DateTimeOffset.Now);
            try
            {
                //Open connection DB
                using var scope = _provider.CreateScope();
                var db = scope.ServiceProvider.GetRequiredService<SIMCenterDbContext>();

                //Lấy danh sách sim của kho vinaphone
                // Chuẩn bị tên và câu lệnh của stored procedure
                string storedProcedureName = "GetSimForCheckSimVNPT";
                string query = $"CALL {storedProcedureName}()";

                // Tạo các đối tượng MySqlParameter từ các giá trị trong request
                var parameters = new List<MySqlParameter>
                { };

                // Thực hiện truy vấn sử dụng FromSqlRaw
                var dataExec = db.Set<SimForCheckSimVNPYModel>().FromSqlRaw(query, parameters.ToArray()).ToList();

                // Kiểm tra dữ liệu và xóa data nếu sim đã ko còn trong kho
                List<int> simIds = new List<int>();
                int delSimNumber = 0;
                foreach (var sim in dataExec)
                {
                    var simNumber = sim.SIMNumber.Replace(".", "");

                    //Set key
                    var searchKey = simNumber.Substring(3);

                    //Set prefix
                    var prefix = simNumber.Substring(0, 3).Replace("0", "84");

                    //Setup SimType
                    var simType = 21;
                    if (sim.ProductTypeId == 2 || sim.ProductTypeId == 4) simType = 22;

                    var checkSimResult = await VNPTCallAPI.GetSimAsync(searchKey, prefix, simType);

                    if (checkSimResult == null || checkSimResult.Count == 0)
                    {
                        simIds.Add(sim.Id);
                        delSimNumber++;
                        _logger.LogInformation("Sim khong con trong kho VNPT: " + sim.SIMNumber);
                    }
                    else
                    {
                        Console.WriteLine("Sim san sang: " + sim.SIMNumber);
                        var simHadCheck = db.SIMDetails.FirstOrDefault(x => x.Id == sim.Id);
                        if (simHadCheck != null)
                        {
                            simHadCheck.UpdateTime = DateTime.Now;
                            db.SIMDetails.Update(simHadCheck);
                            db.SaveChanges();
                        }
                    }
                    //Delete sim not exist
                    if (simIds.Count >= 100)
                    {
                        var simNotExit1 = db.SIMDetails.Where(x => simIds.Contains(x.Id));
                        db.SIMDetails.RemoveRange(simNotExit1);
                        db.SaveChanges();
                        simIds = new();
                    }
                }
                var simNotExit = db.SIMDetails.Where(x => simIds.Contains(x.Id));
                db.SIMDetails.RemoveRange(simNotExit);
                db.SaveChanges();
                _logger.LogInformation("So sim da xoa VNPT: " + delSimNumber);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
            }
            finally
            {
                _logger.LogInformation("Checking sim in VNPT is stopped..");
                _hostApplicationLifetime.StopApplication();
            }
        }
    }
}