using Commons.Helper;
using EFCoreMySQL.DataContext;
using EFCoreMySQL.EntityModels;
using Commons.CallAPIs;
using Commons.Enums;

namespace WorkerService.Services
{
	public class VNPTSimHandle : BackgroundService
	{
		private readonly IServiceProvider _provider;
		private readonly ILogger<Worker> _logger;
		private readonly IHostApplicationLifetime _hostApplicationLifetime;

		public VNPTSimHandle(ILogger<Worker> logger, IServiceProvider provider, IHostApplicationLifetime hostApplicationLifetime)
		{
			_logger = logger;
			_provider = provider;
			_hostApplicationLifetime = hostApplicationLifetime;
		}

		protected override async Task ExecuteAsync(CancellationToken stoppingToken)
		{
			_logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
			try
			{
				using var scope = _provider.CreateScope();
				var db = scope.ServiceProvider.GetRequiredService<SIMCenterDbContext>();
				//var searchKeys = db.TypeOfSIMs.Select(x => x.Description).ToList();
				var searchKeys = new List<string> { "*0", "*1", "*2", "*3", "*4", "*5", "*6", "*7", "*8", "*9", "*" };
				var prefixs = new List<string> { "8491", "8494", "8481", "8482", "8483", "8484", "8485", "8488" };
				searchKeys = searchKeys.Distinct().ToList();
				var searchKeyStr = string.Join(',', searchKeys);
				int simCount = 0;
				int MAX_SIM_NUMBER = 1000000;
				var ownerId = db.Users.FirstOrDefault(x => x.UserName.ToLower().Contains("vinaphone"))?.Id;
				var defaultPrice = db.ProductTypes.FirstOrDefault(x => x.Id == 1)?.DefaulPrice;
				//while (!stoppingToken.IsCancellationRequested)
				{
					while (simCount <= MAX_SIM_NUMBER)
					{
						foreach (var prefix in prefixs)
						{
							for (int i = 0; i < 1000; i++)
							{
								//Sim trả trước
								var simData = await VNPTCallAPI.GetSimAsync("*" + i, prefix);
								if (simData != null)
								{
									int saveSim = 0;
									foreach (var sim in simData)
									{
										string simNum = sim.msisdn.Substring(2);
										var dataChecking = db.SIMDetails.FirstOrDefault(x => x.SIMNumber.Replace(".", "").Substring(1) == simNum);
										if (dataChecking != null)
											continue;

										string simHadFormat;
										var listFormatTypeOfSim = FileHelper.CheckFormatTypeOfSim(simNum, out simHadFormat);

										var listTypeOfSim = db.TypeOfSIMs.Where(x => listFormatTypeOfSim.Contains(x.Format)).ToList();
										var listTypeOfSimId = listTypeOfSim.Select(x => x.Id).ToList();
										listTypeOfSimId = listTypeOfSimId.Distinct().ToList();
										//Giá sim
										double giaSim = 399000;
										if (listTypeOfSim.Count > 0)
										{
											var giaSimDefaul = listTypeOfSim[0].EstimatedPrice;
											if (giaSimDefaul > giaSim) giaSim = giaSimDefaul;
										}
										//Create SIM
										bool camket = true;
										if (string.IsNullOrEmpty(sim.cuoc_camket) || sim.cuoc_camket == "0")
										{
											camket = false;
										}
										var diemSim = SimPhongThuy.TinhDiemPhongThuy(simHadFormat);
										var dataNew = new SIMDetail()
										{
											SIMNumber = simHadFormat,
											SIMImgUrl = "",
											SIMPrice = giaSim,//sim.price,
											SIMPriceOfAgent = sim.price,
											AgentSIMPrice = giaSim,
											CollaboratorsSIMPrice = giaSim,
											SIMNetworkId = 2,
											ProductTypeId = !camket ? 1 : 3,
											Description = sim.kieu_so + " | " + sim.cuoc_camket + " | " + sim.thoigian_camket,
											nguHanhSim = diemSim.nguHanhSim,
											nguHanhTuongSinh = diemSim.nguHanhTuongSinh,
											amDuongTuongSinh = diemSim.amDuongTuongSinh,
											point = diemSim.point,
											CreateTime = DateTime.Now,
											UpdateTime = DateTime.Now,
											Owner = ownerId,
											IsMySim = false,
											IsVerify = true,
											status = ApprovedStatus.Approved
										};
										db.SIMDetails.Add(dataNew);

										saveSim = db.SaveChanges();
										simCount += saveSim;
										foreach (var item in listTypeOfSimId)
										{
											var simTypeData = new SIMType()
											{
												SimId = dataNew.Id,
												TypeId = item
											};
											db.SIMTypes.Add(simTypeData);
										}

										Console.WriteLine("Add sim tra truoc: " + simNum);
									}
									//Sim trả sau
									var simDataTS = await VNPTCallAPI.GetSimAsync("*" + i, prefix, simType: 22);
									int saveSimTS = 0;
									foreach (var sim in simDataTS)
									{
										string simNum = sim.msisdn.Substring(2);
										var dataChecking = db.SIMDetails.FirstOrDefault(x => x.SIMNumber.Replace(".", "").Substring(1) == simNum);
										if (dataChecking != null)
											continue;

										string simHadFormat;
										var listFormatTypeOfSim = FileHelper.CheckFormatTypeOfSim(simNum, out simHadFormat);

										var listTypeOfSim = db.TypeOfSIMs.Where(x => listFormatTypeOfSim.Contains(x.Format)).ToList();
										var listTypeOfSimId = listTypeOfSim.Select(x => x.Id).ToList();
										listTypeOfSimId = listTypeOfSimId.Distinct().ToList();
										//Giá sim
										double giaSim = 399000;
										if (listTypeOfSim.Count > 0)
										{
											var giaSimDefaul = listTypeOfSim[0].EstimatedPrice;
											if (giaSimDefaul > giaSim) giaSim = giaSimDefaul;
										}

										//Create SIM
										bool camket = true;
										if (string.IsNullOrEmpty(sim.cuoc_camket) || sim.cuoc_camket == "0")
										{
											camket = false;
										}
										var diemSim = SimPhongThuy.TinhDiemPhongThuy(simHadFormat);
										var dataNew = new SIMDetail()
										{
											SIMNumber = simHadFormat,
											SIMImgUrl = "",
											SIMPrice = giaSim,//sim.price,
											AgentSIMPrice = giaSim,
											CollaboratorsSIMPrice = giaSim,
											SIMPriceOfAgent = sim.price,
											SIMNetworkId = 2,
											ProductTypeId = !camket ? 2 : 4,
											Description = sim.kieu_so + " | " + sim.cuoc_camket + " | " + sim.thoigian_camket,
											nguHanhSim = diemSim.nguHanhSim,
											nguHanhTuongSinh = diemSim.nguHanhTuongSinh,
											amDuongTuongSinh = diemSim.amDuongTuongSinh,
											point = diemSim.point,
											CreateTime = DateTime.Now,
											UpdateTime = DateTime.Now,
											Owner = ownerId,
											IsMySim = false,
											IsVerify = true,
											status = ApprovedStatus.Approved
										};
										db.SIMDetails.Add(dataNew);

										saveSimTS = db.SaveChanges();
										simCount += saveSimTS;
										foreach (var item in listTypeOfSimId)
										{
											var simTypeData = new SIMType()
											{
												SimId = dataNew.Id,
												TypeId = item
											};
											db.SIMTypes.Add(simTypeData);
										}

										Console.WriteLine("Add sim tra sau: " + simNum);
									}
									//Check đủ số
									if (simCount > MAX_SIM_NUMBER) break;
								}
							}
						}

					}
				}
			}
			catch (Exception ex)
			{
				_logger.LogError(ex, ex.Message);
			}
			finally
			{
				_logger.LogInformation("Windows Service is stopped..");
				_hostApplicationLifetime.StopApplication();
			}
		}
	}
}
