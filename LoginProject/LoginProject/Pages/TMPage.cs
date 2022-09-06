using LoginProject.Utilities;
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
            Thread.Sleep(3000);

            //Got the the last page to Check if the new record is present in the table

            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id=\'tmsGrid\']/div[4]/a[4]/span"));
            goToLastPageButton.Click();
            Thread.Sleep(3000);
            
            IWebElement newCode = driver.FindElement(By.XPath("//*[@id=\'tmsGrid\']/div[3]/table/tbody/tr[last()]/td[1]"));
            Thread.Sleep(3000);

            if (newCode.Text == "Neet2022")
            {
                Console.WriteLine("Time record created sucessfully");
            }
            else
            {
                Console.WriteLine("Time record hasn't been created");
            }

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
            pricePUTextBox.SendKeys("$2000.00");
            Thread.Sleep(2000);

            // Identify Save Button and click
            IWebElement saveButtonA = driver.FindElement(By.Id("SaveButton"));
            saveButtonA.Click();
            Thread.Sleep(2000);

            //Got to the last page and check if new Material data added to the table

            //Click on Go to the Last page pagination button
            IWebElement gototheLastPage = driver.FindElement(By.XPath("//*[@id=\'tmsGrid\']/div[4]/a[4]/span"));
            gototheLastPage.Click();
            Thread.Sleep(2000);

            IWebElement NewMaterialCode = driver.FindElement(By.XPath("//*[@id=\'tmsGrid\']/div[3]/table/tbody/tr[last()]/td[1]"));
            Thread.Sleep(2000);

            //Check if new Material record added to the last page

            if (NewMaterialCode.Text == "Sept2022")

            {
                Console.WriteLine("Material new record created sucessfully, test passed");

            }
            else
            {
                Console.WriteLine("Material record has not been added, test failed");
            }


        }

        public void EditTM(IWebDriver driver)

        {

            //Got the the last page to Check if the new record is present in the table

            
            Thread.Sleep(3000);
            IWebElement findRecordCreated =driver.FindElement(By.XPath("//*[@id=\'tmsGrid\']/div[3]/table/tbody/tr[last()]/td[1]"));
            

            if (findRecordCreated.Text== "Sept2022")
            {
                //Click on the Edit Button
                IWebElement EditButton = driver.FindElement(By.XPath("//*[@id=\'tmsGrid\']/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
                
                EditButton.Click();
                Thread.Sleep(2000);

            }
            else
            {
                Console.WriteLine("Record not found");
            }
            Thread.Sleep(3000);

            //Identify TypeCode and select Time
            IWebElement edittypeCodeDropdown = driver.FindElement(By.XPath("//*[@id=\'TimeMaterialEditForm\']/div/div[1]/div/span[1]/span/span[1]"));
            edittypeCodeDropdown.Click();
            Thread.Sleep(3000);

            IWebElement timeOption1 = driver.FindElement(By.XPath("//*[@id=\'TypeCode_listbox\']/li[2]"));
            timeOption1.Click();

            Thread.Sleep(3000);

            //Identify CodeTextBox and Edit Record
            Thread.Sleep(4000);
            IWebElement editcodeTextBox = driver.FindElement(By.Id("Code"));
            editcodeTextBox.Clear();
            editcodeTextBox.SendKeys("Manual");
            Thread.Sleep(2000);

            //Identify DescriptionTextBox and Edit value
            IWebElement descriptionEditTextBox = driver.FindElement(By.Id("Description"));
            descriptionEditTextBox.Clear();
            descriptionEditTextBox.SendKeys("NewZealand");
            Thread.Sleep(2000);

            //Identify PriceperunitEditTag
            IWebElement pricePerUnitEditTag = driver.FindElement(By.XPath("//*[@id=\'TimeMaterialEditForm\']/div/div[4]/div/span[1]/span/input[1]"));
            pricePerUnitEditTag.Click();
            Thread.Sleep(3000);

            //Identify PricePUTextBOX and Edit Value
            IWebElement priceEditTextBox = driver.FindElement(By.Id("Price"));
            priceEditTextBox.Clear();
            pricePerUnitEditTag .SendKeys("$1000.00");
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
            IWebElement editedCode = driver.FindElement(By.XPath("//*[@id=\'tmsGrid\']/div[3]/table/tbody/tr[last()]/td[1]"));
            IWebElement editedDescription = driver.FindElement(By.XPath("//*[@id=\'tmsGrid\']/div[3]/table/tbody/tr[last()]/td[3]"));
            //IWebElement editedPrice = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[4]"));

            if (editedCode.Text == "Manual" && editedDescription.Text == "NewZealand")


            {
                Console.WriteLine("Record Edited Sucessfully, Test Passed");
            }
            else

            {
                Console.WriteLine("Record has not been edited, Test failed");
            }


        }
        public void DeleteTM(IWebDriver driver)

        {
            // Go to the last page where edited record will be
            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            goToLastPageButton.Click();
            Thread.Sleep(2000);


            IWebElement findEditedRecord = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

            if (findEditedRecord.Text== "Manual")
            { 
                //Click on the Delete Button
                IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id=\'tmsGrid\']/div[3]/table/tbody/tr/td[last()]/a[2]"));
                deleteButton.Click();
                Thread.Sleep(5000);

                driver.SwitchTo().Alert().Accept();
                Console.WriteLine("Record has been  deleted");
            }

            else
            {
                Console.WriteLine("Record has not been deleted");
               // Assert.Fail("Record to be deleted hasn't been found. Record not deleted");
            }
           

            



        }
    }
}
