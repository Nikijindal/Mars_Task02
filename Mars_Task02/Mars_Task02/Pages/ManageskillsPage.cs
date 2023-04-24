using Mars_Task02.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars_Task02.Pages
{
    public class ManageskillsPage : CommonDriver
    {
        private IWebElement viewbtn => driver.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr/td[8]/div/button[1]/i"));
        private IWebElement editbtn => driver.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr/td[8]/div/button[2]/i"));
        private IWebElement deletebtn => driver.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr/td[8]/div/button[3]/i"));
        private IWebElement mnglistingtab => driver.FindElement(By.XPath("//*[@id=\"service-detail-section\"]/section[1]/div/a[3]"));
        private IWebElement savebtn => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[11]/div/input[1]"));
        public void viewskills()
        {
            viewbtn.Click();
            mnglistingtab.Click();

        }
        public void editskills()
        {
            editbtn.Click();
            savebtn.Click();
        }
        public void deleteskills() 
        {
            deletebtn.Click();
        }
    }
}
