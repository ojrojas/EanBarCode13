namespace Core.DTOs
{
    public class SheetUpdateResponse : BaseResponse
    {
        public SheetUpdateResponse(Guid Correlation): base(Correlation) { }
        public int SheetId { get; set; }
    }
}
