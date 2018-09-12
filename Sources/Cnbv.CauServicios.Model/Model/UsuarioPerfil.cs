// ----------------------------------------------------------------------- 
// <copyright file="CatPeriodo.cs" company="C.N.B.V."> 
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
    /// Class CatPeriodo.
    /// </summary>
    public class UsuarioPerfil
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UsuarioPerfil"/> class.
        /// </summary>
        public UsuarioPerfil()
        { 
        }

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
        public int IdPerfil { get; set; }


        /// <summary>
        /// Gets or sets the usuario registro.
        /// </summary>
        /// <value>The usuario registro.</value>
        public Perfil Perfil { get; set; }    
    }
}
