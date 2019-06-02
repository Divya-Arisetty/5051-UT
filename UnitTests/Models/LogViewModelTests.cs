using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HW1c.Models;

namespace UnitTests.Models
{
    [TestClass]
    public class LogViewModelTests
    {
        [TestMethod]
        public void LogViewModel_Instantiate_Default_Should_Pass()
        {
            // Arrange
            // envoking the constructor will cover 60 % of the code, so no arrange is needed

             // Act
             var result = new LogViewModel();

            // Assert
            Assert.IsNotNull(result);


        }
    }
}
