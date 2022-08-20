namespace Core.Interfaces;

public interface ISheetItemService
{
    Task<int> CreateSheetItemAsync(SheetItem sheetItem);
    Task<int> DeleteSheetItemAsync(int sheetItemId);
    Task<IEnumerable<SheetItem>> GetAllSheetItemsAsync();
    Task<IEnumerable<SheetItem>> GetAllSheetItemsBySheetIdAsync(int sheedId);
    Task<SheetItem> GetSheetItemByIdAsync(int sheetItemId);
}
