using AventStack.ExtentReports;
using Mars_Task02.Pages;
using Mars_Task02.Utilities;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.PageObjects;
using System.ComponentModel;
using Microsoft.Office.Interop.Excel;

namespace Mars_Task02.Tests
{
    [TestFixture]
    public class NegativeTest : CommonDriver
    {
        [Test,Order(5)]
        public void EmptyTitleTesting()
        {
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);
            try
            {
                ShareskillPage shareSkillPageObj = new ShareskillPage();

                RowNum = 4;
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

                string titleMissing = shareSkillPageObj.EnterTitle();

                Assert.That(titleMissing, Is.Not.Null.Or.Empty);
                test.Log(Status.Pass, "Passed. Title has not been entered.");
            }
            catch (Exception ex)
            {
                test.Log(Status.Fail, "Failed, No Title - found.");
                test.Log(Status.Info, ex.Message);
            }

        }
        [Test, Order(6)]
        public void SpecialCharacterTitleTest()
        {
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);
            try
            {
                ShareskillPage shareSkillPageObj = new ShareskillPage();

                RowNum = 6;
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

                string charTest = shareSkillPageObj.SpecialChars();
                Assert.That(charTest, Is.Not.Null.Or.Empty);
                test.Log(Status.Pass, "Passed, Special characters detected.");
            }
            catch (Exception ex)
            {
                test.Log(Status.Fail, "Failed, Special characters not detected.");
                test.Log(Status.Info, ex.Message);
            }

        }
        [Test, Order(7)]
        public void MaxCharacterlimit()
        {
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);
            try
            {
                ShareskillPage shareSkillPageObj = new ShareskillPage();

                RowNum = 8;
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

                int charlimit = shareSkillPageObj.CharacterLimit();
                Assert.That(charlimit < 101, "Number of characters exceeded");
                test.Log(Status.Pass, "Passed, Number of character is less than or equal the max allowed characters of 100.");
            }
            catch (Exception ex)
            {
                test.Log(Status.Fail, "Failed, No.of characters exceeds 100.");
                test.Log(Status.Info, ex.Message);
            }
        }
        [Test, Order(8)]
        public void EmptyDescriptionTesting()
        {
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);
            try
            {
                ShareskillPage shareSkillPageObj = new ShareskillPage();

                RowNum = 5;
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

                string descriptionMissing = shareSkillPageObj.EnterDescription();
                Assert.That(descriptionMissing, Is.Not.Null.Or.Empty);
                test.Log(Status.Pass, "Passed. Description has not been entered.");
            }
            catch (Exception ex)
            {
                test.Log(Status.Fail, "Failed, Description is missing");
                test.Log(Status.Info, ex.Message);
            }
        }
        [Test, Order(9)]
        public void EmptyTagTest()
        {
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);
            try
            {
                ShareskillPage shareSkillPageObj = new ShareskillPage();

                RowNum = 7;
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

                string tagMissing = shareSkillPageObj.EnterTag();
                Assert.That(tagMissing, Is.Not.Null.Or.Empty);
                test.Log(Status.Pass, "Passed. Tag has not been entered.");
            }
            catch (Exception ex)
            {
                test.Log(Status.Fail, "Failed, Tag is missing");
                test.Log(Status.Info, ex.Message);

            }
        }
        [Test, Order(10)]
        public void InvalidWorkSample()
        {
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);
            try
            {
                ShareskillPage shareSkillPageObj = new ShareskillPage();

                RowNum = 9;
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

                string invalidFileFormat = shareSkillPageObj.IncorrectFileFormat();
                Assert.That(invalidFileFormat == "Max file size is 2 MB and supported file types are gif / jpeg / png / jpg / doc(x) / pdf / txt / xls(x)", "Invalid File Format.");
                test.Log(Status.Pass, "Passed, Invalid file format detected.");
            }
            catch (Exception ex)
            {
                test.Log(Status.Fail, "Failed, Invalid file format - did not work.");
                test.Log(Status.Info, ex.Message);

            }
        }
    }
    
    
}


