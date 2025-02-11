using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaptopGUI
{
    internal class Category
    {
        public int CategoryCode { get; set; }
        public string CategoryName { get; set; }

        public Category(int categoryCode, string categoryName)
        {
            CategoryCode = categoryCode;
            CategoryName = categoryName;
        }

        public override string ToString()
        {
            return $"{CategoryName})";
        }
    }
}
