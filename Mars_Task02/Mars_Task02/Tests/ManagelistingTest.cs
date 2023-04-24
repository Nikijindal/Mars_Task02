using Mars_Task02.Pages;
using Mars_Task02.Utilities;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars_Task02.Tests
{
    public class ManagelistingTest : CommonDriver
    {
        
        [Test]
        public void Shareskills()
        {
            HomePage homePageObj = new HomePage();
            homePageObj.gotoshareskillpage(driver);

            ManageskillsPage manageskillObj = new ManageskillsPage();
            
        }
    }
}
