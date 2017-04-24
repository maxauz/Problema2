using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testeo
{
    [TestClass]
    public class testear
    {
        [TestMethod]
        public void TestMethod1()
        {
            const string input = "[2,1,4,5]";
            const string output = "[1,2,3,4,5]";

            string resultado = Consola.CompleteRange.build(input);

            Assert.AreEqual(resultado, output);
        }
        [TestMethod]
        public void TestMethod2()
        {
            const string input = "[4,2,9]";
            const string output = "[1,2,3,4,5,6,7,8,9]";

            string resultado = Consola.CompleteRange.build(input);

            Assert.AreEqual(resultado, output);
        }
    }
}
