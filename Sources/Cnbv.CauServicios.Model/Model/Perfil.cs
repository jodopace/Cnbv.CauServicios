// ----------------------------------------------------------------------- 
// <copyright file="Prestamo.cs" company="C.N.B.V."> 
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
    /// Class Prestamo.
    /// </summary>
    public class Perfil
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Perfil" /> class.
        /// </summary>
        public Perfil()
        {
        }

        /// <summary>
        /// Gets or sets the prestamo identifier.
        /// </summary>
        /// <value>The prestamo identifier.</value>
        public int Id { get; set; }
        

        /// <summary>
        /// Gets or sets the fecha aplicacion.
        /// </summary>
        /// <value>The fecha aplicacion.</value>
        public string Descripcion { get; set; }

        /// <summary>
        /// Gets or sets the monto.
        /// </summary>
        /// <value>The monto.</value>
        public bool Activo { get; set; }

        /// <summary>
        /// Usuarios ref.
        /// </summary>
        public virtual ICollection<Usuario> Usuarios { get; set; }

    }
}
