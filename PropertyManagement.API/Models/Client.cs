namespace PropertyManagement.API.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Website { get; set; }

        public virtual Company Company { get; set; }
    }
}