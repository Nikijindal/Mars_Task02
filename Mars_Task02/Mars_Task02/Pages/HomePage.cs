﻿using Mars_Task02.Utilities;
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
        
    
    public void gotoshareskillpage()
        {
            Thread.Sleep(5000);
            shareskillbtn.Click();
        }
        public void gotomanagelistingspage() 
        {
            Wait.WaitobeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[1]/div/a[3]", 10);
            managelistingstab.Click();
        }
    
    
    }


}
