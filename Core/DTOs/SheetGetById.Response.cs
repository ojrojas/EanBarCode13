namespace Core.DTOs
{
    public class SheetGetByIdResponse : BaseResponse
    {
        public SheetGetByIdResponse(Guid Correlation) : base(Correlation) { }
        public Sheet Sheet { get; set; }
    }
}
