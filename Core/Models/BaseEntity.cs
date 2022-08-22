namespace Core.Models
{
    public class BaseEntity
    {
        [PrimaryKey]
        public string Id { get; set; } = Guid.NewGuid().ToString();
    }
}
