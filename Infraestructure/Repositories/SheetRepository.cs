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

    public async Task<int> UpdateSheetAsync(Sheet entity)
    {
        _logger.LogInformation($"Create entity type of {typeof(Sheet)} value");
        return await UpdateAsync(entity);
    }

    public async Task<IEnumerable<Sheet>> GetAllSheetByWorkBookIdAsync(int workBookId)
    {
        _logger.LogInformation($"Get all sheets by workbook id {workBookId}");
        var result =  await GetAllAsync<Sheet>();
        return result .Where(x => x.WorkBookId == workBookId);
    }

    public async Task<Sheet> GetAllSheetByIdAsync(int sheetId)
    {
        _logger.LogInformation($"Get all sheets by workbook id {sheetId}");
        var result = await GetAllAsync<Sheet>();
        return result.Where(x => x.Id == sheetId).FirstOrDefault();
    }
}
