using System.Data.Entity.Spatial;

namespace PropertyManagement.API.Models
{
    public class Property
    {
        public int PropertyId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public DbGeography Location { get; set; }
    }
}