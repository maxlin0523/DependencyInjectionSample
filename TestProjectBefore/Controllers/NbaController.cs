using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectBefore.Models
{
    /// <summary>
    /// Nba聯賽
    /// </summary>
    public class NbaController
    {
        private SaveDatabase _save;

        public NbaController()
        {
            _save = new SaveDatabase();
        }

        public void SaveRecord()
        {
            Console.WriteLine($"NBA is {_save.DoSave()}");
        }
    }
}
