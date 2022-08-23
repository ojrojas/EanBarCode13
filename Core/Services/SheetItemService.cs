namespace Core.Services;


public class SheetItemService : ISheetItemService
{
    private readonly ISheetItemRepository _sheetItemRepository;

    public SheetItemService(ISheetItemRepository sheetItemRepository)
    {
        _sheetItemRepository = sheetItemRepository;
    }

    public async Task<SheetItemCreateResponse> CreateSheetItemAsync(SheetItemCreateRequest request)
    {
        SheetItemCreateResponse response = new(request.CorrelationId);
        response.SheetItemCreated = await _sheetItemRepository.CreateSheetItemAsync(request.SheetItem);
        return response;
    }

    public Task<int> DeleteSheetItemAsync(string sheetItemId)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<SheetItem>> GetAllSheetItemsAsync()
    {
        return await _sheetItemRepository.GetAllSheetItemsAsync();
    }

    public async Task<IEnumerable<SheetItem>> GetAllSheetItemsBySheetIdAsync(string sheedId)
    {
        return await _sheetItemRepository.GetSheetItemsBySheetIdAsync(sheedId);
    }

    public Task<SheetItem> GetSheetItemByIdAsync(string sheetItemId)
    {
        throw new NotImplementedException();
    }

    public async Task<SheetItem> UpdateSheetItemAsync(SheetItem sheetItem)
    {
        return await _sheetItemRepository.UpdateSheetItemAsync(sheetItem);
    }
}
