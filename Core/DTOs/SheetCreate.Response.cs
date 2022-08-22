namespace Core.DTOs
{
    public class SheetCreateResponse : BaseResponse
    {
        public SheetCreateResponse(Guid Correlation) : base(Correlation) { }

        public Sheet SheetCreated { get; set; }
    }
}
