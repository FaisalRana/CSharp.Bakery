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
        public void CalcBread_CalculatePricefor1LoafofBread_5()
        {
            //Arrange
            Bread testBread = new Bread();
            //Act
            int result = testBread.CalcBread(1);
            //Assert
            Assert.AreEqual(5,result);
        }
            public void CalcBread_CalculatePricefor2LoafofBread_10()
        {
            //Arrange
            Bread testBread = new Bread();
            //Act
            int result = testBread.CalcBread(2);
            //Assert
            Assert.AreEqual(10,result);
        }
    }
}