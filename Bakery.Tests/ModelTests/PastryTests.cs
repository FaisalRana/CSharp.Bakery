using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;


namespace Bakery.Tests
{
  [TestClass]
        public class PastryTests
    { [TestMethod]
        public void CalcBread_CalculatePricefor1Pastry_2()
        {
            //Arrange
            Pastry testPastery = new Pastry();
            //Act
            int result = testPastery.CalcPastery(1);
            //Assert
            Assert.AreEqual(2,result);
        }
        // [TestMethod]
        // public void CalcBread_CalculatePricefor1Pastry_5()
        // {
        //     //Arrange
        //     Pastry testPastery = new Pastry();
        //     //Act
        //     int result = testPastery.CalcPastery(1);
        //     //Assert
        //     Assert.AreEqual(2,result);
        // }
    }
}
