using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExcelDataReader;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mars_Task02.Pages
{
    [TestClass]
    public class ExcelTesting
    {
        static DataSet mTestData;
       
       [ClassInitialize]

        public static void BeforeAllTests(TestContext testContext)
        {
            using (var stream = File.Open(@"C:\Users\nikit\OneDrive\Desktop\Book1.xlsx", FileMode.Open, FileAccess.Read))
            {
                // Auto-detect format, supports:
                //  - Binary Excel files (2.0-2003 format; *.xls)
                //  - OpenXml Excel files (2007 format; *.xlsx, *.xlsb)
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    mTestData =  reader.AsDataSet(new ExcelDataSetConfiguration()
                    {
                        ConfigureDataTable = (tableReader) => new ExcelDataTableConfiguration()
                        {
                            UseHeaderRow = true
                        }
                    }
                    );
                    
                }
                Console.WriteLine(mTestData);
            }
        }

        [TestMethod]
        public void LaunchExcel()
        {

        }
    }
}
