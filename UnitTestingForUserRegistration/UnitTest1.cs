using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UserRegistration;

namespace UnitTestingForUserRegistration
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow("tiru@gmail.com")]
        [DataRow("ktr.@")]
        [DataRow("tiru.co@gmail.com")]
        public void TestVariousEmailValidations(string email)
        {
            Program program = new Program(); 
            string expected = "valid";
            string result = program.validateEmail(email);
            Assert.AreEqual(expected, result);
        }
    }
}
