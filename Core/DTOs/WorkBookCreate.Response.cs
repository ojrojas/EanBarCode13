namespace Core.DTOs
{
    public class WorkBookCreateResponse: BaseResponse
    {
        public WorkBookCreateResponse(Guid Correlation) : base(Correlation) {}

        public WorkBook WorkBookCreated { get; set; }

    }
}
