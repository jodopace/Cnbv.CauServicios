using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cnbv.CauServicios.Web.Models
{
    public class SolicitudViewModel
    {

        public int Id { get; set; }

        public string NumeroReporte { get; set; }

      
        public string Comentario { get; set; }


        public string FechaAsignado { get; set; }

        public bool Activo { get; set; }

        /// <summary>
        /// Usuarios ref.
        /// </summary>
        public string UsuarioSolicitud { get; set; }
    }
}