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

    public async Task<SheetItemDeleteResponse> DeleteSheetItemAsync(SheetItemDeleteRequest request)
    {
        SheetItemDeleteResponse response = new(request.CorrelationId);
        response.SheetItemDeleted = await _sheetItemRepository.DeleteSheetItemAsyncAsync(request.SheetItemDelete);
        return response;
    }

    public async Task<SheetItemAllResponse> GetAllSheetItemsAsync(SheetItemAllRequest request)
    {
        SheetItemAllResponse response = new(request.CorrelationId);
        response.SheetItems = await _sheetItemRepository.GetAllSheetItemsAsync();
        return response;
    }

    public async Task<SheetItemsGetBySheetIdResponse> GetAllSheetItemsBySheetIdAsync(SheetItemsGetBySheetIdRequest request)
    {
        SheetItemsGetBySheetIdResponse response = new(request.CorrelationId);
        response.SheetItems = await _sheetItemRepository.GetSheetItemsBySheetIdAsync(request.SheetId);
        return response;
    }

    public async Task<SheetItemsGetBySheetIdResponse> GetSheetItemByIdAsync(SheetItemsGetBySheetIdRequest request)
    {
        SheetItemsGetBySheetIdResponse response = new(request.CorrelationId);
        response.SheetItems = await _sheetItemRepository.GetSheetItemsBySheetIdAsync(request.SheetId);
        throw new NotImplementedException();
    }

    public async Task<SheetItemUpdateResponse> UpdateSheetItemAsync(SheetItemUpdateRequest request)
    {
        SheetItemUpdateResponse response = new(request.CorrelationId);
        response.SheetItemUpdated = await _sheetItemRepository.UpdateSheetItemAsync(request.SheetItemUpdate);
        return response;
    }

    public async Task<SheetItemsDeleteBySheetIdResponse> DeleteSheetItemsBySheetIdAsync(SheetItemsDeleteBySheetIdRequest request)
    {
        SheetItemsDeleteBySheetIdResponse response = new(request.CorrelationId);
        response.SheetItems = await _sheetItemRepository.DeleteSheetItemsBySheetIdAsync(request.SheetId);
        return response;
    }
}
