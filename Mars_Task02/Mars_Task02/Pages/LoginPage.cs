
using Mars_Task02.Utilities;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Mars_Task02.Pages
{
    public class LoginPage : CommonDriver
    {
        public LoginPage()
        {
            ExcelLib.PopulateInCollection(ExcelPath, "SignIn");
        }
        private static IWebElement signinButton => driver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a"));
        private static IWebElement usernameTextbox => driver.FindElement(By.Name("email"));
        private static IWebElement passwordTextbox => driver.FindElement(By.Name("password"));
        private static IWebElement loginButton => driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
        private static IWebElement rememberMeCheckbox => driver.FindElement(By.Name("rememberDetails"));
        public void LoginActions()
        
        {
            //RowNum = 2;
            signinButton.Click();
            usernameTextbox.SendKeys(ExcelLib.ReadData(2, "Username"));
            passwordTextbox.SendKeys(ExcelLib.ReadData(2, "Password"));
            rememberMeCheckbox.Click();
            loginButton.Click();



            //signinButton.Click();
               // usernameTextbox.SendKeys(Username);
                //passwordTextbox.SendKeys(Password);
                //loginButton.Click();
                //Thread.Sleep(5000);
        }
    }
}
