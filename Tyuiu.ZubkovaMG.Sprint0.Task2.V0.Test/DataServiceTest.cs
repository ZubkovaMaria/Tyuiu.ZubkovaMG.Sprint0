using Tyuiu.ZubkovaMG.Sprint0.Task2.V0.Lib;

namespace Tyuiu.ZubkovaMG.Sprint0.Task2.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Мария";
            var res = DataService.GetMessage(name);
            Assert.AreEqual("Привет, Мария", res);
        }
    }
}
