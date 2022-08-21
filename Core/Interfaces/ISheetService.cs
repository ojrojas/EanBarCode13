namespace Core.Interfaces
{
    public interface ISheetService
    {
        Task<SheetCreateResponse> CreateSheetAsync(SheetCreateRequest request);
        Task<SheetGetByIdResponse> GetSheetByIdAsync(SheetGetByIdRequest request);
        Task<SheetUpdateResponse> UpdateSheetAsync(SheetUpdateRequest request);
    }
}
