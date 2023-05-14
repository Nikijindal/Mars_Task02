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


namespace Mars_Task02.Pages
{
    public class ShareskillPage : CommonDriver
    {
        public void ShareSkillAddfunction(string title, string description, string tags, string startdate, string enddate, string sunstarttime, string sunendtime, string monstarttime, string monendtime, string tuestarttime, string tueendtime, string skillexc)
        {
            Wait.WaitobeClickable(driver, "Name", "title", 5);
            titletxt.SendKeys(title);


            Wait.WaitobeClickable(driver, "Name", "description", 5);
            desctxtbox.SendKeys(description);


            Wait.WaitobeClickable(driver, "Name", "categoryId", 5);
            SelectElement categorydrpdwn = new SelectElement(categoryfind);
            categorydrpdwn.SelectByValue("6");

            Wait.WaitobeClickable(driver, "Name", "subcategoryId", 5);
            SelectElement subcategorydrpdwn = new SelectElement(subcategoryfind);
            subcategorydrpdwn.SelectByValue("4");


            Wait.WaitobeClickable(driver, "XPath", "\"//*[@id=\\\"service-listing-section\\\"]/div[2]/div/form/div[4]/div[2]/div/div/div/div/input\"", 5);
            tagstxt.SendKeys(tags + "\n");


            Wait.WaitobeClickable(driver, "XPath", "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[5]/div[2]/div[1]/div[1]/div/input", 5);
            srvchourlyRbtn.Click();

            Wait.WaitobeClickable(driver, "XPath", "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[6]/div[2]/div/div[2]/div/input", 5);
            locOnlineRbtn.Click();

            Wait.WaitobeClickable(driver, "Name", "startDate", 5);
            strtDateSelect.SendKeys(startdate);

            Wait.WaitobeClickable(driver, "Name", "endDate", 5);
            endDateSelect.SendKeys(enddate);

            Wait.WaitobeClickable(driver, "XPath", "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[2]/div[1]/div/input", 5);
            selectSun.Click();

            Wait.WaitobeClickable(driver, "XPath", "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[2]/div[2]/input", 5);
            strttimeSun.SendKeys(sunstarttime);

            Wait.WaitobeClickable(driver, "XPath", "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[2]/div[3]/input", 5);
            endtimeSun.SendKeys(sunendtime);

            Wait.WaitobeClickable(driver, "XPath", "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[3]/div[1]/div/input", 5);
            selectMon.Click();

            Wait.WaitobeClickable(driver, "XPath", "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[3]/div[2]/input", 5);
            strttimeMon.SendKeys(monstarttime);

            Wait.WaitobeClickable(driver, "XPath", "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[3]/div[3]/input", 5);
            endtimeMon.SendKeys(monendtime);

            Wait.WaitobeClickable(driver, "XPath", "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[4]/div[1]/div/input", 5);
            selectTue.Click();

            Wait.WaitobeClickable(driver, "XPath", "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[4]/div[2]/input", 5);
            strttimeTue.SendKeys(tuestarttime);

            Wait.WaitobeClickable(driver, "XPath", "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[4]/div[3]/input", 5);
            endtimeTue.SendKeys(tueendtime);

            Wait.WaitobeClickable(driver, "XPath", "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[8]/div[2]/div/div[1]/div/input", 5);
            skilltradeRbtn.Click();

            Wait.WaitobeClickable(driver, "XPath", "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[8]/div[4]/div/div/div/div/div/input", 5);
            skillexctxtbox.SendKeys(skillexc + "\n");



            //After winActiavte do not move from focussed window
            //Otherwise the script will run the command on the newly focused window.
            wrksampleselect.Click();
            AutoItX3 autoIt = new AutoItX3();
            Thread.Sleep(1000);
            autoIt.WinActivate("Open");
            Thread.Sleep(1000);
            autoIt.Send(@"C:\Users\nikit\OneDrive\Desktop\QA-Analyst-small.png");
            Thread.Sleep(1000);
            autoIt.Send("{ENTER}");


            Wait.WaitobeClickable(driver, "XPath", "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[10]/div[2]/div/div[1]/div/input", 5);
            activeRbtn.Click();


            Wait.WaitobeClickable(driver, "XPath", "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[11]/div/input[1]", 5);
            savebtn.Click();

            //Thread.Sleep(5000);
            //Assert.That(addedtitle.Text == "Quality Assurance Analyst", "Skill is not added successfully");
        }

        public string alertWindow(IWebDriver driver)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            return confirmationAlert.Text;
        }
    }
}
