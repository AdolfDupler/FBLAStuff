using OfficeOpenXml;
using Spire.Xls;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MagicData.Classes
{
    public class ExcelExport
    {

        public static string TemplatePath;
        ExcelPackage pack;
        ExcelWorksheet sheet;
        public FileInfo fileinfo;

        public ExcelExport(string templatePath, string outputDir)
        {
            fileinfo = new FileInfo(@"Report.xlsx");
            FileInfo tempPath = new FileInfo(templatePath);
            
            pack = new ExcelPackage(fileinfo,tempPath);
            sheet = pack.Workbook.Worksheets.First();
            BuildReport();
            

        }
        public void BuildReport()
        {
            sheet.Cells["A4"].Value = "Nice";
            
        }
        public void SaveAndExport(bool excel, bool pdf)
        {
            pack.Save();
            pack.Dispose();
            if (pdf)
            {
                Workbook pdfWork = new Workbook();
                pdfWork.LoadFromFile(@"Report.xlsx");
                pdfWork.SaveToFile(fileinfo.FullName.Replace(".xlsx", ".pdf"), Spire.Xls.FileFormat.PDF);
            }
           
        }
    }
}
