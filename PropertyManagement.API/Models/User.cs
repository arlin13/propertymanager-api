using Microsoft.AspNet.Identity.EntityFramework;

namespace PropertyManagement.API.Models
{
    public class User: IdentityUser
    {
        public virtual Employee Employee { get; set; }
        public virtual Supervisor Supervisor { get; set; }
    }
}