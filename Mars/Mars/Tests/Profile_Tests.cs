using Mars.Pages;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Mars.Utilities;

namespace Mars.Tests
{
    [TestFixture]
    public class Profile_Tests : CommonDriver
    {
       

        [Test, Order(1), Description ("Check if seller is able to go to Profile Page")]
        public void GoToProfilePage()
        {
            //Profile page initilalization and initialization
            ProfilePage profilePageObj = new ProfilePage();
            profilePageObj.GotoProfilePage(driver);


        }

        [Test, Order(2), Description("Check if seller is able to create availability")]
        public void CreateAvailabilty()

        {
            
            //Profile page initilalization and initialization
            ProfilePage profilePageObj = new ProfilePage();
            profilePageObj.CreateAvailabilty(driver);

        }

        [Test, Order(3), Description ("Check if seller is able to create Languages")]
        public void CreateLanguages()

        {
            //Profile page initilalization and initialization
            ProfilePage profilePageObj = new ProfilePage();
            profilePageObj.CreateLanguage(driver);

        }

        [Test, Order(4), Description ("Check if seller is able to edit Languages")]
        public void EditLanguages()
        {
            //Profile page initilalization and initialization
            ProfilePage profilePageObj = new ProfilePage();
            profilePageObj.EditLanguage(driver);

        }

        [Test, Order(5), Description("Check if seller is able to delete Languages")]
        public void DeleteLanguages()
        {
            //Profile page initilalization and initialization
            ProfilePage profilePageObj = new ProfilePage();
            profilePageObj.DeleteLanguage(driver);

        }

        [Test, Order(6), Description("Check if seller is able to create Skills")]
        public void CreateSkills()
        {
            //Profile page initilalization and initialization
            ProfilePage profilePageObj = new ProfilePage();
            profilePageObj.CreateSkills(driver);

        }
        [Test, Order(7), Description("Check if seller is able to edit Skills")]
        public void EditSkills()
        {
            //Profile page initilalization and initialization
            ProfilePage profilePageObj = new ProfilePage();
            profilePageObj.EditSkills(driver);

        }

        [Test, Order(8), Description("Check if seller is able to delete Skills")]
        public void DeleteSkills()
        {
            //Profile page initilalization and initialization
            ProfilePage profilePageObj = new ProfilePage();
            profilePageObj.DeleteSkills(driver);

        }

        



    }
}
