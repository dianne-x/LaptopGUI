using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaptopGUI
{
    internal class Laptop
    {
        public Category Category { get; set; }
        public string CPU { get; set; }
        public Manufacturer Manufacturer { get; set; }
        public string Model { get; set; }
        public string OS { get; set; }
        public decimal Price { get; set; }
        public int RAM { get; set; }
        public string Screen { get; set; }
        public string Storage { get; set; }

        public Laptop(string sor)
        {
            string[] sorElemek = sor.Split(';');
            Category = new Category(Convert.ToInt32(sorElemek[0]), sorElemek[1]);
            CPU = sorElemek[2];
            Manufacturer = new Manufacturer(Convert.ToInt32(sorElemek[3]), sorElemek[4]);
            Model = sorElemek[5];
            OS = sorElemek[6];
            Price = Convert.ToDecimal(sorElemek[7]);
            RAM = Convert.ToInt32(sorElemek[8]);
            Screen = sorElemek[9];
            Storage = sorElemek[10];

        }

        public override string ToString()
        {
            return $"{Manufacturer.ManufacturerName} {Model}";
        }
    }
}
