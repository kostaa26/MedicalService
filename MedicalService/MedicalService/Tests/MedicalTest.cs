using MedicalService.Driver;
using MedicalService.Page;
using System.Security.Cryptography.X509Certificates;

namespace MedicalService.Tests
{
    public class Tests
    {
        LogInPage logInPage;
        MedicalPage medicalPage;
        [SetUp]
        public void Setup()
        {
            WebDrivers.Initialize();
            logInPage = new LogInPage();
            medicalPage = new MedicalPage();
        }
        [TearDown]
        public void Close()
        {
            WebDrivers.CleanUp();

        }

        [Test]
        public void TC01_MakeAppointment_ShouldBeCompleted()
        {
            logInPage.AppMedic.Click();
            logInPage.Login("John Doe", "ThisIsNotAPassword");

            medicalPage.SelectOption("Hongkong CURA Healthcare Center");
            medicalPage.CheckBox.Click();
            medicalPage.MedicId.Click();
            medicalPage.Date.SendKeys("25/12/2022");
            medicalPage.Comment.SendKeys("Gotovo");
            medicalPage.ButtonApp.Submit();



            Assert.That("Appointment Confirmation", Is.EqualTo(medicalPage.Confirm.Text));

        }
    }
}