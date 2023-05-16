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

        //public static ExtentTest test;
        //public static string ReportPath = Resource1.ReportPath;
        //public static string ReportXMLPath = Resource1.ReportXMLPath;
        //public static string ScreenShotPath = Resource1.ScreenShotPath;

        public static ExtentReports extent;
        public static ExtentTest test;


        // Initializing Web Elements for login page
        public static IWebElement signinbutton => driver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a"));
        public static IWebElement usernametxtbox => driver.FindElement(By.Name("email"));
        public static IWebElement pwdtxtbox => driver.FindElement(By.Name("password"));
        public static IWebElement loginbtn => driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));

        // ShareSkill page 

        public static IWebElement titletxt => driver.FindElement(By.Name("title"));
        public static IWebElement desctxtbox => driver.FindElement(By.Name("description"));
        public static IWebElement categoryfind => driver.FindElement(By.Name("categoryId"));
        public static IWebElement categoryselect => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[3]/div[2]/div/div[1]/select/option[7]"));
        public static IWebElement subcategoryfind => driver.FindElement(By.Name("subcategoryId"));
        public static IWebElement subcategoryselect => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[3]/div[2]/div/div[2]/div[1]/select/option[5]"));
        public static IWebElement tagstxt => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[4]/div[2]/div/div/div/div/input"));
        public static IWebElement srvchourlyRbtn => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[5]/div[2]/div[1]/div[1]/div/input"));

        public static IWebElement srvconeoffrbtn => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[5]/div[2]/div[1]/div[2]/div/input"));

        public static IWebElement locOnsiteRbtn => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[6]/div[2]/div/div[1]/div/input"));
        public static IWebElement locOnlineRbtn => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[6]/div[2]/div/div[2]/div/input"));

        public static IWebElement strtDateSelect => driver.FindElement(By.Name("startDate"));
        public static IWebElement endDateSelect => driver.FindElement(By.Name("endDate"));

        public static IWebElement selectSun => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[2]/div[1]/div/input"));

        public static IWebElement strttimeSun => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[2]/div[2]/input"));
        public static IWebElement endtimeSun => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[2]/div[3]/input"));
        public static IWebElement selectMon => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[3]/div[1]/div/input"));

        public static IWebElement strttimeMon => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[3]/div[2]/input"));
        public static IWebElement endtimeMon => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[3]/div[3]/input"));

        public static IWebElement selectTue => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[4]/div[1]/div/input"));
        public static IWebElement strttimeTue => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[4]/div[2]/input"));
        public static IWebElement endtimeTue => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[4]/div[3]/input"));

        public static IWebElement skilltradeRbtn => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[8]/div[2]/div/div[1]/div/input"));
        public static IWebElement skilltradecredit => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[8]/div[2]/div/div[2]/div/input"));
        public static IWebElement skillexctxtbox => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[8]/div[4]/div/div/div/div/div/input"));
        public static IWebElement wrksampleselect => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[9]/div/div[2]/section/div/label/div/span/i"));
        public static IWebElement activeRbtn => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[10]/div[2]/div/div[1]/div/input"));
        public static IWebElement hiddenRbtn => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[10]/div[2]/div/div[2]/div/input"));
        public static IWebElement savebtn => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[11]/div/input[1]"));
        public static IWebElement addedtitle => driver.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[3]"));
        public static IWebElement confirmationAlert => driver.FindElement(By.CssSelector("[class=\"ns-box ns-growl ns-effect-jelly ns-type-success ns-show\"]"));

        // ManageListings page 

        public static IWebElement viewbtn => driver.FindElement(By.XPath("//i[@class=\"eye icon\"]"));
        public static IWebElement editbtn => driver.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[8]/div/button[2]"));
        public static IWebElement deletebtn => driver.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[8]/div/button[3]/i"));
        public static IWebElement mnglistingtab => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[1]/div/a[3]"));
        public static IWebElement mlsavebtn => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[11]/div/input[1]"));
        public static IWebElement MlPopUp => driver.FindElement(By.CssSelector("[class=\"ns-box ns-growl ns-effect-jelly ns-type-success ns-show\"]"));
        public static IWebElement Mltitle => driver.FindElement(By.Name("title"));
        public static IWebElement MlDesc => driver.FindElement(By.Name("description"));
        public static IWebElement Mltags => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[4]/div[2]/div/div/div/div/input"));
        public static IWebElement Mlstartdate => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[1]/div[2]/input"));
        public static IWebElement Mlenddate => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[1]/div[4]/input"));
        public static IWebElement Mlstarttime => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[2]/div[2]/input"));
        public static IWebElement Mlendtime => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[2]/div[3]/input"));
        public static IWebElement Mldelconfirm => driver.FindElement(By.XPath("/html/body/div[2]/div/div[3]/button[2]"));
        public static IWebElement Titletxt => driver.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[3]"));
        public static IWebElement Desctxt => driver.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[4]"));
        public static IWebElement lastListing => driver.FindElement(By.XPath("//*[@class=\"ui striped table\"]/tbody/tr[1]/td[3]"));
        // Home Page 
        public static IWebElement shareskillbtn => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[1]/div/div[2]/a"));

        public static IWebElement managelistingstab => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[1]/div/a[3]"));
        public static IWebElement MlconfirmationAlert => driver.FindElement(By.CssSelector("[class=\"ns-box ns-growl ns-effect-jelly ns-type-success ns-show\"]"));


        //#region screenshots
        public class SaveScreenShotClass
        {
            public static string SaveScreenshot(IWebDriver driver, string ScreenShotFileName) // Definition
            {
                var folderLocation = (@"C:\Users\nikit\Mars_Task02\Mars_Task02\Mars_Task02\Mars_Task02\ExtentReport\TestReports\Screenshots");

                if (!System.IO.Directory.Exists(folderLocation))
                {
                    System.IO.Directory.CreateDirectory(folderLocation);
                }

                //var screenShot = ((ITakesScreenshot)driver).GetScreenshot();
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
            // ExtentReporting.CreateTest(TestContext.CurrentContext.Test.MethodName);
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://localhost:5000/Home");



            //Screenshot screenshot = (driver as ITakesScreenshot).GetScreenshot();
            //screenshot.SaveAsFile("Screnshot.png",ScreenshotImageFormat.Png);
        }


        [TearDown]
        public void stopSteps()
        {
            string img = SaveScreenShotClass.SaveScreenshot(driver, "Screenshot");
            test.AddScreenCaptureFromPath(img);

            // Quit browser
            driver.Quit();

        }


    }
}