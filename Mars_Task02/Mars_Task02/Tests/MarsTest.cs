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
        

        [Test, Order(2)]
        public void ManageviewSkill()
        {
            test = extent.CreateTest(MethodBase.GetCurrentMethod().Name);

            try
            {
                ManageskillsPage manageskillObj = new ManageskillsPage();
                ExcelLib.ClearData();
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
        
    }
}
