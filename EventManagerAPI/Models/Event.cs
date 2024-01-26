namespace EventManagerAPI.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime date { get; set; }
        public int IdUser { get; set; }
        
    }
}
