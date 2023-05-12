using Mars_Task02.ExtentReport;
using Mars_Task02.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework.Interfaces;
using System.ComponentModel;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;




namespace Mars_Task02.Utilities
{
    public class CommonDriver
    {
        public static IWebDriver driver;
       // protected Browser browser;

       [SetUp]
        public void InvokeMarsloginpage()
        {
           // ExtentReporting.CreateTest(TestContext.CurrentContext.Test.MethodName);
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://localhost:5000/Home");

            //browser= new Browser(driver);
        }


        [TearDown]
        public void stopSteps()
        {
            //EndTest();
            //ExtentReporting.EndReporting();
            driver.Quit();

        }

    //    private void EndTest()
    //    {
    //        var testStatus = TestContext.CurrentContext.Result.Outcome.Status;
    //        var message = TestContext.CurrentContext.Result.Message;

    //        switch (testStatus)
    //        {
    //            case TestStatus.Failed:
    //                //ExtentReporting.LogFail($"Test has failed {message}");
    //                break;
    //            case TestStatus.Skipped:
    //                //ExtentReporting.LogInfo($"Test skipped {message}");
    //                break;
    //            default:
    //                break;
    //        }

    //        //ExtentReporting.LogScreenShot("Ending test", Browser.GetScreenShot());
    //    }
    }
}
