using Mars_Task02.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars_Task02.Tests
{
    
    public class ManageskillTest
    {
        LoginPage loginPageObj= new LoginPage();
        HomePage homePageObj= new HomePage();   
        ManageskillsPage manageskillObj = new ManageskillsPage();

        [Test,Order(1)]
        public void Manageskill()
        {
            manageskillObj.viewskills();
            manageskillObj.editskills();
            manageskillObj.edittitle();
            manageskillObj.editdescription();
            manageskillObj.edittags();
            manageskillObj.deleteskills();
        }
    }
}
