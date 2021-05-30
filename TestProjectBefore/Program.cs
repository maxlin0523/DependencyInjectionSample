using System;
using TestProjectBefore.Models;

namespace TestProjectBefore
{
    class Program
    {
        static void Main(string[] args)
        {
            var nba = new NbaController();
            nba.SaveRecord();

            // 執行結果為:
            // NBA is saving in the excel.
            Console.ReadKey();
        }
    }
}
