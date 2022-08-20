namespace Infraestructure.Repositories;

public class SheetItemRepository : GenericRepository, ISheetItemRepository
{
    private readonly ILogger<SheetItemRepository> _logger;
    public SheetItemRepository(ILogger<SheetItemRepository> logger, string dpath) : base(logger, dpath)
    {
        _logger = logger;
    }

    public async Task<int> CreateSheetItemAsync(SheetItem sheetItem)
    {
        return await CreateAsync(sheetItem);
    }

    public async Task<IEnumerable<SheetItem>> GetAllSheetItemsAsync()
    {
        return await GetAllAsync<SheetItem>();
    }
}
