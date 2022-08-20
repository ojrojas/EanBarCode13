namespace Core.Commons;

public abstract class BaseMessage
{
    protected Guid _correlationId = Guid.NewGuid();
    public Guid CorrelationId => _correlationId;
}
