namespace Core.DTOs
{
    public class SheetDeleteResponse: BaseResponse
    {
        public SheetDeleteResponse(Guid Correlation): base(Correlation) { }
        public Sheet SheetDeleted { get; set; }
    }
}
