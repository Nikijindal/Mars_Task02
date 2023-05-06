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
        private IWebElement viewbtn => driver.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr[first()]/td[8]/div/button[1]/i"));
        private IWebElement editbtn => driver.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr[first()]/td[8]/div/button[2]/i"));
        private IWebElement deletebtn => driver.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr[first()]/td[8]/div/button[3]/i"));
        private IWebElement mnglistingtab => driver.FindElement(By.XPath("//*[@id=\"service-detail-section\"]/section[1]/div/a[3]"));
        private IWebElement savebtn => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[11]/div/input[1]"));
        private IWebElement MlPopUp => driver.FindElement(By.CssSelector("[class=\"ns-box ns-growl ns-effect-jelly ns-type-success ns-show\"]"));
        private IWebElement Mltitle => driver.FindElement(By.Name("title"));
        private IWebElement MlDesc => driver.FindElement(By.Name("description"));
        private IWebElement Mltags => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[4]/div[2]/div/div/div/div/input"));
        public void viewskills()
        {

            viewbtn.Click();
            mnglistingtab.Click();

        }
        public void editskills()
        {
            editbtn.Click();
        }
        public void edittitle()
        {
           Mltitle.SendKeys("Software Tester");
        }
        public void editdescription()
        {
        MlDesc.SendKeys("Providing testing services at begineer level");
        }
        public void edittags()
        {
        Mltags.SendKeys("Attention to details" + "\n");
        savebtn.Click();
        mnglistingtab.Click();
        }
        
        public void deleteskills() 
        {
            deletebtn.Click();


        }
    }
}
