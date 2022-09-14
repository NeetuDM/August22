using LoginProject.Pages;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using NUnit.Framework;
using LoginProject.Utilities;
using static System.Net.Mime.MediaTypeNames;

namespace LoginProject.Tests
{
    [TestFixture]
    [Parallelizable]
    public class TM_Tests : CommonDriver
    {
        
        HomePage homePageObj = new HomePage();
        TMPage tmPageObj = new TMPage();

        [Test, Order(1), Description ("Check if user is able to create TM record with valid credentials")] 
        public void CreateTMTest()
        {
            
            homePageObj.GoToTMPage(driver);

           // TM page object initialization and definition

            tmPageObj.CreateTM(driver);
        }

        [Test, Order(2), Description("Check if user is able to edit existing TM record")]
        public void EditTMTest()
        {
            homePageObj.GoToTMPage(driver);

            //Edit TM
           //tmPageObj.EditTM(driver);
        }

        [Test, Order(3), Description("Check if user is able to delete existing TM record")]
        public void DeleteTMTest()
        {
             homePageObj.GoToTMPage(driver);

            //Delete TM
             tmPageObj.DeleteTM(driver);
        }
    }
}