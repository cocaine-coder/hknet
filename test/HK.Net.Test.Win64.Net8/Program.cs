// See https://aka.ms/new-console-template for more information

using HK.Net;

if (CHCNetSDK.NET_DVR_Init())
    Console.WriteLine("sdk 初始化成功");
else
    Console.WriteLine("sdk 初始化失败");