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
        // Chrome Driver
        public static IWebDriver driver;
        public static string ExcelPath = @"C:\Users\nikit\Mars_Task02\Mars_Task02\Mars_Task02\Mars_Task02\ExcelData\TestData.xlsx";
        public static string ScreenShootPath = @"C:\Users\nikit\Mars_Task02\Mars_Task02\Mars_Task02\Mars_Task02\ExtentReport\TestReports\Screenshots";
        public static string ReportXMLPath = @"C:\Users\nikit\Mars_Task02\Mars_Task02\Mars_Task02\Mars_Task02\ExtentReport\XMLFile1.xml";
        public static string ReportPath = @"C:\Users\nikit\Mars_Task02\Mars_Task02\Mars_Task02\Mars_Task02\ExtentReport\TestReports\Reports";
        public static int RowNum = 1;
        
        //Extent Reports
        public static ExtentReports extent;
        public static ExtentTest test;


        [OneTimeSetUp]
        public void StartExtentReports()
        {
            // Initialize ExtentReports

            extent = new ExtentReports();
            var htmlReporter = new ExtentHtmlReporter(ReportPath);
            htmlReporter.LoadConfig(ReportXMLPath);
            extent.AttachReporter(htmlReporter);
            extent.AddSystemInfo("Environment", "QA");
            extent.AddSystemInfo("User", Environment.UserName);
            extent.AddSystemInfo("Machine Name", Environment.MachineName);
        }

        public class SaveScreenShotClass
        {
            public static string SaveScreenshot(IWebDriver driver, string ScreenShotFileName) // Definition
            {
                var folderLocation = (ScreenShootPath);

                if (!System.IO.Directory.Exists(folderLocation))
                {
                    System.IO.Directory.CreateDirectory(folderLocation);
                }

                var screenShot = (driver as ITakesScreenshot).GetScreenshot();
                var fileName = new StringBuilder(folderLocation);

                fileName.Append(ScreenShotFileName);
                fileName.Append(DateTime.Now.ToString("_yyyy-MM-dd_HHmmss"));
                fileName.Append(".png");
                screenShot.SaveAsFile(fileName.ToString(), ScreenshotImageFormat.Png);
                return fileName.ToString();
            }
        }


        [SetUp]
        public void InvokeMarsloginpage()
        {
            //ExcelLib.PopulateInCollection(ExcelPath, "SignIn");

            var htmlReporter = new ExtentHtmlReporter(ReportPath);
            htmlReporter.LoadConfig(ReportXMLPath);
            extent.AttachReporter(htmlReporter);

            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://localhost:5000/Home");

            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginActions();
            
        }


        [TearDown]
        public void stopSteps()
        {
            string img = SaveScreenShotClass.SaveScreenshot(driver, "Screenshot");
            test.AddScreenCaptureFromPath(img);
            extent.Flush();
            // Quit browser
            driver.Quit();

        }
        [OneTimeTearDown]
        public void SaveExtentReports()
        {
            // Save Extentreport html file
            extent.Flush();
        }

    }
}