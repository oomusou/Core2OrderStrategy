using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OrderLibrary.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void 當價錢為1200送百後為1100()
        {
            // Arrange
            var target = new OrderService();
            
            // Act
            var actual = target.GetPrice(1200);

            // Assert
            var expected = 1100;
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void 當價錢為800送百後為640()
        {
            // Arrange
            var target = new OrderService();
            
            // Act
            var actual = target.GetPrice(800);

            // Assert
            var expected = 640;
            Assert.AreEqual(expected, actual);
        }
    }
}