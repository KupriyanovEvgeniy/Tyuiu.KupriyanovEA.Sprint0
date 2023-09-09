using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KupriyanovEA.Sprint0.Task2.V0.Lib;

namespace Tyuiu.KupriyanovEA.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            // Область создания методов тестирования, методов из библиотеки
            var name = "Евгений";
            var res = DataService.GetMessage(name);

            // Вызываем класс Asert и метод AreEqual
            Assert.AreEqual("Привет, Евгений", res);
        }
    }
}
