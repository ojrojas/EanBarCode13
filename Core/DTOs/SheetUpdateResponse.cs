namespace Core.DTOs
{
    public class SheetUpdateResponse : BaseResponse
    {
        public SheetUpdateResponse(Guid Correlation): base(Correlation) { }
        public Sheet SheetUpdated{ get; set; }
    }
}
