// ----------------------------------------------------------------------- 
// <copyright file="Socio.cs" company="C.N.B.V."> 
// Copyright © C.N.B.V. Todos los derechos reservados. 
// </copyright> 
// -----------------------------------------------------------------------
namespace Cnbv.CauServicios.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// Class Socio.
    /// </summary>
    public class Usuario
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Usuario" /> class.
        /// </summary>
        public Usuario()
        { }

        /// <summary>
        /// Gets or sets the socio identifier.
        /// </summary>
        /// <value>The socio identifier.</value>
        public int Id { get; set; }

        /// <summary>
        /// Id usuario interno
        /// </summary>
        public string Expediente { get; set; }

        /// <summary>
        /// Gets or sets the nombres.
        /// </summary>
        /// <value>The nombres.</value>
        public string Nombres { get; set; }

        /// <summary>
        /// Gets or sets the apellido paterno.
        /// </summary>
        /// <value>The apellido paterno.</value>
        public string ApellidoPaterno { get; set; }

        /// <summary>
        /// Gets or sets the apellido materno.
        /// </summary>
        /// <value>The apellido materno.</value>
        public string ApellidoMaterno { get; set; }

        /// <summary>
        /// Gets or sets the pasword.
        /// </summary>
        /// <value>The pasword.</value>
        public string Password { get; set; }

        /// <summary>
        /// Color  In graph
        /// </summary>
        public string Color { get; set; }
        /// <summary>
        /// Usuario Perfiles
        /// </summary>
        public virtual ICollection<Perfil> Perfiles { get; set; }

        /// <summary>
        /// Usuarios Solicitud
        /// </summary>
        public virtual ICollection<Solicitud> Solicitudes { get; set; }

        /// <summary>
        /// FK id Horario
        /// </summary>
        public int IdHorario { get; set; }

        /// <summary>
        /// Nombre Completo.
        /// </summary>
        /// <value>The nombre completo.</value>
        [NotMapped]
        public string NombreCompleto
        {
            get
            {
                return string.Format("{0} {1} {2}", this.Nombres, this.ApellidoPaterno, this.ApellidoMaterno);
            }
        }
        
        /// <summary>
        /// Gets or sets the rol user.
        /// </summary>
        /// <value>The rol user.</value>
        public bool Activo { get; set; }

        /// <summary>
        /// Horario de labores
        /// </summary>
        public Horario HorarioActual { get; set; }
    }
}