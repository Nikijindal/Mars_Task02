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
    [Parallelizable]
    [TestFixture]
    public class ShareskillTest : CommonDriver
    {
        LoginPage loginPageObj = new LoginPage();
        HomePage homePageObj = new HomePage();
        ShareskillPage shareskillObj = new ShareskillPage();
        ManageskillsPage manageskillObj = new ManageskillsPage();



        [Test,Order(1)]
        public void Shareskills()
        {
            ExcelLib.PopulateInCollection(@"C:\Users\nikit\Mars_Task02\Mars_Task02\Mars_Task02\Mars_Task02\ExcelData\TestData.xlsx","SignIn");
            loginPageObj.LoginActions(ExcelLib.ReadData(1, "Username"), ExcelLib.ReadData(1, "Password"));

            homePageObj.gotoshareskillpage();
            ExcelLib.PopulateInCollection(@"C:\Users\nikit\Mars_Task02\Mars_Task02\Mars_Task02\Mars_Task02\ExcelData\TestDataShareSkills.xlsx", "ShareSkill");
            shareskillObj.ShareSkillAddfunction(ExcelLib.ReadData(1,"Title"),
                                                ExcelLib.ReadData(1,"Description"),
                                                ExcelLib.ReadData(1,"Category"),
                                                ExcelLib.ReadData(1,"SubCategory"),
                                                ExcelLib.ReadData(1,"Tags"),
                                                ExcelLib.ReadData(1,"Startdate"),
                                                ExcelLib.ReadData(1,"Enddate"),
                                                ExcelLib.ReadData(1,"Starttime"),
                                                ExcelLib.ReadData(1,"Endtime"),
                                                ExcelLib.ReadData(1,"Mstarttime"),
                                                ExcelLib.ReadData(1,"Mendtime"),
                                                ExcelLib.ReadData(1,"Tstarttime"),
                                                ExcelLib.ReadData(1,"Tendtime"),
                                                ExcelLib.ReadData(1,"Skill-Exchange"),
                                                ExcelLib.ReadData(1,"Work Samples"));
            //shareskillObj.title();
            //shareskillObj.description();
            //shareskillObj.category();
            //shareskillObj.subcategory();
            //shareskillObj.tags();
            //shareskillObj.srvctype();
            //shareskillObj.locationtype();   
            //shareskillObj.skilltrade();
            //shareskillObj.skillexchange();
            //shareskillObj.worksample();
            //shareskillObj.active();
            //shareskillObj.savebutton();

        }
        //[Test,Order(2)]
        //public void Manageskills()
        //{ 

        //  //  ManageskillsPage manageskillObj = new ManageskillsPage();
        //    manageskillObj.viewskills();
        //    manageskillObj.editskills();
        //    manageskillObj.edittitle();
        //    manageskillObj.editdescription();
        //    manageskillObj.edittags();
        //    manageskillObj.deleteskills();
        //}

    }
}
