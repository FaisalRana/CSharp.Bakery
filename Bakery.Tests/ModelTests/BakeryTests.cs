using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System;
using System.Collections.Generic;


namespace Bakery.Tests
{
    [TestClass]
    public class BakeryTests
    {
        [TestMethod]
        public void BuyBread_CalculatePricefor1LoafofBread_5()
        {
            //Arrange
            Bread testBread = new Bread();
            //Act
            int result = testBread.BuyBread(1);
            //Assert
            Assert.AreEqual(5,result);
        }
    }
}