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
        public void CalcPastry_CalculatePricefor3PastrysWithDiscount_5()
        {
            //Arrange
            Pastry testPastery = new Pastry();
            //Act
            int result = testPastery.CalcPastry(3);
            //Assert
            Assert.AreEqual(5,result);
        }
        [TestMethod]
        public void CalcPastry_CalculatePricefor4PastrysWithDiscount_5()
        {
            //Arrange
            Pastry testPastery = new Pastry();
            //Act
            int result = testPastery.CalcPastry(4);
            //Assert
            Assert.AreEqual(7,result);
        }
                [TestMethod]
        public void CalcPastry_CalculatePricefor5PastrysWithDiscount_9()
        {
            //Arrange
            Pastry testPastery = new Pastry();
            //Act
            int result = testPastery.CalcPastry(5);
            //Assert
            Assert.AreEqual(9,result);
        }
    }
}
