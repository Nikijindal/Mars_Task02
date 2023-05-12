using Mars_Task02.Utilities;
using Microsoft.Office.Interop.Word;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Mars_Task02.ExtentReport;

namespace Mars_Task02.Pages
{
    public class ManageskillsPage : CommonDriver
    { 
        private IWebElement viewbtn => driver.FindElement(By.XPath("//i[@class=\"eye icon\"]"));
        private IWebElement editbtn => driver.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[8]/div/button[2]"));
        private IWebElement deletebtn => driver.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[8]/div/button[3]/i"));
        private IWebElement mnglistingtab => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[1]/div/a[3]"));
        private IWebElement savebtn => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[11]/div/input[1]"));
        private IWebElement MlPopUp => driver.FindElement(By.CssSelector("[class=\"ns-box ns-growl ns-effect-jelly ns-type-success ns-show\"]"));
        private IWebElement Mltitle => driver.FindElement(By.Name("title"));
        private IWebElement MlDesc => driver.FindElement(By.Name("description"));
        private IWebElement Mltags => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[4]/div[2]/div/div/div/div/input"));
        private IWebElement Mlstartdate => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[1]/div[2]/input"));
        private IWebElement Mlenddate => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[1]/div[4]/input"));
        private IWebElement Mlstarttime => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[2]/div[2]/input"));
        private IWebElement Mlendtime => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[2]/div[3]/input"));
        private IWebElement Mldelconfirm => driver.FindElement(By.XPath("/html/body/div[2]/div/div[3]/button[2]"));
        private IWebElement Titletxt  => driver.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[3]"));
        private IWebElement Desctxt => driver.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[4]"));
        public void ManagelistingsViewSkills()
        {
            //ExtentReporting.LogInfo($"View listing of skills");
            //Wait.WaitobeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[1]/div/a[3]", 5);
            //// click on manage listings tab
            //mnglistingtab.Click();

            Thread.Sleep(8000);
            //Wait.WaitobeClickable(driver, "XPath", "//i[@class=\"eye icon\"]", 10);
            // Click on eye button
            viewbtn.Click();
        }
        
        public void ManagelistingsEditSkill(string newtitle,string newdesc,string newtag,string newstartdate,string newenddate,string newstarttime,string newendtime)
        {
            //ExtentReporting.LogInfo($"Edit Skill from Listings");
            //Wait.WaitobeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[1]/div/a[3]", 5);
            //// click on manage listings tab
            //mnglistingtab.Click();

            //Wait.WaitobeClickable(driver, "XPath", "//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr/td[8]/div/button[2]", 5);
            Thread.Sleep(8000);
            //click on edit button of the first listing
            editbtn.Click();
            
            Wait.WaitobeClickable(driver, "Name", "title", 5);
            //click and edit title textbox
            Mltitle.Clear();
            Mltitle.SendKeys(newtitle);
            
            Wait.WaitobeClickable(driver, "Name", "description", 5);
            //click and edit description textbox 
            MlDesc.Clear();
            MlDesc.SendKeys(newdesc);
            
            Wait.WaitobeClickable(driver, "XPath", "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[4]/div[2]/div/div/div/div/input", 5);
            // click and edit tags field
            Mltags.SendKeys(newtag + "\n");
            
            Wait.WaitobeClickable(driver, "XPath", "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[1]/div[2]/input", 5);
            // Enter new start date
            Mlstartdate.SendKeys(newstartdate);
            
            Wait.WaitobeClickable(driver, "XPath", "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[1]/div[4]/input", 5);
            // Enter new end date
            Mlenddate.SendKeys(newenddate);

            Wait.WaitobeClickable(driver, "XPath", "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[2]/div[2]/input", 5);
            //Enter new start time
            Mlstarttime.SendKeys(newstarttime);

            Wait.WaitobeClickable(driver, "XPath", "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[2]/div[3]/input", 5);
            //Enter new end time
            Mlendtime.SendKeys(newendtime);

            Wait.WaitobeClickable(driver, "XPath", "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[11]/div/input[1]", 5);
            //click on save button to save edited record 
            savebtn.Click();

            Thread.Sleep(8000);
            Assert.That(Titletxt.Text == "Software Tester", "Title is edited successfully");
        }
        //public void MLEditskillAssert(string newtitle, string newdesc)
        //{
        //    Thread.Sleep(5000);
        //    Assert.That(Titletxt.Text == newtitle, "Edited title did not match");
        //    Thread.Sleep(5000);
        //    Assert.That(Desctxt.Text == newdesc, "Edited description did not match");
        //}

        public void ManageListingsdeleteskill() 
        {
            //ExtentReporting.LogInfo($"Delete skill from listings");
            Thread.Sleep(8000);
            deletebtn.Click();
            Mldelconfirm.Click();

            Thread.Sleep(5000);
            Assert.That(Titletxt.Text != "Software Tester", "Deletion not successful");
        }
        //public void MLDeleteskillAssert(string newtitle)
        //{
        //    Thread.Sleep(8000);
        //    Assert.That(MlPopUp.Text == newtitle + "has been deleted", "Deletion not successful");
        //}
    }
}
