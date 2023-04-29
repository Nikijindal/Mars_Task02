using Mars_Task02.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using AutoItX3Lib;
using AutoIt;




namespace Mars_Task02.Pages
{
    public class ShareskillPage : CommonDriver
    {
        private IWebElement titletxt => driver.FindElement(By.Name("title"));
        private IWebElement desctxtbox => driver.FindElement(By.Name("description"));
        private IWebElement categoryfind => driver.FindElement(By.Name("categoryId"));
        private IWebElement categoryselect => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[3]/div[2]/div/div[1]/select/option[7]"));
        private IWebElement subcategoryfind => driver.FindElement(By.Name("subcategoryId"));
        private IWebElement subcategoryselect => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[3]/div[2]/div/div[2]/div[1]/select/option[5]"));
        private IWebElement tagstxt => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[4]/div[2]/div/div/div/div/input"));
        private IWebElement serviceRbtn => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[5]/div[2]/div[1]/div[1]/div/input"));
        private IWebElement locRbtn => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[6]/div[2]/div/div[2]/div/input"));
        private IWebElement skilltradeRbtn => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[8]/div[2]/div/div[1]/div/input"));
        private IWebElement skillexctxtbox => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[8]/div[4]/div/div/div/div/div/input"));
        private IWebElement wrksampleselect => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[9]/div/div[2]/section/div/label/div/span/i"));
        private IWebElement activeRbtn => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[10]/div[2]/div/div[1]/div/input"));
        private IWebElement savebtn => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[11]/div/input[1]"));

        public void title()
        {
            Wait.WaitobeClickable(driver, "Name", "title", 5);
            titletxt.SendKeys("Software Testing");
        }
        public void description()
        {
            Wait.WaitobeClickable(driver, "Name", "description", 5);
            desctxtbox.SendKeys("Providing testing services as a begineer level");
        }
        public void category()
        {
            Wait.WaitobeClickable(driver, "Name", "categoryId", 5);
            SelectElement categorydrpdwn = new SelectElement(categoryfind);
            categorydrpdwn.SelectByValue("6");
        }
        public void subcategory()
        {
            Wait.WaitobeClickable(driver, "Name", "subcategoryId", 5);
            SelectElement subcategorydrpdwn = new SelectElement(subcategoryfind);
            subcategorydrpdwn.SelectByValue("4");
        }
        public void tags()
        {
            Wait.WaitobeClickable(driver, "XPath", "\"//*[@id=\\\"service-listing-section\\\"]/div[2]/div/form/div[4]/div[2]/div/div/div/div/input\"", 5);
            tagstxt.SendKeys("Professionalism" + "\n");
        }
        public void srvctype()
        {
            Wait.WaitobeClickable(driver, "XPath", "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[5]/div[2]/div[1]/div[1]/div/input", 5);
            serviceRbtn.Click();
            
        }
        public void locationtype()
        {
            Wait.WaitobeClickable(driver, "XPath", "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[6]/div[2]/div/div[2]/div/input", 5);
            locRbtn.Click();
        }
        public void skilltrade()
        {
            Wait.WaitobeClickable(driver, "XPath", "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[8]/div[2]/div/div[1]/div/input", 5);
            skilltradeRbtn.Click();
        }
        public void skillexchange()
        {
            Wait.WaitobeClickable(driver, "XPath", "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[8]/div[4]/div/div/div/div/div/input", 5);
            skillexctxtbox.SendKeys("Interpersonal skills" + "\n");
            skillexctxtbox.SendKeys("Communicator" + "\n");
            skillexctxtbox.SendKeys("leadership skills" + "\n");
            skillexctxtbox.SendKeys("Team player" + "\n");
        }
        public void worksample()
        {
            //After winActiavte do not move from focussed window
            //Otherwise the script will run the command on the newly focused window.
            wrksampleselect.Click();
            AutoItX3 autoIt = new AutoItX3();
            Thread.Sleep(1000);
            autoIt.WinActivate("Open");
            Thread.Sleep(1000);
            autoIt.Send("C:\\Users\\nikit\\QA-Analyst-small.png");
            Thread.Sleep(1000);   
            autoIt.Send("{ENTER}");
        }
        public void active()
        {
            Wait.WaitobeClickable(driver, "XPath", "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[10]/div[2]/div/div[1]/div/input", 5);
            activeRbtn.Click();
        }
        public void savebutton()
        {
            Wait.WaitobeClickable(driver, "XPath", "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[11]/div/input[1]", 5);
            savebtn.Click();
        }
    }   
}
