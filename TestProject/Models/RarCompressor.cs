using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.Interfaces;

namespace TestProject.Models
{
    /// <summary>
    /// RAR壓縮
    /// </summary>
    public class RarCompressor : ICompressor
    {
        public string DoCompress()
        {
            return "RarCompress done";
        }
    }
}
