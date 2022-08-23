namespace Infraestructure.Repositories;

public class SheetItemRepository : GenericRepository, ISheetItemRepository
{
    private readonly ILogger<SheetItemRepository> _logger;
    public SheetItemRepository(ILogger<SheetItemRepository> logger, string dpath) : base(logger, dpath)
    {
        _logger = logger;
    }

    public async Task<SheetItem> CreateSheetItemAsync(SheetItem sheetItem)
    {
        return await CreateAsync(sheetItem);
    }

    public async Task<SheetItem> UpdateSheetItemAsync(SheetItem sheetItem)
    {
        return await UpdateAsync(sheetItem);
    }

    public async Task<IEnumerable<SheetItem>> GetAllSheetItemsAsync()
    {
        return await GetAllAsync<SheetItem>();
    }

    public async Task<SheetItem> GetSheetByIdAsync(string sheetItemId)
    {
        return await GetByIdAsync<SheetItem>(sheetItemId);
    }

    public async Task<IEnumerable<SheetItem>> GetSheetItemsBySheetIdAsync(string sheetId)
    {
        var sheetItems =  await GetAllAsync<SheetItem>();
        return sheetItems.Where(x => x.SheetId.Equals(sheetId));
    }

    public async Task<SheetItem> DeleteSheetItemAsyncAsync(SheetItem sheet)
    {
        return await DeleteAsync(sheet);
    }

    public async Task<IEnumerable<SheetItem>> DeleteSheetItemsBySheetIdAsync(string sheetId)
    {
        var sheetItems = await GetSheetItemsBySheetIdAsync(sheetId);
        foreach (var i in sheetItems) await DeleteSheetItemAsyncAsync(i);
        return sheetItems;
    }

}
