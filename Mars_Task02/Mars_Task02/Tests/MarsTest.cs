using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports;
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
using AventStack.ExtentReports.Gherkin.Model;
using System.ComponentModel;
using Microsoft.Office.Interop.Excel;

namespace Mars_Task02.Tests
{
    [TestFixture]
    [Parallelizable]
    public class MarsTest : CommonDriver
    {
       // LoginPage loginPageObj = new LoginPage();
        //HomePage homePageObj = new HomePage();
       // ShareskillPage shareskillObj = new ShareskillPage();
       // ManageskillsPage manageskillObj = new ManageskillsPage();


        //[OneTimeSetUp]
        //public void StartExtentReports()
        //{
        //    // Initialize ExtentReports


        //    extent = new ExtentReports();
        //    var htmlReporter = new ExtentHtmlReporter(ReportPath);
        //    htmlReporter.LoadConfig(ReportXMLPath);
        //    extent.AttachReporter(htmlReporter);
        //    extent.AddSystemInfo("Environment", "QA");
        //    extent.AddSystemInfo("User", Environment.UserName);
        //    extent.AddSystemInfo("Machine Name", Environment.MachineName);
        //}


        [Test, Order(1)]
        public void Shareskills()
        {
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);

            try
            {
                ShareskillPage shareSkillPageObj = new ShareskillPage();

                RowNum = 2;
                shareSkillPageObj.ShareSkill();
                shareSkillPageObj.AddTitle();
                shareSkillPageObj.AddDescription();
                shareSkillPageObj.AddCategory();
                shareSkillPageObj.AddSubCategory();
                shareSkillPageObj.AddTags();
                shareSkillPageObj.AddServiceType();
                shareSkillPageObj.AddLocationType();
                shareSkillPageObj.AddStartandEndtime();
                shareSkillPageObj.AddSunday();
                shareSkillPageObj.AddStartandEndtimeSunday();
                shareSkillPageObj.AddMonday();
                shareSkillPageObj.AddStartandEndtimeMonday();
                shareSkillPageObj.AddTuesday();
                shareSkillPageObj.AddStartandEndtimeTuesday();
                shareSkillPageObj.AddSkillTrade();
                shareSkillPageObj.AddWorkSample();
                shareSkillPageObj.AddVisibility();
                shareSkillPageObj.SaveSkill();

                string notificationPopUpAlert = shareSkillPageObj.ConfirmationAlertWindow();
                Assert.That(notificationPopUpAlert == "Service Listing Added successfully","Error while adding listing");
                test.Log(Status.Pass, "Passed, action successfull.");
            }
            catch (Exception ex)
            {
                test.Log(Status.Fail, "Failed, action unsuccessfull. Error while executing the test or some fields missing");
                test.Log(Status.Info, ex.Message);
            }
        }
        //    try
        //    {
        //        ExcelLib.ClearData();
        //        //ExcelLib.PopulateInCollection(@"C:\Users\nikit\Mars_Task02\Mars_Task02\Mars_Task02\Mars_Task02\ExcelData\TestData.xlsx", "SignIn");
        //        //loginPageObj.LoginActions(ExcelLib.ReadData(1, "Username"), ExcelLib.ReadData(1, "Password"));

        //        homePageObj.GoToShareSkillPage();
        //        ExcelLib.PopulateInCollection(@"C:\Users\nikit\Mars_Task02\Mars_Task02\Mars_Task02\Mars_Task02\ExcelData\TestDataShareSkills.xlsx", "ShareSkill");
        //        shareskillObj.ShareSkillAddFunction(ExcelLib.ReadData(1, "Title"),
        //                                            ExcelLib.ReadData(1, "Description"),
        //                                            ExcelLib.ReadData(1, "Tags"),
        //                                            ExcelLib.ReadData(1, "Startdate"),
        //                                            ExcelLib.ReadData(1, "Enddate"),
        //                                            ExcelLib.ReadData(1, "Starttime"),
        //                                            ExcelLib.ReadData(1, "Endtime"),
        //                                            ExcelLib.ReadData(1, "Mstarttime"),
        //                                            ExcelLib.ReadData(1, "Mendtime"),
        //                                            ExcelLib.ReadData(1, "Tstarttime"),
        //                                            ExcelLib.ReadData(1, "Tendtime"),
        //                                            ExcelLib.ReadData(1, "Skill-Exchange"));

        //    }
        //    catch (Exception ex)
        //    {
        //        test.Log(Status.Fail, "Failed, action unsuccessfull or Error while executing the test.");
        //        test.Log(Status.Info, ex.Message);
        //    }
        //}

        [Test, Order(2)]
        public void ManageviewSkill()
        {
            test = extent.CreateTest(MethodBase.GetCurrentMethod().Name);

            try
            {
                ManageskillsPage manageskillObj = new ManageskillsPage();
                ExcelLib.ClearData();
                //ExcelLib.PopulateInCollection(@"C:\Users\nikit\Mars_Task02\Mars_Task02\Mars_Task02\Mars_Task02\ExcelData\TestData.xlsx", "SignIn");
                //loginPageObj.LoginActions(ExcelLib.ReadData(1, "Username"), ExcelLib.ReadData(1, "Password"));

                manageskillObj.ManagelistingsEditSkill();
                manageskillObj.ManagelistingsViewSkill();
                test.Log(Status.Pass, "Passed, Action Successful.");
            }
            catch (Exception ex)
            {
                test.Log(Status.Fail, "Failed,Error while executing the test.");
                test.Log(Status.Info, ex.Message);
            }
        }
        [Test, Order(3)]
        public void ManageEditskill()
        {
            test = extent.CreateTest(MethodBase.GetCurrentMethod().Name);
            try
            {
                ManageskillsPage manageskillObj = new ManageskillsPage();
                ExcelLib.ClearData();
                //ExcelLib.PopulateInCollection(@"C:\Users\nikit\Mars_Task02\Mars_Task02\Mars_Task02\Mars_Task02\ExcelData\TestData1.xlsx", "ManagelistingsEditSignIn");
                //loginPageObj.LoginActions(ExcelLib.ReadData(1, "Username"), ExcelLib.ReadData(1, "Password"));

                // homePageObj.GoToManageListingsPage();
                //ExcelLib.PopulateInCollection(@"C:\Users\nikit\Mars_Task02\Mars_Task02\Mars_Task02\Mars_Task02\ExcelData\TestDataManageListings.xlsx", "ManageSkill");
                RowNum = 2;
                manageskillObj.ManagelistingsEditSkill();
                manageskillObj.EditListing();
                manageskillObj.EditTitle();
                manageskillObj.EditDescription();
                manageskillObj.EditTag();
                manageskillObj.EditStartDate();
                manageskillObj.EditEndDate();
                manageskillObj.EditStartTime();
                manageskillObj.EditEndTime();
                manageskillObj.SaveEditedDetail();
                //(ExcelLib.ReadData(1, "Title"),
                //ExcelLib.ReadData(1, "Description"),
                //ExcelLib.ReadData(1, "Tags"),
                //ExcelLib.ReadData(1, "Startdate"),
                //ExcelLib.ReadData(1, "Enddate"),
                //ExcelLib.ReadData(1, "Starttime"),
                //ExcelLib.ReadData(1, "Endtime"));

                string EditconfirmPopUpAlert = manageskillObj.ConfirmAlertWindow();
                Assert.That(EditconfirmPopUpAlert == "Service Listing Updated successfully","Error while editing listing");
                test.Log(Status.Pass, "Passed,action successfull.");
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
            
            try
            {
                ManageskillsPage manageskillObj = new ManageskillsPage();
                ExcelLib.ClearData();
               // ExcelLib.PopulateInCollection(@"C:\Users\nikit\Mars_Task02\Mars_Task02\Mars_Task02\Mars_Task02\ExcelData\TestData2.xlsx", "ManageListingsDeleteSignIn");
                //loginPageObj.LoginActions(ExcelLib.ReadData(1, "Username"), ExcelLib.ReadData(1, "Password"));

                manageskillObj.ManagelistingsEditSkill();
                manageskillObj.ManageListingsdeleteskill();
                string DeleteConfirmPopUpAlert = manageskillObj.ConfirmAlertWindow();
                string DeletedSkill = manageskillObj.LastDeletedSkill();
                Assert.That(DeleteConfirmPopUpAlert == DeletedSkill + " has been deleted", "Error while deleting a record.");
                test.Log(Status.Pass, "Passed,action successful.");
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
