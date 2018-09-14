using System;
using System.Collections.Generic;
using System.Linq;
namespace Cnbv.CauServicios.Model
{
    using System.Text;
    using System.Threading.Tasks;


    public class Solicitud
    {
        public int Id { get; set; }

        public string NumeroReporte { get; set; }

        public DateTime fechaRegistro { get; set; }

        public string Comentario { get; set; }

        public int UsuarioId { get; set; }

        public DateTime FechaAsignado { get; set; }

        public DateTime FechaLiberado { get; set; }

        public bool Activo { get; set; }

        /// <summary>
        /// Usuarios ref.
        /// </summary>
        public virtual Usuario Usuario { get; set; }
    }
}
