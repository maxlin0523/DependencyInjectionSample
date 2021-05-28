using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.Interfaces;

namespace TestProject.Models
{
    /// <summary>
    /// Nba聯賽
    /// </summary>
    public class NbaController
    {
        private ICompressor _compressor;

        public NbaController(ICompressor compressor)
        {
            _compressor = compressor;
        }

        public void Save()
        {
            Console.WriteLine($"NBA is using {_compressor.DoCompress()}");
        }
    }
}
