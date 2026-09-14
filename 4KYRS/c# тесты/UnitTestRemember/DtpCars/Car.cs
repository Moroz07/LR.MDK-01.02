using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DtpCars
{
    public class Car
    {
        public string Model {  get; set; }
        public string Year { get; set; }
        public string Mark {  get; set; }
        public bool IsDtp { get; set; }

        public void DtpSearch(List<Car> Cars)
        {
            string path = "C:\\П-40 2027\\тест машинки\\ДТП.txt";
            StreamWriter sr = new StreamWriter(path);
            foreach (var Car in Cars)
            {
                if (Car.IsDtp)
                {
                    sr.WriteLine(Car.Mark + ", " + Car.Model + ", " + Car.Year);
                    
                }    

            }
            sr.Close();
        }
    }

   
}
