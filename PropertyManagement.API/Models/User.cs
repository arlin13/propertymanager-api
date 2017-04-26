using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PropertyManagement.API.Models
{
    public class User
    {
        public virtual Employee Employee { get; set; }
        public virtual Supervisor Supervisor { get; set; }

    }
}