using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestLibary;

namespace TIntegrationTest
{
    [TestClass]
    public class TestProduct
    {
        SaleImporter sales = new SaleImporter();
        [TestMethod]
        public void TestFile()
        {
            List<Product> productFromFile = sales.ReadAllFromFile();
            List<Product> expected = new List<Product>();
            expected.Add(new Product
            {
               Name =  "Кола",
                Price = 500,
                Count = 75
            });
            expected.Add(new Product
            {
                Name = "Спрайт",
                Price = 750,
                Count = 65
            });
            expected.Add(new Product
            {
                Name = "Бананы",
                Price = 2000,
                Count = 50
            });
            expected.Add(new Product
            {
                Name = "Апельсин",
                Price = 1200,
                Count = 45
            });

            CollectionAssert.AreEqual(expected, productFromFile);
            //Assert.AreEqual(expected[0].Name, productFromFile[0].Name);
            //Assert.AreEqual(expected[1].Name, productFromFile[1].Name);
            //Assert.AreEqual(expected[2].Name, productFromFile[2].Name);
            //Assert.AreEqual(expected[3].Name, productFromFile[3].Name);
        }
    }
}
