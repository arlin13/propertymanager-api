using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace PropertyManagement.API.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }

        public Department()
        {
            Employees = new Collection<Employee>();
        }
    }
}