namespace Core.Models;

[Table("workbook")]
public class WorkBook : BaseEntity
{
    public string Name { get; set; }
    public DateTime Date { get; set; }
}
