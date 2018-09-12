using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cnbv.CauServicios.Web.Models
{
    public class ChartViewModel
    {
        public int IngenieroId { get; set; }

        public string Name { get; set; }

        public string Color { get; set; }

        public int IdentificadorHorario { get; set; }

        public int NoSolicitudesAsignadasHoy
        {
            get; set;
        }
    
    }
}