using Microsoft.AspNet.Identity.EntityFramework;
using PropertyManagement.API.Models;
using System.Data.Entity;

namespace PropertyManagement.API.Data
{
    public class PropertyManagementDataContext: IdentityDbContext<User>
    {
        public PropertyManagementDataContext() : base ("PropertyManager")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}