namespace Core.Interfaces
{
    public interface IExcelService
    {
        Task<bool> CreateWorkBookAsync();
    }
}
