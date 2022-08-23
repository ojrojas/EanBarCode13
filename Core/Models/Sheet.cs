namespace Core.Models;

[Table("sheet")]
public class Sheet : BaseEntity
{
    public string Name { get; set; }
    public int Position { get; set; }
    public int Quantity { get; set; }
    public string WorkBookId { get; set; }
}

