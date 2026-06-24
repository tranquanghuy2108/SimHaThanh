// See https://aka.ms/new-console-template for more information
using System.Net.WebSockets;
using Commons.CallAPIs;
using Commons.Helper;

Console.WriteLine("Hello, World!");

//await TelegramHelper.SendMessage(-4286160390, "Bạn có 1 sim mới đặt!");
var simNuber = "0818.932.689";
var loaiSoDep = FileHelper.CheckFormatTypeOfSim(simNuber, out string phoneNumberNew);

Console.WriteLine("loaiSoDep :" + string.Join(",", loaiSoDep) + " format " + phoneNumberNew);
