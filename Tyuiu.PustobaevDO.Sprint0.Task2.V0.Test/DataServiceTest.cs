using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PustobaevDO.Sprint0.Task2.V0.Lib;


namespace Tyuiu.PustobaevDO.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiseTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            //область создания методов тестирования, методов из библиотеки
            var name = "Дмитрий";
            var res = DataService.GetMessage(name);

            //вызываем класс Assert и метод AreEqual
            Assert.AreEqual("Привет..., Дмитрий", res);
        }
    }
}
