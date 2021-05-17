using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.Interfaces;

namespace TestProject.Models
{
    /// <summary>
    /// Zip壓縮
    /// </summary>
    public class ZipCompressor : ICompressor
    {
        public string DoCompress()
        {
            return "ZipCompress done";
        }
    }
}
