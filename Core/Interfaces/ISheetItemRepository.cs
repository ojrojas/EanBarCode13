
namespace Core.Interfaces;
public interface ISheetItemRepository
{
    Task<SheetItem> CreateSheetItemAsync(SheetItem sheetItem);
    Task<IEnumerable<SheetItem>> GetAllSheetItemsAsync();
    Task<IEnumerable<SheetItem>> GetSheetItemsBySheetIdAsync(string sheetId);
    Task<SheetItem> GetSheetByIdAsync(string sheetItemId);
    Task<SheetItem> UpdateSheetItemAsync(SheetItem sheetItem);
    Task<SheetItem> DeleteSheetItemAsyncAsync(SheetItem sheet);
    Task<IEnumerable<SheetItem>> DeleteSheetItemsBySheetIdAsync(string sheetId);
}
