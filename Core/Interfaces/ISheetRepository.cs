
namespace Core.Interfaces;
public interface ISheetRepository
{
    Task<int> CreateSheetAsync(Sheet entity);
    Task<IEnumerable<Sheet>> GetAllSheetByWorkBookId(int workBookId);
}
