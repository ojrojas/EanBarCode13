namespace Core.Interfaces;
public interface ISheetRepository
{
    Task<Sheet> CreateSheetAsync(Sheet entity);
    Task<Sheet> GetAllSheetByIdAsync(string sheetId);
    Task<IEnumerable<Sheet>> GetAllSheetByWorkBookIdAsync(string workBookId);
    Task<Sheet> UpdateSheetAsync(Sheet entity);
}