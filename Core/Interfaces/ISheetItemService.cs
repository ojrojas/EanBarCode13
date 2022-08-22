namespace Core.Interfaces;

public interface ISheetItemService
{
    Task<SheetItemCreateResponse> CreateSheetItemAsync(SheetItemCreateRequest request);
    Task<int> DeleteSheetItemAsync(string sheetItemId);
    Task<IEnumerable<SheetItem>> GetAllSheetItemsAsync();
    Task<IEnumerable<SheetItem>> GetAllSheetItemsBySheetIdAsync(string sheedId);
    Task<SheetItem> GetSheetItemByIdAsync(string sheetItemId);
}