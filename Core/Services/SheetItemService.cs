namespace Core.Services;

public class SheetItemService : ISheetItemService
{
    private readonly ISheetItemRepository _sheetItemRepository;

    public SheetItemService(ISheetItemRepository sheetItemRepository)
    {
        _sheetItemRepository = sheetItemRepository;
    }

    public async Task<int> CreateSheetItemAsync(SheetItem sheetItem)
    {
        return await _sheetItemRepository.CreateSheetItemAsync(sheetItem);
    }

    public Task<int> DeleteSheetItemAsync(int sheetItemId)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<SheetItem>> GetAllSheetItemsAsync()
    {
        return await _sheetItemRepository.GetAllSheetItemsAsync();
    }

    public Task<IEnumerable<SheetItem>> GetAllSheetItemsBySheetIdAsync(int sheedId)
    {
        throw new NotImplementedException();
    }

    public Task<SheetItem> GetSheetItemByIdAsync(int sheetItemId)
    {
        throw new NotImplementedException();
    }
}
