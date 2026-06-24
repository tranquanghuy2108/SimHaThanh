using System.Data.Entity;
using System.Linq;
using System.Runtime.CompilerServices;
using Commons.CallAPIs;
using Commons.Helper;
using EFCoreMySQL.DataContext;
using EFCoreMySQL.EntityModels;
using Microsoft.EntityFrameworkCore;
using Models.ViewModels;
using MySqlConnector;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static Microsoft.Extensions.Logging.EventSource.LoggingEventSource;

namespace WS_UpdateSimVNPT
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly IServiceProvider _provider;
        private readonly IHostApplicationLifetime _hostApplicationLifetime;

        public Worker(
            ILogger<Worker> logger,
            IServiceProvider provider,
            IHostApplicationLifetime hostApplicationLifetime
        )
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

                var sims = db.SIMDetails.ToList();
                foreach (var s in sims)
                {
                    //var diemSim = SimPhongThuy.TinhDiemPhongThuy(s.SIMNumber);
                    //s.amDuongTuongSinh = diemSim.amDuongTuongSinh;
                    //s.nguHanhSim = diemSim.nguHanhSim;
                    //s.nguHanhTuongSinh = diemSim.nguHanhTuongSinh;
                    //s.point = diemSim.point;
                    //Console.WriteLine("sim {0} có ngu hanh {1}, tuong sinh ngu hanh {2}, am duong tuong sinh {3}, diem {4}", s.SIMNumber, diemSim.nguHanhSim, diemSim.nguHanhTuongSinh, diemSim.amDuongTuongSinh, diemSim.point);
                    //db.SIMDetails.Update(s);
                    List<string> dataInsertSimTypes = new();
                    var simHadFormat = "";
                    var listFormatTypeOfSim = FileHelper.CheckFormatTypeOfSim(
                        s.SIMNumber,
                        out simHadFormat
                    );
                    s.SIMNumber = simHadFormat;
                    db.SIMDetails.Update(s);
                    if (listFormatTypeOfSim.Count > 0)
                    {
                        //INSERT INTO simtypes (SimId, TypeId) VALUES ('1', '1');
                        var listTypeOfSimId = db
                            .TypeOfSIMs.AsEnumerable()
                            .Where(x =>
                                listFormatTypeOfSim.Any(f =>
                                    !string.IsNullOrEmpty(f)
                                    && (
                                        x.Format != null
                                        && f != null
                                        && x.Format.Split(',')
                                            .Any(format => format.Trim() == f.Trim())
                                    )
                                )
                            )
                            .Select(x => x.Id)
                            .ToList();

                        listTypeOfSimId.Distinct();
                        foreach (var type in listTypeOfSimId)
                        {
                            string dataInsert = "(" + s.Id + "," + type + ")";
                            dataInsertSimTypes.Add(dataInsert);
                        }
                        if (dataInsertSimTypes.Count > 0)
                        {
                            FormattableString InsertSqlStr = FormattableStringFactory.Create(
                                "INSERT INTO simtypes (SimId, TypeId) VALUES "
                                    + string.Join(",", dataInsertSimTypes)
                            );
                            dataInsertSimTypes = new();
                            var result = await db.Database.ExecuteSqlInterpolatedAsync(
                                InsertSqlStr
                            );

                            _logger.LogInformation("Update loại sim cho số: " + simHadFormat);
                        }
                        else
                        {
                            _logger.LogInformation("Sim không có trong bộ số đẹp: " + simHadFormat);
                        }
                    }
                }
                db.SaveChanges();
                _logger.LogInformation("Update loại sim hoàn thành");
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
