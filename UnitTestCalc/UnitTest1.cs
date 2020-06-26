using CalcLibrary;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTestCalc
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
        public void CalculateTestMethod()
        {
            String[] a = Calc.GetOperands("23+4,5");
            Assert.AreEqual("23", a[0]);
            Assert.AreEqual("4,5", a[1]);
        }
        [TestMethod]
        public void GetOperationTestMethod()
        {
            String a = Calc.GetOperation("23+4,5");
            Assert.AreEqual("+", a[0].ToString());
        }
        [TestMethod]
        public void ResultTestMethod()
        {
            Assert.AreEqual("27,5", Calc.DoubleOperation["+"](23, 4.5).ToString());
            string result = Calc.DoOperation("23+4,5");
            Assert.AreEqual("27,5", result);
        }

    }
}
