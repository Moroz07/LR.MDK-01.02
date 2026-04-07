using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLibary
{
    public class SalesAnalyser //посчитать товары, средняя выручка которых меньше х
    {
       public List<Product> CountProductPrice(List<Product> Allproduct, int x)
        {
            List<Product> product = new List<Product>();
            double allrevenue = 0;
            foreach (var p in Allproduct)
            {
                allrevenue = (int)p.Price * (int)p.Count;
                if(allrevenue > x)
                {
                    product.Add(p);
                }
                allrevenue = 0;
            }

            return product;
        }
        
    }
}
