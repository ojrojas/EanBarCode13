namespace Core.Models;

[Table("sheetitem")]
public class SheetItem
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }
    public string Name { get; set; }
    public string Code { get; set; }
    public int SheetId { get; set; }
}