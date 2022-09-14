using LoginProject.Utilities;
using Microsoft.VisualStudio.TestPlatform.PlatformAbstractions.Interfaces;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Threading;


namespace LoginProject.Pages
{
    public class TMPage
    {
        public void CreateTM(IWebDriver driver)
        {
             // Create new Time record 
            //Identify Create new button and click
            IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            createNewButton.Click();

            //Identify TypeCode and select Time
            IWebElement typeCodeDropdown = driver.FindElement(By.XPath("//*[@id=\'TimeMaterialEditForm\']/div/div[1]/div/span[1]/span/span[1]"));
            typeCodeDropdown.Click();
            Thread.Sleep(3000);
            IWebElement timeOption = driver.FindElement(By.XPath("//*[@id=\'TypeCode_listbox\']/li[2]"));
            timeOption.Click();
            Thread.Sleep(3000);

            //Identify Code Textbox and enter value
            IWebElement codeButton = driver.FindElement(By.Id("Code"));
            codeButton.SendKeys("Neet2022");

            //Identigy Description Textbox and enter value
            IWebElement descriptionTextBox = driver.FindElement(By.Id("Description"));
            descriptionTextBox.SendKeys("Data");

            //Identify Price per unit and enter value
            IWebElement pricePerunitTag = driver.FindElement(By.XPath("//*[@id=\'TimeMaterialEditForm\']/div/div[4]/div/span[1]/span/input[1]"));
            pricePerunitTag.Click();

            IWebElement pricePerunitTextbox = driver.FindElement(By.Id("Price"));
            pricePerunitTextbox.SendKeys("7800");

            //Identify Save button and click
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
            Thread.Sleep(5000);

            //Got the the last page to Check if the new record is present in the table

            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id=\'tmsGrid\']/div[4]/a[4]/span"));
            goToLastPageButton.Click();
            Thread.Sleep(5000);
            
            IWebElement newCode = driver.FindElement(By.XPath("//*[@id=\'tmsGrid\']/div[3]/table/tbody/tr[last()]/td[1]"));
            Thread.Sleep(4000);

            //Assertion Second option
            Assert.That(newCode.Text== "Neet2022","actual and expected results donot match");

            //Assertion First option
            //if (newCode.Text == "Neet2022")
            //{
            //    Assert.Pass("Time record created sucessfully.");
            //}
            //else
            //{
            //    Assert.Fail("Time record hasn't been created.");
            //}

            //Create new Material record
            //Navigate to Time & Material page
            IWebElement administationTab = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            administationTab.Click();

            IWebElement TimeandmaterialTab = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            TimeandmaterialTab.Click();

            //Identify Create New Button and CLick
            IWebElement createnewButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            createnewButton.Click();

            //Identify CodeTextBox and Enter value
            IWebElement codeTextBox = driver.FindElement(By.Id("Code"));
            codeTextBox.SendKeys("Sept2022");

            //Identify Description TextBox and Enter value
            IWebElement descriptionBox = driver.FindElement(By.Id("Description"));
            descriptionBox.SendKeys("Auto123");

            //Identify PriceperUnitTextBox and Enter value
            IWebElement pricePerUnitTag = driver.FindElement(By.XPath("//*[@id=\'TimeMaterialEditForm\']/div/div[4]/div/span[1]/span/input[1]"));

            pricePerUnitTag.Click();
            IWebElement pricePUTextBox = driver.FindElement(By.Id("Price"));
            pricePUTextBox.SendKeys("$2,000.00");
            Thread.Sleep(2000);

            // Identify Save Button and click
            IWebElement saveButtonA = driver.FindElement(By.Id("SaveButton"));
            saveButtonA.Click();
            Thread.Sleep(2000);

            //Got to the last page and check if new Material data added to the table
            //Click on Go to the Last page pagination button
            IWebElement gototheLastPage = driver.FindElement(By.XPath("//*[@id=\'tmsGrid\']/div[4]/a[4]/span"));
            gototheLastPage.Click();
            Thread.Sleep(4000);

                            
        }

        public string GetCode(IWebDriver driver)
        {
            IWebElement newMCode1 = driver.FindElement(By.XPath("//*[@id=\'tmsGrid\']/div[3]/table/tbody/tr[last()]/td[1]"));
            return newMCode1.Text;
        }

        public string GetDescription(IWebDriver driver)
        {
            IWebElement newMDescription = driver.FindElement(By.XPath("//*[@id=\'tmsGrid\']/div[3]/table/tbody/tr[last()]/td[3]"));
            return newMDescription.Text;
        }

        public string GetPrice(IWebDriver driver)
        {
            IWebElement newMPrice = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[4]"));
            return newMPrice.Text;
        }



        public void EditTM(IWebDriver driver, string description, string code, string price)

        {

            //Got the the last page to Check if the new record is present in the table
            Thread.Sleep(5000);
            //WaitHelpers.WaitToExists(driver, "XPath", "//*[@id='tmsGrid']/div[3]/table/tbody/tr[1]/td[1]", 3);
            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            goToLastPageButton.Click();
            Thread.Sleep(2500);

            IWebElement findRecordCreated =driver.FindElement(By.XPath("//*[@id=\'tmsGrid\']/div[3]/table/tbody/tr[last()]/td[1]"));
            
            //Identify CodeTextBox and Edit Record
            Thread.Sleep(5000);
            IWebElement editcodeTextBox = driver.FindElement(By.Id("Code"));
            editcodeTextBox.Clear();
            editcodeTextBox.SendKeys(code);
            Thread.Sleep(2000);

            //Identify DescriptionTextBox and Edit value
            IWebElement descriptionEditTextBox = driver.FindElement(By.Id("Description"));
            descriptionEditTextBox.Clear();
            descriptionEditTextBox.SendKeys(description);
            Thread.Sleep(2000);

            //Identify PriceperunitEditTag
            IWebElement pricePerUnitEditTag = driver.FindElement(By.XPath("//*[@id=\'TimeMaterialEditForm\']/div/div[4]/div/span[1]/span/input[1]"));
            pricePerUnitEditTag.Click();
            Thread.Sleep(3000);

            //Identify PricePUTextBOX and Edit Value
            IWebElement priceEditTextBox = driver.FindElement(By.Id("Price"));
            priceEditTextBox.Clear();
            pricePerUnitEditTag .SendKeys(price);
            Thread.Sleep(3000);

            //Identify SaveButton and Click
            IWebElement saveEditButton = driver.FindElement(By.Id("SaveButton"));
            saveEditButton.Click();
            Thread.Sleep(4000);

            //Go to the last page
             IWebElement gototheLastPage = driver.FindElement(By.XPath("//*[@id=\'tmsGrid\']/div[4]/a[4]/span"));
             gototheLastPage.Click();
             Thread.Sleep(4000);

            //Check if the last record on the TimeMaterial page edited sucessfully
            //IWebElement editedCode = driver.FindElement(By.XPath("//*[@id=\'tmsGrid\']/div[3]/table/tbody/tr[last()]/td[1]"));
            //IWebElement editedDescription = driver.FindElement(By.XPath("//*[@id=\'tmsGrid\']/div[3]/table/tbody/tr[last()]/td[3]"));
            //IWebElement editedPrice = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[4]"));

           // Assert.That(editedCode.Text == "Manual", "actual code and expected code do not match.");
           //Assert.That(editedDescription.Text == "NewZealand", "actual description and expected description do not match.");
           // Assert.That(editedPrice.Text == "$1,000.00", "actual price and actual price do Not match.");
              
        }

        public string GetEditedDescription(IWebDriver driver)
        {
           IWebElement editedDescription = driver.FindElement(By.XPath("//*[@id=\'tmsGrid\']/div[3]/table/tbody/tr[last()]/td[3]"));
            return editedDescription.Text;

        }

        public string GetEditedCode(IWebDriver driver)
        {
            IWebElement editedCode = driver.FindElement(By.XPath("//*[@id=\'tmsGrid\']/div[3]/table/tbody/tr[last()]/td[1]"));
            return editedCode.Text;
        }

        public string GetEditedPrice(IWebDriver driver)
        {
            IWebElement editedPrice = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[4]"));
            return editedPrice.Text;
        }


        public void DeleteTM(IWebDriver driver)

        {
             Thread.Sleep(6000);
            // Go to the last page where edited record will be
            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            goToLastPageButton.Click();
            Thread.Sleep(2000);


            IWebElement findEditedRecord = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            

            if (findEditedRecord.Text == "Manual")
            { 
                //Click on the Delete Button
                IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id=\'tmsGrid\']/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
                deleteButton.Click();
                Thread.Sleep(5000);
                

                driver.SwitchTo().Alert().Accept();
            }

            else
            {
                Assert.Fail("Record to be deleted hasn't been found. Record not deleted.");
               
            }
           

            //Assert that Time record has been deleted.
            IWebElement goToLastPageButton1 = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            goToLastPageButton1.Click();
            Thread.Sleep(5000);

            IWebElement codeD = driver.FindElement(By.XPath("//*[@id=\'tmsGrid\']/div[3]/table/tbody/tr[last()]/td[1]"));
            IWebElement descriptionD = driver.FindElement(By.XPath("//*[@id=\'tmsGrid\']/div[3]/table/tbody/tr[last()]/td[3]"));
            IWebElement priceD = driver.FindElement(By.XPath("//*[@id=\'tmsGrid\']/div[3]/table/tbody/tr[last()]/td[4]"));
 
            //Assertion
            Assert.That(codeD.Text != "Manual", "Code record hasn't been deleted.");
            Assert.That(descriptionD.Text != "NewZealand", "Code record hasn't been deleted.");
            Assert.That(priceD.Text != "$1,000.00", "Code record hasn't been deleted.");

        }
    }
}
