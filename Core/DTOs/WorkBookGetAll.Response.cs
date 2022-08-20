namespace Core.DTOs
{
    public class WorkBookGetAllResponse : BaseResponse
    {
        public WorkBookGetAllResponse (Guid Correlation) : base(Correlation)  {}
        public IEnumerable<WorkBookDto> WorkBooks{ get; set; }
       
    }
}
