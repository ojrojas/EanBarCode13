namespace Core.Interfaces;
public interface IWorkBookService
{
    Task<WorkBookCreateResponse> CreateWorkBookAsync(WorkBookCreateRequest request);
    Task<WorkBookGetAllResponse> GetAllWorkBookAsync(WorkBookGetAllRequest request);
    Task<WorkBookDeleteResponse> DeleteWorkBookAsync(WorkBookDeleteRequest request);
    }
