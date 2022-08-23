
namespace Core.Interfaces;
public interface ISheetItemRepository
{
    Task<SheetItem> CreateSheetItemAsync(SheetItem sheetItem);
    Task<IEnumerable<SheetItem>> GetAllSheetItemsAsync();
    Task<IEnumerable<SheetItem>> GetSheetItemsBySheetIdAsync(string sheetId);
    Task<SheetItem> UpdateSheetItemAsync(SheetItem sheetItem);
}
