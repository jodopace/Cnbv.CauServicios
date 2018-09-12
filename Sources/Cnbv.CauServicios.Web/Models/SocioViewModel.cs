// ----------------------------------------------------------------------- 
// <copyright file="SocioViewModel.cs" company="C.N.B.V."> 
// Copyright © C.N.B.V. Todos los derechos reservados. 
// </copyright> 
// -----------------------------------------------------------------------
namespace Cnbv.CauServicios.Web.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
     

    /// <summary>
    /// Class Socio.
    /// </summary>
    public class IngenieroViewModel
    {
        /// <summary>
        /// Gets or sets the socio identifier.
        /// </summary>
        /// <value>The socio identifier.</value>
        public int SocioId { get; set; }

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
        /// Gets or sets the correo electronico.
        /// </summary>
        /// <value>The correo electronico.</value>
        public string CorreoElectronico { get; set; }

        /// <summary>
        /// Gets or sets the pasword.
        /// </summary>
        /// <value>The pasword.</value>
        public string Password { get; set; }

       /// <summary>
        /// Gets or sets the pasword.
        /// </summary>
        /// <value>The confirm pasword.</value>
        public string ConfirmPassword { set; get; }

        /// <summary>
        /// Gets or sets the cat periodo identifier.
        /// </summary>
        /// <value>The cat periodo identifier.</value>
        public int CatPeriodoId { get; set; }

        /// <summary>
        /// Gets or sets the monto sugerido.
        /// </summary>
        /// <value>The monto sugerido.</value>
        public int MontoSugerido { get; set; }

        /// <summary>
        /// Nombre Completo.
        /// </summary>
        /// <value>The nombre completo.</value>
        public string NombreCompleto { get; set; }

        /// <summary>
        /// Gets or sets the rol user identifier.
        /// </summary>
        /// <value>The rol user identifier.</value>
        public int RolUserId { get; set; }
    }
}