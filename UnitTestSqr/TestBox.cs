﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using SqrLib;

namespace UnitTestSqr
{
    [TestClass]
    public class TestBox
    {
        /// <summary>
        /// Возвращат число
        /// </summary>
        [TestMethod]
        public void TestNotNullTriangle()
        {
            Square s = new Square();

            Assert.IsNotNull(s.GetArea(2, 2, 2,2));
        }

        /// <summary>
        ///  /// проверка на верность подчета
        /// </summary>
        [TestMethod]
        public void TestCurentResultTriangle()
        {
            Square s = new Square();
            var res = s.GetArea(2, 2, 2, 2);
            Assert.AreEqual(4, res);
        }

    }
}
