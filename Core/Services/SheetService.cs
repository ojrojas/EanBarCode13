namespace Core.Services
{
    public class SheetService : ISheetService
    {
        private readonly ISheetRepository _repository;

        public SheetService(ISheetRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public async Task<SheetCreateResponse> CreateSheetAsync(SheetCreateRequest request)
        {
            SheetCreateResponse response = new(request.CorrelationId);
            response.SheetCreated = await _repository.CreateSheetAsync(request.Sheet);
            return response;
        }

        public async Task<SheetUpdateResponse> UpdateSheetAsync(SheetUpdateRequest request)
        {
            SheetUpdateResponse response = new(request.CorrelationId);
            response.SheetUpdated = await _repository.UpdateSheetAsync(request.Sheet);
            return response;
        }

        public async Task<SheetGetByIdResponse> GetSheetByIdAsync(SheetGetByIdRequest request)
        {
            SheetGetByIdResponse response = new(request.CorrelationId);
            response.Sheet = await _repository.GetAllSheetByIdAsync(request.SheetId);
            return response;
        }
    }
}
