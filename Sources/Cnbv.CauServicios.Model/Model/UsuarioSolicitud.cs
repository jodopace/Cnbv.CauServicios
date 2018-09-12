namespace Cnbv.CauServicios.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class UsuarioSolicitud
    {
        /// <summary>
        /// Gets or sets the cat periodo identifier.
        /// </summary>
        /// <value>The cat periodo identifier.</value>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the descripcion.
        /// </summary>
        /// <value>The descripcion.</value>
        public int IdUsuario { get; set; }

        /// <summary>
        /// Gets or sets the usuario registro.
        /// </summary>
        /// <value>The usuario registro.</value>
        public int IdSolicitud { get; set; }

        /// <summary>
        /// Solicitud of this relation
        /// </summary>
        public Solicitud Solicitud {get; set;}
    }
}
