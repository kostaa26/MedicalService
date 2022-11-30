﻿using MedicalService.Driver;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalService.Page
{
    public class LogInPage
    {
        private IWebDriver driver = WebDrivers.Instance;

        public IWebElement AppMedic => driver.FindElement(By.Id("btn-make-appointment"));

        public IWebElement UserName => driver.FindElement(By.Id("txt-username"));

        public IWebElement Password => driver.FindElement(By.Id("txt-password"));

        public IWebElement ButtonLogin => driver.FindElement(By.Id("btn-login"));

        public IWebElement UserNotLogin => driver.FindElement(By.CssSelector(".text-danger"));
        public void Login(string user, string pass)
        {
            UserName.SendKeys(user);
            Password.SendKeys(pass);
            ButtonLogin.Submit();
        }

    }
}
