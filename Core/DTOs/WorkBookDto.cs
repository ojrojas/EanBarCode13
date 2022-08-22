namespace Core.DTOs
{
    public class WorkBookDto
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public IEnumerable<Sheet> Sheets { get; set; } = new List<Sheet>();
    }
}
