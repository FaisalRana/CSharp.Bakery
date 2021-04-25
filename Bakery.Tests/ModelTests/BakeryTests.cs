using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;


namespace Bakery.Tests
{
    [TestClass]
    public class BreadTests
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
        [TestMethod]
        public void CalcBread_CalculatePricefor2LoafofBread_10()
        {
            //Arrange
            Bread testBread = new Bread();
            //Act
            int result = testBread.CalcBread(2);
            //Assert
            Assert.AreEqual(10,result);
        }
        [TestMethod]
        public void CalcBread_Buy3LoavesForPriceof2_10()
        {
            //Arrange
            Bread testBread = new Bread();
            //Act
            int result = testBread.CalcBread(3);
            //Assert
            Assert.AreEqual(10,result);
        }
          [TestMethod]
        public void CalcBread_Buy10LoavesWithDiscount_35()
        {
            //Arrange
            Bread testBread = new Bread();
            //Act
            int result = testBread.CalcBread(10);
            //Assert
            Assert.AreEqual(35,result);
        }
          [TestMethod]
         public void CalcBread_Buy11LoavesWithDiscount_40()
        {
            //Arrange
            Bread testBread = new Bread();
            //Act
            int result = testBread.CalcBread(11);
            //Assert
            Assert.AreEqual(40,result);
        }
                  [TestMethod]
         public void CalcBread_EnterNegativeInt_error()
        {
            //Arrange
            Bread testBread = new Bread();
            //Act
            int result = testBread.CalcBread(-11);
            //Assert
            Assert.AreEqual(40,result);
        }
    }
}
