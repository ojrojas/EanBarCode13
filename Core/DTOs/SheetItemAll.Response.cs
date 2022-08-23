namespace Core.DTOs
{
    public class SheetItemAllResponse: BaseResponse
    {
        public SheetItemAllResponse(Guid Correlation): base(Correlation) { }
        public IEnumerable<SheetItem> SheetItems { get; set; }
    }
}
