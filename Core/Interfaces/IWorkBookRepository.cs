namespace Core.Interfaces;

public interface IWorkBookRepository
{
    Task<int> CreateWorkBookAsync(WorkBook entity);
    Task<IEnumerable<WorkBook>> GetAllWorkBooksAsync();
    Task<int> DeleteWorkBookAsync(WorkBook entity);
    Task<WorkBook> GetWorkBookByIdAsync(int workBookId);
}
