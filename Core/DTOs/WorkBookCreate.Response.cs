namespace Core.DTOs
{
    public class WorkBookCreateResponse: BaseResponse
    {
        public WorkBookCreateResponse(Guid Correlation) : base(Correlation) {}

        public int WorkBookId { get; set; }

    }
}
