// ----------------------------------------------------------------------- 
// <copyright file="ParcialidadPrestamo.cs" company="C.N.B.V."> 
// Copyright © C.N.B.V. Todos los derechos reservados. 
// </copyright> 
// -----------------------------------------------------------------------
namespace Cnbv.CauServicios.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// Class ParcialidadPrestamo.
    /// </summary>
    public class Ingeniero
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ingeniero" /> class.
        /// </summary>
        public Ingeniero()
        { 
        }

        /// <summary>
        /// Gets or sets the socio identifier.
        /// </summary>
        /// <value>The socio identifier.</value>
        public int Id { get; set; }

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
        /// Gets or sets the fecha esperada.
        /// </summary>
        /// <value>The fecha esperada.</value>
        public DateTime? FechaIngreso { get; set; }

        /// <summary>
        /// Gets or sets the monto.
        /// </summary>
        /// <value>The monto.</value>
        public bool Activo { get; set; }

        public Horario Horario { get; set; }
    }
}