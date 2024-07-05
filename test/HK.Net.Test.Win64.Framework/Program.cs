using System;

namespace HK.Net.Win64.Framework.Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (CHCNetSDK.NET_DVR_Init())
                Console.WriteLine("sdk 初始化成功");
            else
                Console.WriteLine("sdk 初始化失败");

            Console.ReadKey();
        }
    }
}
