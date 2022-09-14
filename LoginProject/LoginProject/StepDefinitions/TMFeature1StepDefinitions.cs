using LoginProject.Pages;
using LoginProject.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace LoginProject.StepDefinitions
{
    [Binding]
    public class TMFeature1StepDefinitions : CommonDriver
    {
        LoginPage loginPageObj = new LoginPage();
        HomePage homePageObj = new HomePage();
        TMPage tmPageObj = new TMPage();

        [Given(@"I logged into turn up portal successfully")]
        public void GivenILoggedIntoTurnUpPortalSuccessfully()
        {
            driver = new ChromeDriver();
            
            loginPageObj.LoginSteps(driver);

        }

        [When(@"I navigate to the time and material page")]
        public void WhenINavigateToTheTimeAndMaterialPage()
        {
            
            homePageObj.GoToTMPage(driver);

        }

        [When(@"I create a new time and material record")]
        public void WhenICreateANewTimeAndMaterialRecord()
        {
           
            tmPageObj.CreateTM(driver);

        }

        [Then(@"The record should be create successfully")]
        public void ThenTheRecordShouldBeCreateSuccessfully()
        {
            string newMCode1 = tmPageObj.GetCode(driver);
            string newMDescription = tmPageObj.GetDescription(driver);
            string newMPrice = tmPageObj.GetPrice(driver);

            Assert.That(newMCode1 == "Sept2022", "Actual code and expected code do not match.");
            Assert.That(newMDescription == "Auto123", "Actual code and expected code do not match.");
            Assert.That(newMPrice == "$2,000.00", "Actual code and expected code do not match.");
      
        }

        
        [When(@"I update '([^']*)', '([^']*)' and '([^']*)' on an existing time and material record")]
        public void WhenIUpdateAndOnAnExistingTimeAndMaterialRecord(string description, string code, string price)
        {
            tmPageObj.EditTM(driver, description, code, price);
        }

        [Then(@"The record should have the updated '([^']*)', '([^']*)' and '([^']*)'")]
        public void ThenTheRecordShouldHaveTheUpdatedAnd(string description, string code, string price)
        {
            string editedDescription = tmPageObj.GetEditedCode(driver);
            string editedCode = tmPageObj.GetEditedCode(driver);
            string editedPrice = tmPageObj.GetEditedPrice(driver);

            //Assertion
            Assert.That(editedDescription == description, "actual description and expected description do not match.");
            Assert.That(editedCode == code, "actual code and expected code do not match.");
            Assert.That(editedPrice == price, "actual price and actual price do Not match.");

        }

    }
}
