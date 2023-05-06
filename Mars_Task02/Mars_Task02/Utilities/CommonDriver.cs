using Mars_Task02.Pages;
using Microsoft.Office.Interop.Word;
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
        protected Browser browser;

       [SetUp]
        public void InvokeMarsloginpage()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://localhost:5000/Home");
        }


        [TearDown]
        public void stopSteps()
        {
            driver.Quit();
        }


    }
}
