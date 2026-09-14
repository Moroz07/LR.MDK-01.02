using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divide
{

    public class Calculator
    {

        public static double? Divide(double a, double b) 
        {
            if (b == 0)
            {  return null; }
            return a / b;
            
        }
    }
}
