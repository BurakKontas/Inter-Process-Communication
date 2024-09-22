using Excel = Microsoft.Office.Interop.Excel;

var excelApp = new Excel.Application();
var workbook = excelApp.Workbooks.Add();
var worksheet = workbook.Worksheets[1] as Excel.Worksheet;
worksheet.Cells[1, 1] = "Hello from COM";
excelApp.Visible = true;