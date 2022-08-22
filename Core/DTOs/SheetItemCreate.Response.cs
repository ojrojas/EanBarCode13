namespace Core.DTOs
{
    public class SheetItemCreateResponse : BaseResponse
    {
        public SheetItemCreateResponse(Guid Correlation) : base(Correlation) { }
        public SheetItem SheetItemCreated { get; set; }
    }
}
