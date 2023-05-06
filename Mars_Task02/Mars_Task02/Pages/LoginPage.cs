
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
        

        private IWebElement signinbutton => driver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a"));
        private IWebElement usernametxtbox => driver.FindElement(By.Name("email"));
        private IWebElement pwdtxtbox => driver.FindElement(By.Name("password"));
        private IWebElement loginbtn => driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));

        public void LoginActions(string Username,string Password)
        
            {
                signinbutton.Click();
                usernametxtbox.SendKeys(Username);
                pwdtxtbox.SendKeys(Password);
                loginbtn.Click();
                Thread.Sleep(5000);

            }

            
        
    }
}
