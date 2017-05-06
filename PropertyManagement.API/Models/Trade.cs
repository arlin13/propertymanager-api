using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace PropertyManagement.API.Models
{
    public class Trade
    {
        public int TradeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<EmployeeTrade> EmployeeTrades { get; set; }

        public Trade()
        {
            EmployeeTrades = new Collection<EmployeeTrade>();
        }
    }
}