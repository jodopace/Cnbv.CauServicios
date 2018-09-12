// ----------------------------------------------------------------------- 
// <copyright file="ParcialidadPrestamoConfiguration.cs" company="C.N.B.V."> 
// Copyright © C.N.B.V. Todos los derechos reservados. 
// </copyright> 
// -----------------------------------------------------------------------
namespace Cnbv.CauServicios.Data.Configuration
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.ModelConfiguration;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Cnbv.CauServicios.Model;

    /// <summary>
    /// Class ParcialidadPrestamoConfiguration.
    /// </summary>
    public class PerfilConfiguration : EntityTypeConfiguration<Perfil>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PerfilConfiguration"/> class.
        /// </summary>
        public PerfilConfiguration()
        {
            ToTable("Perfil");
            Property(g => g.Id).IsOptional();
            Property(g => g.Descripcion).IsRequired();
            Property(g => g.Activo).IsRequired();               
        }

    }
}