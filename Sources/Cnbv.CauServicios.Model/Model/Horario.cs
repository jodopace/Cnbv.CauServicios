// ----------------------------------------------------------------------- 
// <copyright file="CatRol.cs" company="C.N.B.V."> 
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
    /// Class CatRol.
    /// </summary>
    public class Horario
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Horario"/> class.
        /// </summary>
        public Horario()
        { 
        }

        /// <summary>
        /// Gets or sets the cat rol identifier.
        /// </summary>
        /// <value>The cat rol identifier.</value>
        public int Id { get; set; }

        

        /// <summary>
        /// Gets or sets the fecha registro.
        /// </summary>
        /// <value>The fecha registro.</value>
        public DateTime Inicio { get; set; }

        
        /// <summary>
        /// Gets or sets the fecha actualizacion.
        /// </summary>
        /// <value>The fecha actualizacion.</value>
        public DateTime Fin { get; set; }

        /// <summary>
        /// Gets or sets the usuario actualiza.
        /// </summary>
        /// <value>The usuario actualiza.</value>
        public bool Activo { get; set; }

        /// <summary>
        /// Usuarios ref.
        /// </summary>
        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
