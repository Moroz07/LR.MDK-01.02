using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLibary
{
    class SaleImporter
    {
        private List<Product> products_ = new List<Product>();
        public List<Product> ReadAllFromFile()
        {

            return products_;
        }
    }
}
