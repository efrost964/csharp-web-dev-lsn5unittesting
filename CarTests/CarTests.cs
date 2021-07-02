using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarNS;

namespace CarTests
{
    [TestClass]
    public class CarTests
    {
        Car test_car;
        [TestInitialize]
        public void CreatCarObject()
        {
            test_car = new Car("Toyota", "Prius", 10, 50);
        }
        //[TestMethod]
        //public void EmptyTest()
        //{
        //    Assert.AreEqual(10, 10, .001);
        //    Assert.AreEqual(10, 11, .001);
        //    Assert.AreEqual(10, 10.0009, .001);
        //}
        //TODO: add emptyTest so we can configure our runtime environment (remove this test before pushing to your personal GitHub account)
        [TestMethod]
        public void GasTankLevelSet()
        {
            Assert.AreEqual(10, test_car.GasTankLevel, 1);
        }
        //TODO: constructor sets gasTankLevel properly
        [TestMethod]
        public void TestGasTankAfterDriving()
        {
            test_car.Drive(50);
            Assert.AreEqual(9, test_car.GasTankLevel, 1);
        }
        //TODO: gasTankLevel is accurate after driving within tank range
        [TestMethod]
        public void TestGasTankAfterExcedeingTankRange()
        {
            test_car.Drive(501);
            Assert.AreEqual(0, test_car.GasTankLevel, 1);
        }
        //TODO: gasTankLevel is accurate after attempting to drive past tank range
        [TestMethod]
        [ExpectedException(typeof(System.ArgumentOutOfRangeException))]
        public void TestGasOverfillException()
        {
            test_car.AddGas(11);
            Assert.Fail("Shouldn't get here, car cannot have more gas in tank than the size of the tank");
        }
        //TODO: can't have more gas than tank size, expect an exception

    }
}
