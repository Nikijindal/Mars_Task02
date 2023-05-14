
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
