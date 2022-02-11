using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestingBasicPrograms;
using System;

namespace MSTestingProject
{
    [TestClass]
    public class TestingBasicCode
    {
        Program program = null;

        [TestInitialize]
        public void SetUp()
        {
            program = new Program();
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
