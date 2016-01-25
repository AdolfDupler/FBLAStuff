using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MagicData.Classes
{
    public class ExcelExport
    {

        ExcelPackage pack;
        ExcelWorksheet sheet;

        public ExcelExport(string templatePath, string outputDir)
        {
            FileInfo outPath = new FileInfo(outputDir);
            FileInfo tempPath = new FileInfo(templatePath);
            pack = new ExcelPackage(outPath,tempPath);
            sheet = pack.Workbook.Worksheets.First();
            BuildReport();
            

        }
        public void BuildReport()
        {
            sheet.Cells["A4"].Value = "Nice";
            
        }
        public void ToPdf(string path)
        {
            
            pack.SaveAs(new FileInfo(path));
            
        }
        public void ToXLSX()
        {
            pack.Save();
        }
    }
}
