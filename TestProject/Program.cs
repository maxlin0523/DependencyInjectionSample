using System;
using TestProject.Interfaces;
using TestProject.Models;
using Unity;

namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // unity是loc容器的一個框架

            // 建立loc容器(unity)。
            IUnityContainer container = new UnityContainer();

            // 向loc容器(unity)註冊型別。
            container.RegisterType<ICompressor, ZipCompressor>();

            // 解析型別取得元件的執行個體，
            ICompressor enity = container.Resolve<ICompressor>();
            // 以上的code 一般放在程式一啟動的片段
            // .NET Framework為 APP_START
            // .NET Core為 Startup


            // 建立元件。
            var nba = new NbaController(enity);
            var cba = new CbaController(enity);
            var sbl = new SblController(enity);

            // 呼叫元件的方法。
            nba.Save();
            cba.Save();
            sbl.Save();

            Console.ReadKey();
        }
    }
}
