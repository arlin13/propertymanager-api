namespace PropertyManagement.API.Models
{
    public class EmployeeTrade
    {
        public int EmployeeId { get; set; }
        public int TradeId { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual Trade Trade { get; set; }
    }
}