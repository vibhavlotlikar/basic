using Microsoft.VisualStudio.TestTools.UnitTesting;
using Factorial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void Factorial_recursionTest()
        {
            double result= Program.Factorial_recursion(4);
            Assert.AreEqual(24.0, result);
        }
    }
}