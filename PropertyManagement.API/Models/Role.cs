using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace PropertyManagement.API.Models
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }

        public Role()
        {
            Employees = new Collection<Employee>();
        }
    }
}