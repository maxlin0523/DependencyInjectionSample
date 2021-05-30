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

            // 向IoC容器註冊型別也就是依賴注入(Denpendency Injection)。
            container.RegisterType<ISave, SaveExcel>();

            // 若想以資料庫存檔，請改成以下注入:
            // container.RegisterType<ISave, SaveDatabase>();



            // 解析型別取得元件的執行個體，
            // 並由容器"主動"提供依賴物件給Nba類別使用，不需再宣告建構式！
            var nba = container.Resolve<NbaController>();

            // 呼叫方法。
            nba.SaveRecord();

            // 輸出結果就會根據你註冊的儲存類別而改變

            Console.ReadKey();
        }
    }
}
