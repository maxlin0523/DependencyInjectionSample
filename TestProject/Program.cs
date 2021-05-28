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
            // 此範例用Unity。
            // Unity套件是IoC容器的一個框架

            // 建立IoC容器。
            IUnityContainer container = new UnityContainer();

            // 向IoC容器註冊型別。
            container.RegisterType<ICompressor, ZipCompressor>();

            // 若想改Rar壓縮，註冊型別請改成以下:
            // container.RegisterType<ICompressor, RarCompressor>();


            // 解析型別取得元件的執行個體。
            var nba = container.Resolve<NbaController>();
            var cba = container.Resolve<CbaController>();
            var sbl = container.Resolve<SblController>();

            // 呼叫元件的方法。
            nba.Save();
            cba.Save();
            sbl.Save();

            Console.ReadKey();
        }
    }
}
