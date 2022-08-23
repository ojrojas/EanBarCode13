namespace Core.DTOs
{
    public class SheetItemsGetBySheetIdResponse:BaseResponse
    {
        public SheetItemsGetBySheetIdResponse(Guid Correlation) : base(Correlation) { }
        public IEnumerable<SheetItem> SheetItems { get; set; }
    }
}
