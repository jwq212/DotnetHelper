using Microsoft.VisualStudio.TestTools.UnitTesting;
using DotnetHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetHelper.Tests
{
    [TestClass()]
    public class ObjectExtTests
    {
        [TestMethod()]
        public void DeepCopyTest()
        {

            var a = new ABC();
            var b=a.DeepCopy<ABC>();
            a.A = "FFF";

            Assert.Fail();
        }
        public class ABC
        {
            public string A { get; set; } = string.Empty;
        }
    }
}