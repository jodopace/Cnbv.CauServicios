
namespace Cnbv.CauServicios.Web.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    public class ModelUser
    {
        public string User { get; set; }

        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}