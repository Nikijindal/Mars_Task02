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
    [Parallelizable]
    [TestFixture]
    public class ShareskillTest : CommonDriver
    {

        
        [Test]
        public void Shareskills()
        {
            HomePage homePageObj = new HomePage();
            homePageObj.gotoshareskillpage(driver);

            ShareskillPage shareskillObj = new ShareskillPage();
            shareskillObj.title();
            shareskillObj.description();
            shareskillObj.category();
            shareskillObj.subcategory();
            shareskillObj.tags();
            shareskillObj.srvctype();
            shareskillObj.locationtype();   
            shareskillObj.skilltrade();
            shareskillObj.skillexchange();
            shareskillObj.worksample();
            shareskillObj.active();
            shareskillObj.savebutton();

        }

    }
}
