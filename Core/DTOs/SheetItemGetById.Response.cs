namespace Core.DTOs
{
    public class SheetItemGetByIdResponse : BaseResponse
    {
        public SheetItemGetByIdResponse(Guid Correlation) : base(Correlation) { }
        public SheetItem SheetItem { get; set; }
    }
}
