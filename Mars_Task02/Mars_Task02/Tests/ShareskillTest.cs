using Mars_Task02.ExtentReport;
using Mars_Task02.Pages;
using Mars_Task02.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars_Task02.Tests
{
    [TestFixture]
    [Parallelizable]
    public class ShareskillTest : CommonDriver
    {
        LoginPage loginPageObj = new LoginPage();
        HomePage homePageObj = new HomePage();
        ShareskillPage shareskillObj = new ShareskillPage();
        ManageskillsPage manageskillObj = new ManageskillsPage();

        [Test, Order(1)]
        public void Shareskills()
        {
            ExtentReporting.LogInfo("Share Skills Action");
            ExcelLib.ClearData();
            ExcelLib.PopulateInCollection(@"C:\Users\nikit\Mars_Task02\Mars_Task02\Mars_Task02\Mars_Task02\ExcelData\TestData.xlsx", "SignIn");
            loginPageObj.LoginActions(ExcelLib.ReadData(1, "Username"), ExcelLib.ReadData(1, "Password"));

            homePageObj.gotoshareskillpage();
            ExcelLib.PopulateInCollection(@"C:\Users\nikit\Mars_Task02\Mars_Task02\Mars_Task02\Mars_Task02\ExcelData\TestDataShareSkills.xlsx", "ShareSkill");
            shareskillObj.ShareSkillAddfunction(ExcelLib.ReadData(1, "Title"),
                                                ExcelLib.ReadData(1, "Description"),
                                                ExcelLib.ReadData(1, "Tags"),
                                                ExcelLib.ReadData(1, "Startdate"),
                                                ExcelLib.ReadData(1, "Enddate"),
                                                ExcelLib.ReadData(1, "Starttime"),
                                                ExcelLib.ReadData(1, "Endtime"),
                                                ExcelLib.ReadData(1, "Mstarttime"),
                                                ExcelLib.ReadData(1, "Mendtime"),
                                                ExcelLib.ReadData(1, "Tstarttime"),
                                                ExcelLib.ReadData(1, "Tendtime"),
                                                ExcelLib.ReadData(1, "Skill-Exchange"));

            ExcelLib.PopulateInCollection(@"C:\Users\nikit\Mars_Task02\Mars_Task02\Mars_Task02\Mars_Task02\ExcelData\TestDataShareSkills.xlsx", "ShareSkill");
            shareskillObj.ShareskillEditAssert(ExcelLib.ReadData(1, "Title"));

        }

        [Test, Order(2)]
        public void ManageviewSkill()
        {
            ExtentReporting.LogInfo($"View Listing Action");
            ExcelLib.ClearData();
            ExcelLib.PopulateInCollection(@"C:\Users\nikit\Mars_Task02\Mars_Task02\Mars_Task02\Mars_Task02\ExcelData\TestData.xlsx", "SignIn");
            loginPageObj.LoginActions(ExcelLib.ReadData(1, "Username"), ExcelLib.ReadData(1, "Password"));

            homePageObj.gotomanagelistingspage();
            manageskillObj.ManagelistingsViewSkills();
        }
        [Test, Order(3)]
        public void ManageEditskill()
        {
            ExtentReporting.LogInfo($"Edit Listings Action");
            ExcelLib.ClearData();
            ExcelLib.PopulateInCollection(@"C:\Users\nikit\Mars_Task02\Mars_Task02\Mars_Task02\Mars_Task02\ExcelData\TestData.xlsx", "SignIn");
            loginPageObj.LoginActions(ExcelLib.ReadData(1, "Username"), ExcelLib.ReadData(1, "Password"));

            homePageObj.gotomanagelistingspage();
            ExcelLib.PopulateInCollection(@"C:\Users\nikit\Mars_Task02\Mars_Task02\Mars_Task02\Mars_Task02\ExcelData\TestDataManageListings.xlsx", "ManageSkill");
            manageskillObj.ManagelistingsEditSkill(ExcelLib.ReadData(1, "Title"),
                                                ExcelLib.ReadData(1, "Description"),
                                                ExcelLib.ReadData(1, "Tags"),
                                                ExcelLib.ReadData(1, "Startdate"),
                                                ExcelLib.ReadData(1, "Enddate"),
                                                ExcelLib.ReadData(1, "Starttime"),
                                                ExcelLib.ReadData(1, "Endtime"));

            //homePageObj.gotomanagelistingspage();
            ExcelLib.PopulateInCollection(@"C:\Users\nikit\Mars_Task02\Mars_Task02\Mars_Task02\Mars_Task02\ExcelData\TestDataManageListings.xlsx", "ManageSkill");
            manageskillObj.MLEditskillAssert(ExcelLib.ReadData(1, "Title"),
                                                ExcelLib.ReadData(1, "Description"));
        }
        [Test, Order(4)]
        public void ManageDeleteskill()
        {
            ExtentReporting.LogInfo($"Delete Listing Action");
            ExcelLib.ClearData();
            ExcelLib.PopulateInCollection(@"C:\Users\nikit\Mars_Task02\Mars_Task02\Mars_Task02\Mars_Task02\ExcelData\TestData.xlsx", "SignIn");
            loginPageObj.LoginActions(ExcelLib.ReadData(1, "Username"), ExcelLib.ReadData(1, "Password"));

            homePageObj.gotomanagelistingspage();
            manageskillObj.ManageListingsdeleteskills();
            manageskillObj.MLDeleteskillAssert(ExcelLib.ReadData(1, "Title"));

        }
    }
}
