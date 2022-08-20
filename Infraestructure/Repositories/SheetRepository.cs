namespace Infraestructure.Repositories;

public class SheetRepository : GenericRepository, ISheetRepository
{
    private readonly ILogger<SheetRepository> _logger;
    public SheetRepository(ILogger<SheetRepository> logger, string dpath) : base(logger, dpath)
    {
        _logger = logger;
    }

    public async Task<int> CreateSheetAsync(Sheet entity)
    {
        _logger.LogInformation($"Create entity type of {typeof(Sheet)} value");
        return await CreateAsync(entity);
    }

    public async Task<IEnumerable<Sheet>> GetAllSheetByWorkBookId(int workBookId)
    {
        _logger.LogInformation($"Get all sheets by workbook id {workBookId}");
        var result =  await GetAllAsync<Sheet>();
        return result .Where(x => x.WorkBookId == workBookId);
    }
}
