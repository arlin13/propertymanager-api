using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace PropertyManagement.API.Models
{
    public class Company
    {
        public int CompanyId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public virtual ICollection<Client> Clients { get; set; }

        public Company()
        {
            Clients = new Collection<Client>();
        }
    }
}