using Mars_Task02.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars_Task02.Utilities
{
    public class CommonDriver
    {
        public static IWebDriver driver;

        [SetUp]
        public void InvokeMarsloginpage()
        {
            driver = new ChromeDriver();
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.loginActions(driver);
        }


        //[TearDown]
        //public void stopSteps()
        //{
        //    driver.Quit();
        //}


    }
}
