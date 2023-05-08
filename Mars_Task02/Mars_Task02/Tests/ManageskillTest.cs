using Mars_Task02.Pages;
using Mars_Task02.Utilities;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars_Task02.Tests
{
    [TestFixture]
    [Parallelizable]
    public class ManageskillTest : CommonDriver
    {
        LoginPage loginPageObj= new LoginPage();
        HomePage homePageObj= new HomePage();   
        ManageskillsPage manageskillObj = new ManageskillsPage();

        [Test,Order(1)]

        public void ManageviewSkill()
        {
            ExcelLib.PopulateInCollection(@"C:\Users\nikit\Mars_Task02\Mars_Task02\Mars_Task02\Mars_Task02\ExcelData\TestData.xlsx", "SignIn");
            loginPageObj.LoginActions(ExcelLib.ReadData(1, "Username"), ExcelLib.ReadData(1, "Password"));
          
            homePageObj.gotomanagelistingspage();
            manageskillObj.ManagelistingsViewSkills();
        }
        [Test,Order(2)]
        public void ManageEditskill()
        {
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
                                                
            homePageObj.gotomanagelistingspage();
            ExcelLib.PopulateInCollection(@"C:\Users\nikit\Mars_Task02\Mars_Task02\Mars_Task02\Mars_Task02\ExcelData\TestDataManageListings.xlsx", "ManageSkill");
            manageskillObj.MLEditskillAssert(ExcelLib.ReadData(1, "Title"),
                                                ExcelLib.ReadData(1, "Description"));
        }
        [Test,Order(3)]
        public void ManageDeleteskill()
        {
            ExcelLib.ClearData();
            ExcelLib.PopulateInCollection(@"C:\Users\nikit\Mars_Task02\Mars_Task02\Mars_Task02\Mars_Task02\ExcelData\TestData.xlsx", "SignIn");
            loginPageObj.LoginActions(ExcelLib.ReadData(1, "Username"), ExcelLib.ReadData(1, "Password"));

            homePageObj.gotomanagelistingspage();
            manageskillObj.ManageListingsdeleteskills();
            manageskillObj.MLDeleteskillAssert(ExcelLib.ReadData(1, "Title"));

        }

    }
}
