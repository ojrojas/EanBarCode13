namespace Core.Models;

    [Table("workbook")]
    public class WorkBook
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
    }
