using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Diagnostics;

//open chrome browser
IWebDriver driver = new ChromeDriver();
driver.Manage().Window.Maximize();

//launch turnup portal
driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

//identify username textbox and enter valid username
IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
usernameTextbox.SendKeys("hari");

//identify password textbox and enter valid password
IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
passwordTextbox.SendKeys("123123");

//identify login button and click on it
IWebElement LoginButton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
LoginButton.Click();

// check if user has logged in sucessfully
IWebElement Hellohari = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));

if (Hellohari.Text == "Hello hari!")

{
    Console.WriteLine("Logged in sucessfully, test passed.");
}
else
{
    Console.WriteLine("Login failed,test failed.");

}
// Create new Time record 

//Identify Administration dropdown menu and click
IWebElement AdministrationTab = driver.FindElement(By.XPath("/ html / body / div[3] / div / div / ul / li[5] / a"));
AdministrationTab.Click();
IWebElement TimeandMaterialoption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
TimeandMaterialoption.Click();

//Identify Create new button and click
IWebElement CreateNewButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
CreateNewButton.Click();

//Identify TypeCode and select Time
IWebElement TypeCodeDropdown = driver.FindElement(By.XPath("//*[@id=\'TimeMaterialEditForm\']/div/div[1]/div/span[1]/span/span[1]"));
TypeCodeDropdown.Click();

//Identify Code Textbox and enter value
IWebElement CodeButton = driver.FindElement(By.Id("Code"));
CodeButton.SendKeys("Neet2022");

//Identigy Description Textbox and enter value
IWebElement DescriptionTextBox = driver.FindElement(By.Id("Description"));
DescriptionTextBox.SendKeys("Data");

//Identify Price per unit and enter value
IWebElement PriceperunitTag = driver.FindElement(By.XPath("//*[@id=\'TimeMaterialEditForm\']/div/div[4]/div/span[1]/span/input[1]"));
PriceperunitTag.Click();

IWebElement PriceperunitTextbox = driver.FindElement(By.Id("Price"));
PriceperunitTextbox.SendKeys("78");

//Identify Save button and click

IWebElement SaveButton = driver.FindElement(By.Id("SaveButton"));
SaveButton.Click();
Thread.Sleep(3000);

//Check if the new record is present in the table

IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id=\'tmsGrid\']/div[4]/a[4]/span"));
goToLastPageButton.Click();

IWebElement newCode = driver.FindElement(By.XPath("//*[@id=\'tmsGrid\']/div[3]/table/tbody/tr[last()]/td[1]"));

if (newCode.Text == "Neet2022")
{
   Console.WriteLine("Time record created sucessfully");
}
else
{
   Console.WriteLine("Time record hasn't been created");
}

