namespace Core.DTOs
{
    public class WorkBookDeleteResponse : BaseResponse
    {
        public WorkBookDeleteResponse(Guid Correlation): base(Correlation) { }

        public WorkBook WorkBookDeleted { get; set; }

    }
}
