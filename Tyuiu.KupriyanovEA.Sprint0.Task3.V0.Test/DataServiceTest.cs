﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KupriyanovEA.Sprint0.Task3.V0.Lib;

namespace Tyuiu.KupriyanovEA.Sprint0.Task3.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedValid()
        {
            Assert.AreEqual(10, DataService.Sum(5, 5));
            Assert.AreEqual(30, DataService.Min(15, 5));
        }
    }
}
