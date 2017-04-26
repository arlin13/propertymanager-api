using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PropertyManagement.API.Models
{
    public class Material
    {
        public int MaterialId { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
    }
}