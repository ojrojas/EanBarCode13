namespace Infraestructure.Repositories;


public class WorkBookRepository : GenericRepository, IWorkBookRepository
{
    private readonly ILogger<WorkBookRepository> _logger;

    public WorkBookRepository(ILogger<WorkBookRepository> logger, string dpath) : base(logger, dpath)
    {
        _logger = logger;
    }

    public async Task<IEnumerable<WorkBook>> GetAllWorkBooksAsync()
    {
        return await GetAllAsync<WorkBook>();
    }

    public async Task<WorkBook> CreateWorkBookAsync(WorkBook entity)
    {
        return await CreateAsync(entity);
    }

    public async Task<WorkBook> DeleteWorkBookAsync(WorkBook workBook)
    {
        return await DeleteAsync(workBook);
    }

    public async Task<WorkBook> GetWorkBookByIdAsync(string workBookId)
    {
        return await GetByIdAsync<WorkBook>(workBookId);
    }
}
