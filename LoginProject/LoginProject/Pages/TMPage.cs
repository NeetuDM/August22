using OpenQA.Selenium;


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
            pricePerunitTextbox.SendKeys("78");

            //Identify Save button and click

            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
            Thread.Sleep(3000);

            //Got the the last page to Check if the new record is present in the table

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
            codeTextBox.SendKeys("Sept");

            //Identify Description TextBox and Enter value
            IWebElement descriptionBox = driver.FindElement(By.Id("Description"));
            descriptionBox.SendKeys("Auto123");

            //Identify PriceperUnitTextBox and Enter value
            IWebElement pricePerUnitTag = driver.FindElement(By.XPath("//*[@id=\'TimeMaterialEditForm\']/div/div[4]/div/span[1]/span/input[1]"));

            pricePerUnitTag.Click();
            IWebElement pricePUTextBox = driver.FindElement(By.Id("Price"));
            pricePUTextBox.SendKeys("200");
            Thread.Sleep(2000);

            // Identify Save Button and click
            IWebElement saveButtonA = driver.FindElement(By.Id("SaveButton"));
            saveButtonA.Click();
            Thread.Sleep(2000);

            //Got to the last page and check if new Material data added to the table

            //Click on Go to the Last page pagination button
            IWebElement gototheLastPage = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            gototheLastPage.Click();

            IWebElement NewRecord = driver.FindElement(By.XPath("//*[@id=\'tmsGrid\']/div[3]/table/tbody/tr[last()]/td[1]"));

            //Check if new Material record added to the last page

            if (NewRecord.Text == "Sept")

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
            //Edit T&M (First record)
            //Click on the Gotothe First page and Identify Edit button and Click
            IWebElement GototheFirstPage = driver.FindElement(By.XPath("//*[@id=\'tmsGrid\']/div[4]/a[1]/span"));
            GototheFirstPage.Click();
            IWebElement EditButton = driver.FindElement(By.XPath("//*[@id=\'tmsGrid\']/div[3]/table/tbody/tr[1]/td[5]/a[1]"));
            EditButton.Click();

            //Identify CodeTextBox and Edit Record
            IWebElement codeEditTextBox = driver.FindElement(By.Id("Code"));
            codeEditTextBox.Clear();
            codeEditTextBox.SendKeys("Manual");
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
            //priceEditTextBox.SendKeys("1000");
            Thread.Sleep(3000);

            //Identify SaveButton and Click
            IWebElement saveEditButton = driver.FindElement(By.Id("SaveButton"));
            saveEditButton.Click();
            Thread.Sleep(4000);

            //Check if the First record on the TimeMaterial page edited sucessfully
            IWebElement codeRecord1 = driver.FindElement(By.XPath("//*[@id=\'tmsGrid\']/div[3]/table/tbody/tr[1]/td[1]"));
            IWebElement descriptionRecord = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[1]/td[3]"));


            if (codeRecord1.Text == "Manual" && descriptionRecord.Text == "NewZealand")


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
            // Delete last record of last page
            //Click on the deletegototheLastPage
            IWebElement deletegototheLastPage = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            deletegototheLastPage.Click();

            //Identify the path for Delete button
            IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id=\'tmsGrid\']/div[3]/table/tbody/tr[7]/td[5]/a[2]"));
            deleteButton.Click();
            Thread.Sleep(5000);

            driver.SwitchTo().Alert();
            //Alert.accept();

            //Check if the last record on the TimeMaterial page deleted sucessfully
            //IWebElement deleteLastRecord = driver.FindElement(By.XPath""));

            //if (deleteLastRecord.Text =="Sept")
            //{

            //Console.WriteLine("Record has not been deleted, Test failed");

            //}

            //else

            //{    Console.WriteLine("Record has been deleted, Test passed");

            //}



        }
    }
}
