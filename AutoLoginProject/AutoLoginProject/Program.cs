
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

//Open chrome browser
IWebDriver driver = new ChromeDriver();
driver.Manage().Window.Maximize();

//Lauch TurnUp portal
driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

//identify username textbox and enter valid username
IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
usernameTextbox.SendKeys("hari");

//identify password textbox and enter valid password
IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
passwordTextbox.SendKeys("123123");

//identify login button and click on it
IWebElement loginButton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
loginButton.Click();

//check if user has logged in sucessfully
IWebElement helloHari = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));

if (helloHari.Text == "Hello hari!")
{
    Console.WriteLine("logedd in sucessfully, test passed.");
}
else
{
    Console.WriteLine("Login failed, test failed.");
}