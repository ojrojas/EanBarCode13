
namespace Core.Interfaces;
public interface ISheetItemRepository
{
    Task<SheetItem> CreateSheetItemAsync(SheetItem sheetItem);
    Task<IEnumerable<SheetItem>> GetAllSheetItemsAsync();
}
