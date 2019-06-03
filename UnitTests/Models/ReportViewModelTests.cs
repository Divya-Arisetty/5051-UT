using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using HW1c.Models;

namespace UnitTests.Models
{
    [TestClass]
    public class ReportViewModelTests
    {
        
       [TestMethod]
        public void ReportViewModel_Instantiate_Default_Should_Pass()
        {
          // Arrange
          // envoking the constructor will cover 60 % of the code, so no arrange is needed

         // Act
          var result = new ReportViewModel();

          // Assert
           Assert.IsNotNull(result);
      }
        [TestMethod]
        public void ReportViewModel_NumberOfUsers_Get_Default_Should_Pass()
       {
        // Arrange
              var myTest = new ReportViewModel();
        // Act
            var result = myTest.LogViewModel;
             var resultUsers = myTest.NumberOfUsers;

        // Assert
            Assert.IsNotNull(result);
            Assert.IsNotNull(resultUsers);
        }
       [TestMethod]
        public void ReportViewModel_NumberOfUsers_Set_Default_Should_Pass()
        {
            // Arrange
            var testReportViewModel = new ReportViewModel();
            //Act
            testReportViewModel.NumberOfUsers = 5;
            var resultNumberOfUsers = testReportViewModel.NumberOfUsers;
            // Assert
            Assert.AreEqual(5, resultNumberOfUsers);

        }

       [TestMethod]
        public void ReportViewModel_LogViewModel_Get_Default_Should_Pass()
        {
           // Arrange
            var myTest = new ReportViewModel();
            // Act
            var result = myTest.LogViewModel;
            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ReportViewModel_LogViewModel_Set_Default_Should_Pass()
        {
          // Arrange
              var testLogModel = new LogModel { PhoneID = "Phone" };
              var myListTestLogModel = new List<LogModel>();
              myListTestLogModel.Add(testLogModel);

              var testLogViewModel = new LogViewModel();
              testLogViewModel.LogList = myListTestLogModel;

              var testReportViewModel = new ReportViewModel();
            // Act
            testReportViewModel.LogViewModel = testLogViewModel;
            var result = testReportViewModel.LogViewModel.LogList;


            // Assert
            Assert.AreEqual("Phone", result[0].PhoneID);
        }

    }
}
