namespace Core.Commons;

public class BaseResponse : BaseMessage
{
    public BaseResponse(Guid correlation) : base()
    {
        base._correlationId = correlation;
    }

    public BaseResponse() { }

    public string Message { get; set; }
}
