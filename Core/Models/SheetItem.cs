namespace Core.Models;

[Table("sheetitem")]
public class SheetItem : BaseEntity
{ 
    public string Name { get; set; }
    public string Code { get; set; }
    public bool IsLooked { get; set; }
    public string SheetId { get; set; }
}