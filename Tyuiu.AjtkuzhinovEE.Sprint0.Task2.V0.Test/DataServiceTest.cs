using Tyuiu.AjtkuzhinovEE.Sprint0.Task2.V0.Lib;
namespace Tyuiu.AjtkuzhinovEE.Sprint0.Task2.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            // Область создание методов тестирования,методов из библиотеки
            var name = "Елжас";
            var res = DataService.GetMessage(name);

            //Вызываем класс Asser и метод AreEqual
            Assert.AreEqual("Привет..., Елжас", res);
        }
    }
}
