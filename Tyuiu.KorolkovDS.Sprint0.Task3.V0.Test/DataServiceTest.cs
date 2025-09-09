using Tyuiu.KorolkovDS.Sprint0.Task3.V0.Lib;

namespace Tyuiu.KorolkovDS.Sprint0.Task3.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ChekedValid()
        {
            Assert.AreEqual(10, DataService.Sum(5, 5));
        }
    }
}
