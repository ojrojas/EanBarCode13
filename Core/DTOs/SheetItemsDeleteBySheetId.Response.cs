namespace Core.DTOs
{
    public class SheetItemsDeleteBySheetIdResponse: BaseResponse
    {
        public SheetItemsDeleteBySheetIdResponse(Guid Correlation ): base(Correlation) { }
        public IEnumerable<SheetItem> SheetItems { get; set; }
    }
}
