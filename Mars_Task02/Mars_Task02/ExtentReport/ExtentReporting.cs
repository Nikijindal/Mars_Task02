using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Mars_Task02.ExtentReport
{
    public class ExtentReporting
    {
        private static ExtentTest test;
        private static ExtentReports extent;
       

        private static ExtentReports ExtentStart()
        {
            var path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"..\..\..\..\Result\";
            
            if (extent == null)
            {
                Directory.CreateDirectory(path);
                extent = new ExtentReports();
                var htmlReporter = new ExtentHtmlReporter(path);
                extent.AttachReporter(htmlReporter);
            }
            return extent;  

        }

        public static void CreateTest(string testName)
        {
            test = ExtentStart().CreateTest(testName);
        }

        public static void EndReporting()
        {
            ExtentStart().Flush();
        }

        public static void LogPass(string info)
        {
            test.Pass(info);
        }

        public static void LogFail(string info)
        {
            test.Fail(info);
        }

        public static void LogInfo(string info)
        {
           test.Info(info);
        }

        public static void LogScreenShot(string info, string image)
        {
            test.Info(info, MediaEntityBuilder.CreateScreenCaptureFromBase64String(image).Build());
        }
    }
}
