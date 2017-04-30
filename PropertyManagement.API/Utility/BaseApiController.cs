using PropertyManagement.API.Data;
using PropertyManagement.API.Models;
using System.Linq;
using System.Web.Http;

namespace PropertyManagement.API.Utility
{
    public class BaseApiController : ApiController
    {
        protected PropertyManagementDataContext db = new PropertyManagementDataContext();

        public User CurrentUser
        {
            get
            {
                var userName = base.User.Identity.Name;
                var user = db.Users.FirstOrDefault(u => u.UserName == userName);

                return user;
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }

            base.Dispose(disposing);
        }
    }
}
