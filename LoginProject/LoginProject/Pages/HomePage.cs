using LoginProject.Utilities;
using OpenQA.Selenium;


namespace LoginProject.Pages
{
    public class HomePage
    {
        public void GoToTMPage(IWebDriver driver)

        {
            //Navigate to Time & Material page
            //Identify Administration dropdown menu and click
            IWebElement AdministrationTab = driver.FindElement(By.XPath("/ html / body / div[3] / div / div / ul / li[5] / a"));
            AdministrationTab.Click();
            WaitHelpers.WaitToBeClickable(driver, "XPath", "/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a", 3);
            IWebElement TimeandMaterialoption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            TimeandMaterialoption.Click();

        }


    }
}
