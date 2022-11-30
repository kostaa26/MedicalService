using MedicalService.Driver;
using MedicalService.Page;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MedicalService.Tests
{public class LoginTests
    {
       
        LogInPage logInPage;
        string Message = "Login failed! Please ensure the username and password are valid.";
        [SetUp]
        public void Setup()
        {
            WebDrivers.Initialize();
            logInPage = new LogInPage();

        }
        [TearDown]
        public void Close()
        {
            WebDrivers.CleanUp();

        }
        [Test]
        public void TC01_EnterInvalidUserNAme_ShouldNotBeLoginOnPage()
        {
            logInPage.AppMedic.Click();
            logInPage.Login("Kosta", "ThisIsNotAPassword");

            Assert.That(Message,Is.EqualTo(logInPage.UserNotLogin.Text));
        }
        [Test]
        public void TC02_EnterInvalidPassword_ShouldNotBeLoginOnPage()
        {
            logInPage.AppMedic.Click();
            logInPage.Login("Kosta", "ThisIsNotARealPassword");

            Assert.That(Message, Is.EqualTo(logInPage.UserNotLogin.Text));
        }
        [Test]
        public void TC03_EnterNoData_ShouldNotBeLoginOnPage()
        {
            logInPage.AppMedic.Click();
            logInPage.Login("", "");

            Assert.That(Message, Is.EqualTo(logInPage.UserNotLogin.Text));
        }


    }
   
}
