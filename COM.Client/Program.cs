using Excel = Microsoft.Office.Interop.Excel;

var excelApp = new Excel.Application();
var workbook = excelApp.Workbooks.Open(@"C:\path\to\your\excel\file.xlsx");
var worksheet = workbook.Worksheets[1] as Excel.Worksheet;
string value = worksheet.Cells[1, 1].ToString();
Console.WriteLine("Value from Excel: " + value);
