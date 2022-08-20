namespace Infraestructure.Data;

public abstract class GenericRepository
{
    private readonly ILogger<GenericRepository> _logger;
    private readonly SQLiteAsyncConnection _connection;

    public GenericRepository(ILogger<GenericRepository> logger, string dpath)
    {
        _logger = logger;
        try
        {
            _connection = new SQLiteAsyncConnection(dpath);
            _connection.CreateTableAsync<WorkBook>();
            _connection.CreateTableAsync<Sheet>();
            _connection.CreateTableAsync<SheetItem>();
            _logger.LogInformation(nameof(SheetItem));
        }
        catch (Exception ex)
        {
            _logger.LogInformation(ex.Message);
        }
    }

    public async Task<int> CreateAsync<T>(T entity) where T : new()
    {
        _logger.LogInformation($"Insert data entity ");
        return await _connection.InsertAsync(entity);
    }

    public async Task<int> UpdateAsync<T>(T entity) where T : new()
    {
        _logger.LogInformation($"Updated data entity ");
        return await _connection.UpdateAsync(entity);
    }

    public async Task<int> DeleteAsync<T>(T entity) where T : new()
    {
        _logger.LogInformation($"Delete item data entity ");
        return await _connection.DeleteAsync(entity);
    }

    public async Task<T> GetByIdAsync<T>(int id) where T : new()
    {
        _logger.LogInformation($"Get item data entity by id {id} typeof {typeof(T)}");
        var mapping = await _connection.GetMappingAsync<T>();
        return (T)await _connection.GetAsync(id, mapping);
    }

    public async Task<IEnumerable<T>> GetAllAsync<T>() where T : new()
    {
        _logger.LogInformation($"Get all items data entity typeof {typeof(T)} ");
        return await _connection.Table<T>().ToListAsync();
    }
}
