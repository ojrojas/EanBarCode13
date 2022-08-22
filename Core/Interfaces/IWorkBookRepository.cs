namespace Core.Interfaces;

public interface IWorkBookRepository
{
    Task<WorkBook> CreateWorkBookAsync(WorkBook entity);
    Task<WorkBook> DeleteWorkBookAsync(WorkBook workBook);
    Task<IEnumerable<WorkBook>> GetAllWorkBooksAsync();
    Task<WorkBook> GetWorkBookByIdAsync(string workBookId);
}