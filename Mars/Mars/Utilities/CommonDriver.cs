using Mars.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars.Utilities
{
    public class CommonDriver
    {
      public IWebDriver driver;
        [SetUp]
        public void LoginActions()
        {
            //open the Chrome Browser
            driver = new ChromeDriver();

            //Login page initialization and definition
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginSteps(driver);
           

        }

        [TearDown]
        public void CloseTestRun()
        {

            driver.Quit();
        }

    }
}
