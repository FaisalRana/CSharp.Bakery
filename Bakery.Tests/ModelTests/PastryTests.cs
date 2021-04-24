using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;


namespace Bakery.Tests
{
  [TestClass]
        public class PastryTests
    { [TestMethod]
        public void CalcPastry_CalculatePricefor1Pastry_2()
        {
            //Arrange
            Pastry testPastery = new Pastry();
            //Act
            int result = testPastery.CalcPastry(1);
            //Assert
            Assert.AreEqual(2,result);
        }
        [TestMethod]
        public void CalcBread_CalculatePricefor3PastryWithDiscount_5()
        {
            //Arrange
            Pastry testPastery = new Pastry();
            //Act
            int result = testPastery.CalcPastry(3);
            //Assert
            Assert.AreEqual(5,result);
        }
    }
}
