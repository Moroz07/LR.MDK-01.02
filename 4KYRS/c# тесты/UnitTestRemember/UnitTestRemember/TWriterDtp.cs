using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DtpCars;
using System.IO;

namespace UnitTestRemember
{

    [TestClass]
    public class TWriterDtp
    {

        [TestMethod]
        public void WriterCars()
        {
            List<Car> cars = new List<Car>();
            cars.Add(new Car()
            {
                Mark = "Ford",
                Model = "Focus 3",
                Year = "2012",
                IsDtp = false
            });

            cars.Add(new Car()
            {
                Mark = "Hyundai",
                Model = "Solaris",
                Year = "2010",
                IsDtp = true
            });

            cars.Add(new Car()
            {
                Mark = "Lada",
                Model = "Vaz2114",
                Year = "2009",
                IsDtp = true
            });

            Car s = new Car();
            s.DtpSearch(cars);

            string path = "C:\\П-40 2027\\тест машинки\\ДТП.txt";
            StreamReader sr = new StreamReader(path);
            Assert.AreEqual("Hyundai, Solaris, 2010", sr.ReadLine());
            Assert.AreEqual("Lada, Vaz2114, 2009", sr.ReadLine());

        }
    }
}
