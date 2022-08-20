namespace Core.Models;

[Table("sheet")]
public class Sheet
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }
    public string Name { get; set; }
    public int Position { get; set; }
    public int Quantity { get; set; }
    public int WorkBookId { get; set; }
}

