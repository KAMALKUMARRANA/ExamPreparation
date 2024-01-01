using Microsoft.JSInterop;
using OfficeOpenXml;
using OfficeOpenXml.Style;

namespace PEMS_UI.Data
{
    public class Student
    {
        public void GenerateExcel(IJSRuntime iJSRuntime)
        {
            byte[] fileContents;
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (var package = new ExcelPackage())
            {
                var workSheet = package.Workbook.Worksheets.Add("Sheet1");

                #region Header Row
                workSheet.Cells[1, 1].Value = "Student Name";
                workSheet.Cells[1, 1].Style.Font.Size = 12;
                workSheet.Cells[1, 1].Style.Font.Bold = true;
                workSheet.Cells[1, 1].Style.Border.Top.Style = ExcelBorderStyle.Hair;

                workSheet.Cells[1, 1].Value = "Student Roll";
                workSheet.Cells[1, 1].Style.Font.Size = 12;
                workSheet.Cells[1, 1].Style.Font.Bold = true;
                workSheet.Cells[1, 1].Style.Border.Top.Style = ExcelBorderStyle.Hair;
                #endregion

                #region Body 1st Row
                workSheet.Cells[2, 1].Value = "Kamal";
                workSheet.Cells[2, 1].Style.Font.Size = 12;
                workSheet.Cells[2, 1].Style.Font.Bold = true;
                workSheet.Cells[2, 1].Style.Border.Top.Style = ExcelBorderStyle.Hair;

                workSheet.Cells[2, 2].Value = "100";
                workSheet.Cells[2, 2].Style.Font.Size = 12;
                workSheet.Cells[2, 2].Style.Font.Bold = true;
                workSheet.Cells[2, 2].Style.Border.Top.Style = ExcelBorderStyle.Hair;
                #endregion

                fileContents = package.GetAsByteArray();
            }
            iJSRuntime.InvokeAsync<Student>(
               "saveAsFile",
               "Student_List.xlsx",
               Convert.ToBase64String(fileContents)

                ) ;

        }
    }
}

