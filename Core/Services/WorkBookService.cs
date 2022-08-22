namespace Core.Services;

public class WorkBookService : IWorkBookService
{
    private readonly IWorkBookRepository _workBookRepository;
    private readonly ISheetRepository _sheetRepository;

    public WorkBookService(IWorkBookRepository workBookRepository, ISheetRepository sheetRepository)
    {
        _workBookRepository = workBookRepository ?? throw new ArgumentNullException(nameof(workBookRepository));
        _sheetRepository = sheetRepository ?? throw new ArgumentNullException(nameof(sheetRepository));
    }

    public async Task<WorkBookCreateResponse> CreateWorkBookAsync(WorkBookCreateRequest request)
    {
        WorkBookCreateResponse response = new(request.CorrelationId);
        response.WorkBookCreated = await _workBookRepository.CreateWorkBookAsync(request.WorkBook);
        response.Message = response.WorkBookCreated.Equals(default) ? "Error to create WorkBook": "WorkBook Create";
        return response;
    }

    public async Task<WorkBookGetAllResponse> GetAllWorkBookAsync(WorkBookGetAllRequest request)
    {
        WorkBookGetAllResponse response = new(request.CorrelationId);
        var result = await _workBookRepository.GetAllWorkBooksAsync();
        var list = new List<WorkBookDto>();
        foreach(var i in result)
        {
            list.Add(new WorkBookDto { Id = i.Id, Name = i.Name, Date = i.Date, Sheets = await GetListSheetByWorkBookId(i.Id) });
        }
        response.WorkBooks = list;

        response.Message = !response.WorkBooks.Any() ? "Request no get results" : "Get all registers";
        return response;
    }


    public async Task<WorkBookDeleteResponse> DeleteWorkBookAsync(WorkBookDeleteRequest request)
    {
        WorkBookDeleteResponse response = new(request.CorrelationId);
        var found = await _workBookRepository.GetWorkBookByIdAsync(request.Id);
        response.WorkBookDeleted = await _workBookRepository.DeleteWorkBookAsync(found);
        return response;
    }

    private async Task<List<Sheet>> GetListSheetByWorkBookId(string workbookId)
    {
        var sheets = await _sheetRepository.GetAllSheetByWorkBookIdAsync(workbookId);
        if (sheets.Any())
            return sheets.ToList();
        return new List<Sheet>();
    }
}
