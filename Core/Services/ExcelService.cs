using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using System.Globalization;
using Cell = DocumentFormat.OpenXml.Spreadsheet.Cell;

namespace Core.Services
{
    public class ExcelService : IExcelService
    {
        private readonly IWorkBookService _workbookService;
        private readonly ISheetService _sheetService;
        private readonly ISheetItemService _sheetItemService;

        public ExcelService(IWorkBookService workbookService, ISheetService sheetService, ISheetItemService sheetItemService)
        {
            _workbookService = workbookService ?? throw new ArgumentNullException(nameof(workbookService));
            _sheetService = sheetService ?? throw new ArgumentNullException(nameof(sheetService));
            _sheetItemService = sheetItemService ?? throw new ArgumentNullException(nameof(sheetItemService));
        }

        public async Task<bool> CreateWorkBookAsync()
        {
            var filecharged = await OpenFileWorkBook();

            if (filecharged is null) return false;

            using var document = SpreadsheetDocument.Open(filecharged.FullPath, true);
            WorkbookPart workbookPart = document.WorkbookPart;
            SharedStringTablePart sstpart = workbookPart.GetPartsOfType<SharedStringTablePart>().First();
            SharedStringTable sst = sstpart.SharedStringTable;

            var workbook = await _workbookService.CreateWorkBookAsync(new()
            {
                WorkBook = new()
                {
                    Name = filecharged.FileName,
                    Date = DateTime.Now
                }
            });

            var index = default(int);
            foreach (var worksheetPart in workbookPart.WorksheetParts)
            {
                Worksheet sheet = worksheetPart.Worksheet;
                var nameSheet = workbookPart.Workbook.Descendants<DocumentFormat.OpenXml.Spreadsheet.Sheet>().ElementAt(index).Name;
                var rows = sheet.Descendants<Row>();

                var sheetId = await _sheetService.CreateSheetAsync(
                    new()
                    {
                        Sheet = new()
                        {
                            Name = nameSheet,
                            Position = 0,
                            Quantity = rows.Count() -1,
                            WorkBookId = workbook.WorkBookCreated.Id
                        }
                    });


                Console.WriteLine("Row count = {0}", rows.LongCount());

                foreach (Row row in rows)
                {
                    if (row.RowIndex == 1) continue;
                    var cell1 = row.Elements<Cell>().FirstOrDefault();
                    var cell2 = row.Elements<Cell>().LastOrDefault();

                    int ssid = int.Parse(cell2.CellValue.Text);
                    string str = sst.ChildElements[ssid].InnerText;
                    var value = cell1.CellValue;
                    var stringValue = double.Parse(value.InnerText).ToString("F0", CultureInfo.InvariantCulture).Substring(0, 13).PadLeft(13, '0');
                    Console.WriteLine("Shared string {0}: {1}", str, stringValue);
                    await _sheetItemService.CreateSheetItemAsync(new() { SheetItem = new() { Code = stringValue, Name = str, SheetId = sheetId.SheetCreated.Id, IsLooked = false } });
                }

                index++;
            }
            return true;
        }

        private async Task<FileResult> OpenFileWorkBook()
        {
            try
            {
                var result = await FilePicker.Default.PickAsync(await OptionsActions());
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return null;
        }

        private async Task<PickOptions> OptionsActions()
        {
            FilePickerFileType customFileType = new(
                    new Dictionary<DevicePlatform, IEnumerable<string>>
                    {
                    { DevicePlatform.iOS, new[] { "public.my.eanbarcode.extension" } }, // or general UTType values
                    { DevicePlatform.Android, new[] { "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "application/vnd.ms-excel" } },
                    { DevicePlatform.WinUI, new[] { ".xls", ".xlsx" } },
                    { DevicePlatform.Tizen, new[] { "*/*", ".xls", ".xlsx" } },
                    { DevicePlatform.macOS, new[] { "xls", "xlsx" } }, // or general UTType values
                    });

            await Task.Yield();

            PickOptions options = new()
            {
                PickerTitle = "Please select your workbook file",
                FileTypes = customFileType,
            };

            return options;
        }
    }
}
