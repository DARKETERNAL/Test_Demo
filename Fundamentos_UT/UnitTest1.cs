using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fundamentos_Demo;

namespace Fundamentos_UT
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMultiplicarMatrices()
        {
            int[,] A = new int[,] { { 2, 0, 1 }, { 3, 0, 0 }, { 5, 1, 1 } };
            int[,] B = new int[,] { { 1, 0 }, { 1,2}, { 1, 1 } };
            int[,] C = new int[,] { { 3,1}, { 3, 0}, { 7, 3} };

            Program p = new Program();

            CollectionAssert.AreEqual(C, p.ProductoMatrices(A,B));
        }
    }
}
