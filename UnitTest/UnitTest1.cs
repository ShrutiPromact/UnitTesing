using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using UnitTestAssi;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestMethod1()
        {
            List<Product> plist = new List<Product>() {
                new Product("lettuce",  10.5, 50, "Leafy green"),
                new Product("cabbage",   20,   100,"Cruciferous"),
                new Product("pumpkin",   30,   30, "Marrow"),
                new Product("cauliflower",10, 25,"Cruciferous"),
                new Product("zucchini",  20.5, 50, "Marrow"),
                new Product("yam",      30,   50, "Root"),
                new Product("spinach",   10,  100,"Leafy green"),
                new Product("broccoli", 20.2, 75, "Cruciferous"),
                new Product("Garlic",   30, 20,"Leafy green"),
                new Product("silverbeet",10,50, "Marrow"),
            };
            ProductRepository pr = new ProductRepository(plist);
            int i = pr.TotalList(plist);
            Assert.AreEqual(10, i);
        }

        [TestMethod]
        public void TestMethod2()
        {
            List<Product> plist = new List<Product>() {
                new Product("lettuce",  10.5, 50, "Leafy green"),
                new Product("cabbage",   20,   100,"Cruciferous"),
                new Product("pumpkin",   30,   30, "Marrow"),
                new Product("cauliflower",10, 25,"Cruciferous"),
                new Product("zucchini",  20.5, 50, "Marrow"),
                new Product("yam",      30,   50, "Root"),
                new Product("spinach",   10,  100,"Leafy green"),
                new Product("broccoli", 20.2, 75, "Cruciferous"),
                new Product("Garlic",   30, 20,"Leafy green"),
                new Product("silverbeet",10,50, "Marrow"),
            };
            ProductRepository pr = new ProductRepository(plist);
            pr.addProduct(new Product("potato", 10.2, 25, "abc"));
            int i = pr.TotalList(plist);
            Assert.AreEqual(11, i);
        }

        [TestMethod]
        public void TestMethod3()
        {
            List<Product> plist = new List<Product>() {
                new Product("lettuce",  10.5, 50, "Leafy green"),
                new Product("cabbage",   20,   100,"Cruciferous"),
                new Product("pumpkin",   30,   30, "Marrow"),
                new Product("cauliflower",10, 25,"Cruciferous"),
                new Product("zucchini",  20.5, 50, "Marrow"),
                new Product("yam",      30,   50, "Root"),
                new Product("spinach",   10,  100,"Leafy green"),
                new Product("broccoli", 20.2, 75, "Cruciferous"),
                new Product("Garlic",   30, 20,"Leafy green"),
                new Product("silverbeet",10,50, "Marrow"),
            };
            ProductRepository pr = new ProductRepository(plist);
            pr.deleteProduct("zucchini");
            pr.deleteProduct("broccoli");
            int i = pr.TotalList(plist);
            Assert.AreEqual(8, i);
        }

        [TestMethod]
        public void TestMethod4()
        {
            List<Product> plist = new List<Product>() {
                new Product("lettuce",  10.5, 50, "Leafy green"),
                new Product("cabbage",   20,   100,"Cruciferous"),
                new Product("pumpkin",   30,   30, "Marrow"),
                new Product("cauliflower",10, 25,"Cruciferous"),
                new Product("zucchini",  20.5, 50, "Marrow"),
                new Product("yam",      30,   50, "Root"),
                new Product("spinach",   10,  100,"Leafy green"),
                new Product("broccoli", 20.2, 75, "Cruciferous"),
                new Product("Garlic",   30, 20,"Leafy green"),
                new Product("silverbeet",10,50, "Marrow"),
            };
            ProductRepository pr = new ProductRepository(plist);
            pr.addProduct(new Product("xyz", 10.2, 25, "XYZ"));
            int i = pr.TotalList(plist);
            Assert.AreEqual(11, i);
        }

        //c.ii.(2)
        [TestMethod]
        public void TestMethod5()
        {
            List<Product> plist = new List<Product>() {
                new Product("lettuce",  10.5, 50, "Leafy green"),
                new Product("cabbage",   20,   100,"Cruciferous"),
                new Product("pumpkin",   30,   30, "Marrow"),
                new Product("cauliflower",10, 25,"Cruciferous"),
                new Product("zucchini",  20.5, 50, "Marrow"),
                new Product("yam",      30,   50, "Root"),
                new Product("spinach",   10,  100,"Leafy green"),
                new Product("broccoli", 20.2, 75, "Cruciferous"),
                new Product("Garlic",   30, 20,"Leafy green"),
                new Product("silverbeet",10,50, "Marrow"),
            };
            ProductRepository pr = new ProductRepository(plist);
            pr.addProduct(new Product("abc", 10.2, 40, "def"));
      
            int find = plist.FindIndex(x => x.Name == "abc");
            Assert.AreEqual(find, 10);
        }

        //method 3 to find Cruciferous products, then test should assert returned product list length to be 3
        [TestMethod]
        public void TestMethod6()
        {
            List<Product> plist = new List<Product>() {
                new Product("lettuce",  10.5, 50, "Leafy green"),
                new Product("cabbage",   20,   100,"Cruciferous"),
                new Product("pumpkin",   30,   30, "Marrow"),
                new Product("cauliflower",10, 25,"Cruciferous"),
                new Product("zucchini",  20.5, 50, "Marrow"),
                new Product("yam",      30,   50, "Root"),
                new Product("spinach",   10,  100,"Leafy green"),
                new Product("broccoli", 20.2, 75, "Cruciferous"),
                new Product("Garlic",   30, 20,"Leafy green"),
                new Product("silverbeet",10,50, "Marrow"),
            };
            ProductRepository pr = new ProductRepository(plist);
            var f = pr.findProduct("Cruciferous");
            int i = f.Count;
            Assert.AreEqual(i, 3);
        }

        //Use method 3 to find Marrow products, then test should assert returned product list must only contain marrow product type
        [TestMethod]
        public void TestMethod7()
        {
            List<Product> plist = new List<Product>() {
                new Product("lettuce",  10.5, 50, "Leafy green"),
                new Product("cabbage",   20,   100,"Cruciferous"),
                new Product("pumpkin",   30,   30, "Marrow"),
                new Product("cauliflower",10, 25,"Cruciferous"),
                new Product("zucchini",  20.5, 50, "Marrow"),
                new Product("yam",      30,   50, "Root"),
                new Product("spinach",   10,  100,"Leafy green"),
                new Product("broccoli", 20.2, 75, "Cruciferous"),
                new Product("Garlic",   30, 20,"Leafy green"),
                new Product("silverbeet",10,50, "Marrow"),
            };
            ProductRepository pr = new ProductRepository(plist);
            var mrw = pr.findProduct("Marrow");
            int count = 0;

            foreach (var item in mrw)
            {
                if (item.Type == "Marrow")
                {
                    count++;
                }
            }
            Assert.AreEqual(3, count);
        }

        //Delete Method
        [TestMethod]
        public void TestMethod8()
        {
            List<Product> plist = new List<Product>() {
                new Product("lettuce",  10.5, 50, "Leafy green"),
                new Product("cabbage",   20,   100,"Cruciferous"),
                new Product("pumpkin",   30,   30, "Marrow"),
                new Product("cauliflower",10, 25,"Cruciferous"),
                new Product("zucchini",  20.5, 50, "Marrow"),
                new Product("yam",      30,   50, "Root"),
                new Product("spinach",   10,  100,"Leafy green"),
                new Product("broccoli", 20.2, 75, "Cruciferous"),
                new Product("Garlic",   30, 20,"Leafy green"),
                new Product("silverbeet",10,50, "Marrow"),
            };
            ProductRepository pr = new ProductRepository(plist);
            pr.deleteProduct("pumpkin");
            int i = pr.TotalList(plist);
            Assert.AreEqual(9, i);
        }

        [TestMethod]
        public void TestMethod9()
        {
            List<Product> plist = new List<Product>() {
                new Product("lettuce",  10.5, 50, "Leafy green"),
                new Product("cabbage",   20,   100,"Cruciferous"),
                new Product("pumpkin",   30,   30, "Marrow"),
                new Product("cauliflower",10, 25,"Cruciferous"),
                new Product("zucchini",  20.5, 50, "Marrow"),
                new Product("yam",      30,   50, "Root"),
                new Product("spinach",   10,  100,"Leafy green"),
                new Product("broccoli", 20.2, 75, "Cruciferous"),
                new Product("Garlic",   30, 20,"Leafy green"),
                new Product("silverbeet",10,50, "Marrow"),
            };
            ProductRepository pr = new ProductRepository(plist);
            var cbg = pr.deleteProduct("cabbage");
            bool i = false;

            foreach (var item in cbg)
            {
                if (item.Name == "cabbage")
                {
                    i = true;
                }
            }
            Assert.IsFalse(i);
        }

        //Use method 5 to buy grocery for making salad of your like, then test should assert total price to be x.
        [TestMethod]
        public void TestMethod10()
        {
            List<Product> plist = new List<Product>() {
                new Product("lettuce",  10.5, 50, "Leafy green"),
                new Product("cabbage",   20,   100,"Cruciferous"),
                new Product("pumpkin",   30,   30, "Marrow"),
                new Product("cauliflower",10, 25,"Cruciferous"),
                new Product("zucchini",  20.5, 50, "Marrow"),
                new Product("yam",      30,   50, "Root"),
                new Product("spinach",   10,  100,"Leafy green"),
                new Product("broccoli", 20.2, 75, "Cruciferous"),
                new Product("Garlic",   30, 20,"Leafy green"),
                new Product("silverbeet",10,50, "Marrow"),
            };
            ProductRepository pr = new ProductRepository(plist);
            double prc1 = pr.buyProduct("cabbage", 4);
            double prc2 = pr.buyProduct("lettuce", 3);
            double x = prc1 + prc2;

            Assert.AreEqual(x, 111.5);
        }
    }
}

