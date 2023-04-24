using Mars_Task02.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public void loginActions(IWebDriver driver)
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://localhost:5000/Home");
            signinbutton.Click();
            usernametxtbox.SendKeys("nik.j@gmail.com");
            pwdtxtbox.SendKeys("password10");
            loginbtn.Click();
            Thread.Sleep(5000);

        }
    }
}
