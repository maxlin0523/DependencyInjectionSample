using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.Interfaces;

namespace TestProject.Models
{
    /// <summary>
    /// sbl聯賽
    /// </summary>
    public class SblController
    {
        private ICompressor _compressor;

        public SblController(ICompressor compressor)
        {
            _compressor = compressor;
        }

        public void Save()
        {
            Console.WriteLine($"SBL is using {_compressor.DoCompress()}");
        }
    }
}
