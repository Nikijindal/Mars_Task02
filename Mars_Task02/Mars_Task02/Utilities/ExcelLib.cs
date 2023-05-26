using ExcelDataReader;
using System.Data;
using System.Text.Json.Serialization.Metadata;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using SharpCompress.Common;
using System.Runtime.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Mars_Task02.Utilities
{

    public class ExcelLib
    {
        static List<Datacollection> dataCol = new List<Datacollection>();
        private static DataTable ExcelToDataTable(string filename, string SheetName)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            // Open file and return as Stream
            using (var stream = File.Open(filename, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    var result = reader.AsDataSet(new ExcelDataSetConfiguration()
                    {
                        ConfigureDataTable = (data) => new ExcelDataTableConfiguration()
                        {
                            UseHeaderRow = true
                        }
                    });

                    //Get all the tables
                    var table = result.Tables;
                    // store it in data table
                    var resultTable = table[SheetName];
                    return resultTable;
                }
            }
            //    System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            //    FileStream stream = File.Open(filename, FileMode.Open, FileAccess.ReadWrite);
            //    IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);

            //    // excelReader.IsFirstRowAsColumnNames = true 

            //    DataSet resultSet = excelReader.AsDataSet(new ExcelDataSetConfiguration()
            //    {
            //        ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
            //        {
            //            UseHeaderRow = true
            //        }
            //    });
            //    DataTableCollection table = resultSet.Tables;
            //    DataTable resultTable = table[SheetName];
            //    return resultTable;
            }

            public static void ClearData()
        {
            dataCol.Clear();
        }



        public static void PopulateInCollection(string fileName,string SheetName)
        {
            ExcelLib.ClearData();
            DataTable table = ExcelToDataTable(fileName,SheetName);
            
            //Iterate through the rows and columns of the table
            for(int row = 1;row <=table.Rows.Count;row++)
            {
                for(int col = 0;col <table.Columns.Count;col++)
                {
                    Datacollection dtTable = new Datacollection()
                    {
                        rowNumber = row,
                        colName = table.Columns[col].ColumnName,
                        colValue = table.Rows[row - 1][col].ToString()
                    };
                    //add all the details for each row
                    dataCol.Add(dtTable);
                   
                }
            }
        }

        public static string ReadData(int rowNumber,string columnName) 
        {
            try
            {
                // Retriving Data using LINQ to reduce much of iterations
                rowNumber = rowNumber - 1;
                string data = (from colData in dataCol
                               where colData.colName== columnName && colData.rowNumber== rowNumber
                               select colData.colValue).SingleOrDefault();
                // var datas = dataCol.Where(x => x.columnName && x.rownumber == rowNumber).SingleOrDefault().colValue;
                return data.ToString();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occurred in ExcelLib Class ReadData Method!" + Environment.NewLine + e.Message.ToString());
                return null;
            }
        }
    }

    public class Datacollection
    {
        public int rowNumber { get; set; }
        public string colName { get; set; }
        public string colValue { get; set; }
    }

    
}
