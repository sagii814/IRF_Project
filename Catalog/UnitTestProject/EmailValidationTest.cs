using Catalog;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject
{
    public class EmailValidationTest
    {
        [Test,
         TestCase("xyz111", false),
         TestCase("hello@gmail", false),
         TestCase("hellogmail", false),
         TestCase("hello@gmail.com", true)]

        public void TestValidateEmail(string email, bool expectedResult)
        {
            // Arrange
            //var accountController = new AccountController();
            var form1 = new Form1();

            // Act
            var actualResult = form1.ValidateEmail(email);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

    }
}
