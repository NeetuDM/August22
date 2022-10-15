using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Mars.Pages
{
    public class LoginPage
    {
        public void LoginSteps(IWebDriver driver)
        {
            driver.Manage().Window.Maximize();

            //Launch Mars URL portal
            driver.Navigate().GoToUrl("http://localhost:5000");
            Thread.Sleep(1000);

            try
            {

                //Identify the Sign In button and click
                IWebElement SignInButton = driver.FindElement(By.XPath("//*[@id=\'home\']/div/div/div[1]/div/a"));
                SignInButton.Click();
                Thread.Sleep(1000);
            }
             catch (Exception ex)
             {
                Assert.Fail("Mars Sign in Page did not launch", ex.Message);

            }
            
            //Identify the Email address Textbox and enter Email address
            IWebElement emailaddressTextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
            emailaddressTextbox.SendKeys("neetu.dhoundiyal.vuw@gmail.com");
            Thread.Sleep(1000);

            //Identify the Password Textbox and enter the Password
            IWebElement passwordTextbox = driver.FindElement(By.XPath("//div/div/div[1]/div/div[2]/input"));
            passwordTextbox.SendKeys("jaibhole@123");
            Thread.Sleep(1000);

            //Identify the Login Button and click
            IWebElement loginButton = driver.FindElement(By.XPath("//div/div/div[1]/div/div[4]/button"));
            loginButton.Click();
            Thread.Sleep(2000);

         
        }

    }
}
