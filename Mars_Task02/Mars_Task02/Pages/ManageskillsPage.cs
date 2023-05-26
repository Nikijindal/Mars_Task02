using Mars_Task02.Utilities;
using Microsoft.Office.Interop.Word;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;
using NUnit.Framework;
using System.Xml.Serialization;

namespace Mars_Task02.Pages
{
    public class ManageskillsPage : CommonDriver
    {
        public ManageskillsPage()
        {
            ExcelLib.PopulateInCollection(ExcelPath, "ManageSkill");
        }
        private static IWebElement gotoManageListingsPage => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[1]/div/a[3]"));
        private static IWebElement viewButton => driver.FindElement(By.XPath("//i[@class=\"eye icon\"]"));
        private static IWebElement editButton => driver.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[8]/div/button[2]"));
        private static IWebElement deleteButton => driver.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[8]/div/button[3]/i"));
        private static IWebElement manageListingtab => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[1]/div/a[3]"));
        private static IWebElement saveButton => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[11]/div/input[1]"));
        private static IWebElement PopUp => driver.FindElement(By.CssSelector("[class=\"ns-box ns-growl ns-effect-jelly ns-type-success ns-show\"]"));
        private static IWebElement titleTextbox => driver.FindElement(By.Name("title"));
        private static IWebElement descriptionTextbox => driver.FindElement(By.Name("description"));
        private static IWebElement tagsTextbox => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[4]/div[2]/div/div/div/div/input"));
        private static IWebElement startDate => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[1]/div[2]/input"));
        private static IWebElement endDate => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[1]/div[4]/input"));
        private static IWebElement startTime => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[2]/div[2]/input"));
        private static IWebElement endTime => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[2]/div[3]/input"));
        private static IWebElement deletionConfirm => driver.FindElement(By.XPath("/html/body/div[2]/div/div[3]/button[2]"));
        private static IWebElement editedTitleText => driver.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[3]"));
        private static IWebElement DescTextbox => driver.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[4]"));
        private static IWebElement lastListing => driver.FindElement(By.XPath("//*[@class=\"ui striped table\"]/tbody/tr[1]/td[3]"));
        
        private static IWebElement deletionConfirmation => driver.FindElement(By.CssSelector("[class=\"ns-box ns-growl ns-effect-jelly ns-type-success ns-show\"]"));

        public void ManagelistingsViewSkill()
        {
            Thread.Sleep(8000);
            // Click on eye icon
            viewButton.Click();
        }

        public void ManagelistingsEditSkill()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            gotoManageListingsPage.Click();
        }

        public void EditListing()
        {
            editButton.Click();
        }

        public void EditTitle()
        {
            titleTextbox.Clear();
            titleTextbox.SendKeys(ExcelLib.ReadData(RowNum, "Title"));
        }

        public void EditDescription()
        {
            descriptionTextbox.Clear();
            descriptionTextbox.SendKeys(ExcelLib.ReadData(RowNum, "Description"));
        }

        public void EditTag()
        {
            tagsTextbox.SendKeys(ExcelLib.ReadData(RowNum, "Tags"));
            tagsTextbox.SendKeys(Keys.Enter);
        }

        public void EditStartDate()
        {
            startDate.SendKeys(ExcelLib.ReadData(RowNum, "Startdate"));
        }

        public void EditEndDate()
        {
            endDate.SendKeys(ExcelLib.ReadData(RowNum, "Enddate"));
        }
        public void EditStartTime()
        {
            startTime.SendKeys(ExcelLib.ReadData(RowNum, "Starttime"));
        }
        public void EditEndTime()
        {
            endTime.SendKeys(ExcelLib.ReadData(RowNum, "Endtime"));
        }

        public void SaveEditedDetail()
        {
            saveButton.Click();
        }
        public string ConfirmAlertWindow()
        {
            return PopUp.Text;
        }
        public void ManageListingsdeleteskill()
        {
            //ExtentReporting.LogInfo($"Delete skill from listings");
            Thread.Sleep(8000);
            deleteButton.Click();
            deletionConfirm.Click();

            Thread.Sleep(2000);

            // Assert.That(deletionConfirmation.Text == "Software Tester has been deleted", "Error while deleting record");
        }

        public string LastDeletedSkill()
        {
            return lastListing.Text;
        }


    }

}

//// driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
// Thread.Sleep(8000);
// //click on edit button of the first listing
// editButton.Click();

// Wait.WaitobeClickable(driver, "Name", "title", 5);
// //click and edit title textbox
// titleTextbox.Clear();
// titleTextbox.SendKeys(ExcelLib.ReadData(2, "Title"));

//Wait.WaitobeClickable(driver, "Name", "description", 5);
////click and edit description textbox 
//descriptionTextbox.Clear();
//descriptionTextbox.SendKeys(ExcelLib.ReadData(2, "Description"));

//Wait.WaitobeClickable(driver, "XPath", "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[4]/div[2]/div/div/div/div/input", 5);
//// click and edit tags field
//tagsTextbox.SendKeys(ExcelLib.ReadData(2, "Tags" + "\n"));

//Wait.WaitobeClickable(driver, "XPath", "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[1]/div[2]/input", 5);
//// Enter new start date
//startDate.SendKeys(ExcelLib.ReadData(2, "Startdate"));

//Wait.WaitobeClickable(driver, "XPath", "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[1]/div[4]/input", 5);
//// Enter new end date
//endDate.SendKeys(ExcelLib.ReadData(2, "Enddate"));

//Wait.WaitobeClickable(driver, "XPath", "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[2]/div[2]/input", 5);
////Enter new start time
//startTime.SendKeys(ExcelLib.ReadData(2, "Starttime"));

//Wait.WaitobeClickable(driver, "XPath", "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[2]/div[3]/input", 5);
////Enter new end time
//endTime.SendKeys(ExcelLib.ReadData(2, "Endtime"));

//Wait.WaitobeClickable(driver, "XPath", "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[11]/div/input[1]", 5);
////click on save button to save edited record 
//saveButton.Click();

//Thread.Sleep(5000);
//    Assert.That(editedTitleText.Text == "Software Tester", "Edited skill not saved successfully");


//public string GetLastListing(IWebDriver driver)
//{
//    return lastListing.Text;
//}



