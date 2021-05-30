using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.Interfaces;

namespace TestProject.Models
{
    /// <summary>
    /// 儲存到資料庫
    /// </summary>
    public class SaveDatabase : ISave
    {
        public string DoSave()
        {
            // todo
            return "saving in the database.";
        }
    }
}
