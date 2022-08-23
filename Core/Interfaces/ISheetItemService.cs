namespace Core.Interfaces;

public interface ISheetItemService
{
    Task<SheetItemCreateResponse> CreateSheetItemAsync(SheetItemCreateRequest request);
    Task<SheetItemDeleteResponse> DeleteSheetItemAsync(SheetItemDeleteRequest request);
    Task<SheetItemAllResponse> GetAllSheetItemsAsync(SheetItemAllRequest request);
    Task<SheetItemsGetBySheetIdResponse> GetAllSheetItemsBySheetIdAsync(SheetItemsGetBySheetIdRequest request);
    Task<SheetItemsGetBySheetIdResponse> GetSheetItemByIdAsync(SheetItemsGetBySheetIdRequest request);
    Task<SheetItemUpdateResponse> UpdateSheetItemAsync(SheetItemUpdateRequest request);
}