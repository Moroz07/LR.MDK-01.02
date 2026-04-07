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
        List<Product> productFromFile;

        [TestInitialize]
        public void TestInitialize()
        {
            productFromFile = sales.ReadAllFromFile();
        }
        [TestMethod]
        public void TestLoadFileName()
        {

            List<Product> expected = new List<Product>();
            expected.Add(new Product
            {
                Name = "Кола",
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

            //проверка загрузки имени, цены и количества
            for (int i = 0; i < productFromFile.Count; i++)
            {
                Assert.AreEqual(expected[i].Name, productFromFile[i].Name);
                Assert.AreEqual(expected[i].Price, productFromFile[i].Price);
                Assert.AreEqual(expected[i].Count, productFromFile[i].Count);
            }

            Assert.AreEqual(expected.Count, productFromFile.Count);
        }

        [TestMethod]
        public void TestPrice()
        {

            List<Product> expected = new List<Product>();
            expected.Add(new Product
            {
                Name = "Кола",
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



        }
    }
}
