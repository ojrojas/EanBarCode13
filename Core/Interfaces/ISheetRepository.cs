
namespace Core.Interfaces;
public interface ISheetRepository
{
    Task<int> CreateSheetAsync(Sheet entity);
    Task<IEnumerable<Sheet>> GetAllSheetByWorkBookIdAsync(int workBookId);
    Task<int> UpdateSheetAsync(Sheet entity);
    Task<Sheet> GetAllSheetByIdAsync(int sheetId);
}
