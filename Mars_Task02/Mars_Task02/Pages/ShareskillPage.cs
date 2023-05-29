using Mars_Task02.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using AutoItX3Lib;
using AutoIt;
using System.Configuration;
using NUnit.Framework;
using Microsoft.Office.Interop.Excel;
using MongoDB.Driver;
using Microsoft.Office.Interop.Word;


namespace Mars_Task02.Pages
{

    public class ShareskillPage : CommonDriver
    {
        public ShareskillPage()
        {
            ExcelLib.PopulateInCollection(ExcelPath, "ShareSkill");
        }

        private static IWebElement shareSkillButton => driver.FindElement(By.CssSelector("[href=\"/Home/ServiceListing\"]"));
        private static IWebElement titleTextBox => driver.FindElement(By.Name("title"));
        private static IWebElement descriptionTextBox => driver.FindElement(By.Name("description"));
        private static IWebElement categoryFind => driver.FindElement(By.Name("categoryId"));
        private static IWebElement categorySelect => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[3]/div[2]/div/div[1]/select/option[7]"));
        private static IWebElement subCategoryFind => driver.FindElement(By.Name("subcategoryId"));
        private static IWebElement subCategorySelect => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[3]/div[2]/div/div[2]/div[1]/select/option[5]"));
        private static IWebElement tagsTextBox => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[4]/div[2]/div/div/div/div/input"));
        private static IWebElement serviceHourly => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[5]/div[2]/div[1]/div[1]/div/input"));

        private static IWebElement serviceOneOff => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[5]/div[2]/div[1]/div[2]/div/input"));

        private static IWebElement locationOnsite => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[6]/div[2]/div/div[1]/div/input"));
        private static IWebElement locationOnline => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[6]/div[2]/div/div[2]/div/input"));

        private static IWebElement startDate => driver.FindElement(By.Name("startDate"));
        private static IWebElement endDate => driver.FindElement(By.Name("endDate"));

        private static IWebElement selectSunday => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[2]/div[1]/div/input"));

        private static IWebElement startTimeSunday => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[2]/div[2]/input"));
        private static IWebElement endTimeSunday => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[2]/div[3]/input"));
        private static IWebElement selectMonday => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[3]/div[1]/div/input"));

        private static IWebElement startTimeMonday => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[3]/div[2]/input"));
        private static IWebElement endTimeMonday => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[3]/div[3]/input"));

        private static IWebElement selectTuesday => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[4]/div[1]/div/input"));
        private static IWebElement startTimeTuesday => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[4]/div[2]/input"));
        private static IWebElement endTimeTuesday => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[4]/div[3]/input"));

        private static IWebElement skillTradeButton => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[8]/div[2]/div/div[1]/div/input"));
        private static IWebElement skillTradeCredit => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[8]/div[2]/div/div[2]/div/input"));
        private static IWebElement skillExchange => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[8]/div[4]/div/div/div/div/div/input"));
        private static IWebElement credit => driver.FindElement(By.Name("charge"));
        private static IWebElement workSampleSelect => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[9]/div/div[2]/section/div/label/div/span/i"));
        private static IWebElement activeButton => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[10]/div[2]/div/div[1]/div/input"));
        private static IWebElement hiddenButton => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[10]/div[2]/div/div[2]/div/input"));
        private static IWebElement saveButton => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[11]/div/input[1]"));
        private static IWebElement addedTitle => driver.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[3]"));
        private static IWebElement confirmationAlert => driver.FindElement(By.CssSelector("[class=\"ns-box ns-growl ns-effect-jelly ns-type-success ns-show\"]"));
        private static IWebElement titleRequired => driver.FindElement(By.XPath("//div[contains(text(), \"Tags are required\")]"));
        private static IWebElement titleSpecialCharacters => driver.FindElement(By.XPath("//div[contains(text(), \"Special characters are not allowed.\")]"));

        private static IWebElement descriptionIsRequired => driver.FindElement(By.XPath("//div[contains(text(), \"Description is required\")]"));
        private static IWebElement categoryIsRequired => driver.FindElement(By.XPath("//div[contains(text(), \"Category is required\")]"));
        private static IWebElement subCategoryIsRequired => driver.FindElement(By.XPath("//div[contains(text(), \"Subcategory is required\")]"));
        private static IWebElement tagIsRequired => driver.FindElement(By.XPath("//div[contains(text(), \"Tags are required\")]"));
        private static IWebElement incorrectFileFormat => driver.FindElement(By.CssSelector("[class=\"ns-box ns-growl ns-effect-jelly ns-type-error ns-show\"]"));

        public void ShareSkill()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            shareSkillButton.Click();
        }
        public void AddTitle()
        {
            titleTextBox.SendKeys(ExcelLib.ReadData(RowNum, "Title"));
        }
        public void AddDescription()
        {
            descriptionTextBox.SendKeys(ExcelLib.ReadData(RowNum, "Description"));
        }
        public void AddCategory()
        {
            SelectElement categoryDropdown = new SelectElement(categoryFind);
            categoryDropdown.SelectByValue("6");
        }
        public void AddSubCategory()
        {
            SelectElement subCategoryDropdown = new SelectElement(subCategoryFind);
            subCategoryDropdown.SelectByValue("4");
        }

        public void AddTags()
        {

            tagsTextBox.SendKeys(ExcelLib.ReadData(RowNum, "Tags"));
            tagsTextBox.SendKeys(Keys.Enter);
        }

        public void AddServiceType()
        {
            if (ExcelLib.ReadData(2, "Service Type") == "Hourly basis service")
            {
                serviceHourly.Click();
            }
            else
            {
                serviceOneOff.Click();

            }
        }

        public void AddLocationType()
        {
            if (ExcelLib.ReadData(2, "Location Type") == "On-site")
            {
                locationOnsite.Click();
            }
            else
            {
                locationOnline.Click();
            }
        }

        public void AddStartandEndtime()
        {
            startDate.SendKeys(ExcelLib.ReadData(RowNum, "Startdate"));
            endDate.SendKeys(ExcelLib.ReadData(RowNum, "Enddate"));
        }

        public void AddSunday()
        {
            selectSunday.Click();
        }

        public void AddStartandEndtimeSunday()
        {
            startTimeSunday.SendKeys(ExcelLib.ReadData(RowNum, "Starttime"));
            endTimeSunday.SendKeys(ExcelLib.ReadData(RowNum, "Endtime"));
        }
        public void AddMonday()
        {
            selectMonday.Click();
        }

        public void AddStartandEndtimeMonday()
        {
            startTimeMonday.SendKeys(ExcelLib.ReadData(RowNum, "Mstarttime"));
            endTimeMonday.SendKeys(ExcelLib.ReadData(RowNum, "Mendtime"));
        }

        public void AddTuesday()
        {
            selectTuesday.Click();
        }

        public void AddStartandEndtimeTuesday()
        {
            startTimeTuesday.SendKeys(ExcelLib.ReadData(RowNum, "Tstarttime"));
            endTimeTuesday.SendKeys(ExcelLib.ReadData(RowNum, "Tendtime"));
        }

        public void AddSkillTrade()
        {
            if (ExcelLib.ReadData(RowNum, "Skill Trade") == "Skill-exchange")
            {
                skillTradeButton.Click();
                skillExchange.SendKeys(ExcelLib.ReadData(RowNum, "Skill-Exchange"));
                skillExchange.SendKeys(Keys.Enter);
            }
            else
            {
                skillTradeCredit.Click();
                credit.SendKeys(ExcelLib.ReadData(RowNum, "Credit"));

            }
        }

        public void AddWorkSample()
        {
            //After winActiavte do not move from focussed window
            //Otherwise the script will run the command on the newly focused window.
            workSampleSelect.Click();
            AutoItX3 autoIt = new AutoItX3();
            Thread.Sleep(1000);
            autoIt.WinActivate("Open");
            Thread.Sleep(1000);
            autoIt.Send(@"C:\Users\nikit\Mars_Task02\Mars_Task02\Mars_Task02\Mars_Task02\AUTOIT\" + ExcelLib.ReadData(RowNum, "Work Sample"));

            Thread.Sleep(1000);
            autoIt.Send("{ENTER}");
        }


        public void AddVisibility()
        {
            if (ExcelLib.ReadData(RowNum, "Active") == "Active")
            {
                activeButton.Click();
            }
            else
            {
                hiddenButton.Click();
            }
        }

        public void SaveSkill()
        {
            saveButton.Click();
        }

        public string EnterTitle()
        {
            return titleRequired.Text;
        }

        public string SpecialChars()
        {
            return titleSpecialCharacters.Text;
        }

        public int CharacterLimit()
        {
            return titleTextBox.Text.Count();
        }

        public string EnterDescription()
        {
            return descriptionIsRequired.Text;
        }

        public string EnterTag()
        {
            return tagIsRequired.Text;
        }

        public string IncorrectFileFormat()
        {
            return incorrectFileFormat.Text;
        }
        public string ConfirmationAlertWindow()
        {
            return confirmationAlert.Text;
        }


        


    }

        
    
}
