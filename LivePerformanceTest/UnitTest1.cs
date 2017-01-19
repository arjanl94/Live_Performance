using System;
using System.Collections.Generic;
using LivePerformance;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LivePerformanceTest
{
    [TestClass]
    public class UnitTest1
    {
        private Klant klant;
        private Pizza pizza;
        private Product product;
        private Manager manager;

        [TestInitialize]
        [TestMethod]
        public void Test()
        {
            klant = new Klant("Test", "Testadres");
            pizza = new Pizza("Testpizza", Vorm.Rond, "0", true, new List<Ingrediënt>());
            product = new Product();
            manager = new Manager("Manager", "qwerty");
        }

        [TestMethod]
        public void TestKlant()
        {
            Assert.AreEqual("Test", klant.Naam);
            Assert.AreEqual("Testadres", klant.Adres);
        }

        [TestMethod]
        public void TestPizza()
        {
            Assert.AreEqual("Testpizza", pizza.Naam);
            Assert.AreEqual(Vorm.Rond, pizza.Vorm);
            Assert.AreEqual("0", pizza.Formaat);
            Assert.AreEqual(true, pizza.Standaard);
            Assert.IsNotNull(pizza.Ingrediënten);
        }

        [TestMethod]
        public void TestBerekeningPizza()
        {
            Assert.AreEqual(0, pizza.Oppervlakte);
        }

        [TestMethod]
        public void TestManagger()
        {
            Assert.AreEqual("Manager", manager.Naam);
            Assert.AreEqual("qwerty", manager.Wachtwoord);
        }

        [TestMethod]
        public void TestProduct()
        {
            Assert.IsNotNull(product);
        }
    }
}
