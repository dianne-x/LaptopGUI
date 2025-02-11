using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaptopGUI
{
    internal class Manufacturer
    {
        public int ManufacturerCode { get; set; }
        public string ManufacturerName { get; set; }

        public Manufacturer(int manufacturerCode, string manufacturerName)
        {
            ManufacturerCode = manufacturerCode;
            ManufacturerName = manufacturerName;
        }

        public override string ToString()
        {
            return $"{ManufacturerName})";
        }
    }
}
