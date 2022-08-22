namespace Infraestructure.Data;

public abstract class GenericRepository
{
    /// <summary>
    /// Logger application debug environment
    /// </summary>
    private readonly ILogger<GenericRepository> _logger;
    /// <summary>
    /// _connection sqlite file 
    /// </summary>
    private readonly SQLiteAsyncConnection _connection;

    /// <summary>
    /// Constructor Base logger and dpath file sqlite
    /// </summary>
    /// <param name="logger">Logger Application</param>
    /// <param name="dpath">Location file sqlite</param>
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

    /// <summary>
    /// Create async entity model
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="entity">Entity model to insert async</param>
    /// <returns>Entity registered</returns>
    public async Task<T> CreateAsync<T>(T entity) where T : new()
    {
        _logger.LogInformation($"Insert data entity ");
        var isInserted =  await _connection.InsertAsync(entity);
        if(isInserted is not default(int))
        {
            return entity;
        }
        
        return default;
    }

    /// <summary>
    /// Update async entity model
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="entity">Entity updated</param>
    /// <returns>Entity updated new params</returns>
    public async Task<T> UpdateAsync<T>(T entity) where T : new()
    {
        _logger.LogInformation($"Updated data entity ");
        var isUpdated =  await _connection.UpdateAsync(entity);
        if (isUpdated is not default(int))
        {
            return entity;
        }

        return default;
    }

    /// <summary>
    /// Delete async entity 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="entity">Entity to delete from table</param>
    /// <returns>Entity deleted</returns>
    public async Task<T> DeleteAsync<T>(T entity) where T : new()
    {
        _logger.LogInformation($"Delete item data entity ");
        var isDeleted =  await _connection.DeleteAsync(entity);
        if (isDeleted is not default(int))
        {
            return entity;
        }

        return default;
    }

    /// <summary>
    /// Get by id async 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="id">id type guid id </param>
    /// <returns>Entity request by id</returns>
    public async Task<T> GetByIdAsync<T>(string id) where T : new()
    {
        _logger.LogInformation($"Get item data entity by id {id} typeof {typeof(T)}");
        var mapping = await _connection.GetMappingAsync<T>();
        return (T)await _connection.GetAsync(id, mapping);
    }

    /// <summary>
    /// Get all async records 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns>List entities request</returns>
    public async Task<IEnumerable<T>> GetAllAsync<T>() where T : new()
    {
        _logger.LogInformation($"Get all items data entity typeof {typeof(T)} ");
        return await _connection.Table<T>().ToListAsync();
    }
}
