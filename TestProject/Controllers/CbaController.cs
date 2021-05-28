using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.Interfaces;

namespace TestProject.Models
{
    /// <summary>
    /// Cba聯賽
    /// </summary>
    public class CbaController
    {
        private ICompressor _compressor;

        public CbaController(ICompressor compressor)
        {
            _compressor = compressor;
        }

        public void Save()
        {
            Console.WriteLine($"CBA is using {_compressor.DoCompress()}");
        }
    }
}
