using Tyuiu.KorolkovDS.Sprint0.Task2.V0.Lib;


namespace Tyuiu.KorolkovDS.Sprint0.Task2.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Дмитрий";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Дмитрий", res);
        }
    }
}
