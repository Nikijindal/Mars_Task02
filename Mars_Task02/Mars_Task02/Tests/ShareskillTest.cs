using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports;
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
using SeleniumExtras.PageObjects;
using System.Reflection;

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

        public static ExtentReports extent;
        public static ExtentTest test;

        [OneTimeSetUp]
        public void StartExtentReports()
        {
            // Initialize ExtentReports
            extent = new ExtentReports();
            var htmlReporter = new ExtentHtmlReporter(@"C:\Users\nikit\Mars_Task02\Mars_Task02\Mars_Task02\Mars_Task02\ExtentReport\TestReports\Reports");
            htmlReporter.LoadConfig(@"C:\Users\nikit\Mars_Task02\Mars_Task02\Mars_Task02\Mars_Task02\ExtentReport\XMLFile1.xml");
            extent.AttachReporter(htmlReporter);
            extent.AddSystemInfo("Environment", "QA");
            extent.AddSystemInfo("User", Environment.UserName);
            extent.AddSystemInfo("Machine Name", Environment.MachineName);
        }


        [Test, Order(1)]
        public void Shareskills()
        {
            test = extent.CreateTest(MethodBase.GetCurrentMethod().Name);
            //ExtentReporting.LogInfo("Share Skills Action");
            try
            {
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

                //ExcelLib.PopulateInCollection(@"C:\Users\nikit\Mars_Task02\Mars_Task02\Mars_Task02\Mars_Task02\ExcelData\TestDataShareSkills.xlsx", "ShareSkill");
                //shareskillObj.ShareskillEditAssert(ExcelLib.ReadData(1, "Title"));
            }
            catch (Exception ex)
            {
                test.Log(Status.Fail, "Failed, action unsuccessfull or Error while executing the test.");
                test.Log(Status.Info, ex.Message);
            }
        }

        [Test, Order(2)]
        public void ManageviewSkill()
        {
            test = extent.CreateTest(MethodBase.GetCurrentMethod().Name);
            //ExtentReporting.LogInfo($"View Listing Action");
            try
            {
                ExcelLib.ClearData();
                ExcelLib.PopulateInCollection(@"C:\Users\nikit\Mars_Task02\Mars_Task02\Mars_Task02\Mars_Task02\ExcelData\TestData.xlsx", "SignIn");
                loginPageObj.LoginActions(ExcelLib.ReadData(1, "Username"), ExcelLib.ReadData(1, "Password"));

                homePageObj.gotomanagelistingspage();
                manageskillObj.ManagelistingsViewSkills();
            }
            catch(Exception ex)
            {
                test.Log(Status.Fail, "Failed, action unsuccessfull or Error while executing the test.");
                test.Log(Status.Info, ex.Message);
            }
        }
        [Test, Order(3)]
        public void ManageEditskill()
        {
            test = extent.CreateTest(MethodBase.GetCurrentMethod().Name);
            // ExtentReporting.LogInfo($"Edit Listings Action");
            try
            {
                ExcelLib.ClearData();
                ExcelLib.PopulateInCollection(@"C:\Users\nikit\Mars_Task02\Mars_Task02\Mars_Task02\Mars_Task02\ExcelData\TestData1.xlsx", "ManagelistingsEditSignIn");
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
                //ExcelLib.PopulateInCollection(@"C:\Users\nikit\Mars_Task02\Mars_Task02\Mars_Task02\Mars_Task02\ExcelData\TestDataManageListings.xlsx", "ManageSkill");
                // manageskillObj.MLEditskillAssert(ExcelLib.ReadData(1, "Title"),
                //ExcelLib.ReadData(1, "Description"));

            }
            catch(Exception ex)
            {
                test.Log(Status.Fail, "Failed, action unsuccessfull or Error while executing the test.");
                test.Log(Status.Info, ex.Message);
            }
        }
        [Test, Order(4)]
        public void ManageDeleteskill()
        {
            test = extent.CreateTest(MethodBase.GetCurrentMethod().Name);
            //ExtentReporting.LogInfo($"Delete Listing Action");
            try
            {
                ExcelLib.ClearData();
                ExcelLib.PopulateInCollection(@"C:\Users\nikit\Mars_Task02\Mars_Task02\Mars_Task02\Mars_Task02\ExcelData\TestData2.xlsx", "ManageListingsDeleteSignIn");
                loginPageObj.LoginActions(ExcelLib.ReadData(1, "Username"), ExcelLib.ReadData(1, "Password"));

                homePageObj.gotomanagelistingspage();
                manageskillObj.ManageListingsdeleteskill();
                // manageskillObj.MLDeleteskillAssert(ExcelLib.ReadData(1, "Title"));
            }
            catch(Exception ex)
            {
                test.Log(Status.Fail, "Failed, action unsuccessfull or Error while executing the test.");
                test.Log(Status.Info, ex.Message);
            }

        }
        [OneTimeTearDown]
        public void SaveExtentReports()
        {
            // Save Extentreport html file
            extent.Flush();
        }
    }
}
