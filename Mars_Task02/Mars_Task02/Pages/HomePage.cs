using Mars_Task02.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Mars_Task02.Pages
{
    public class HomePage : CommonDriver
    {
        private IWebElement shareskillbtn => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[1]/div/div[2]/a"));

        private IWebElement managelistingstab => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[1]/div/a[3]"));
    
    public void gotoshareskillpage(IWebDriver driver)
        {
            Thread.Sleep(5000);
            shareskillbtn.Click();
        }
        public void gotomanagelistingspage(IWebDriver driver) 
        {
            managelistingstab.Click();
        }
    
    
    }


}
