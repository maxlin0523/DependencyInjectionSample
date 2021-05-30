using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.Interfaces;

namespace TestProject.Models
{
    /// <summary>
    /// 儲存到excel
    /// </summary>
    public class SaveExcel : ISave
    {
        public string DoSave()
        {
            // todo
            return "saving in the excel.";
        }
    }
}
