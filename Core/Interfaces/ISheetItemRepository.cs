
namespace Core.Interfaces;
public interface ISheetItemRepository
{
    Task<int> CreateSheetItemAsync(SheetItem sheetItem);
    Task<IEnumerable<SheetItem>> GetAllSheetItemsAsync();
}
