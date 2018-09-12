// ----------------------------------------------------------------------- 
// <copyright file="CatRolConfiguration.cs" company="C.N.B.V."> 
// Copyright © C.N.B.V. Todos los derechos reservados. 
// </copyright> 
// -----------------------------------------------------------------------
namespace Cnbv.CauServicios.Data.Configuration
{
    using System.Data.Entity.ModelConfiguration;
    using Cnbv.CauServicios.Model;

    /// <summary>
    /// Class CatRolConfiguration.
    /// </summary>
    public class IngenieroConfiguration : EntityTypeConfiguration<Ingeniero>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CatPeriodoConfiguration" /> class.
        /// </summary>
        public IngenieroConfiguration()
        {
            ToTable("Ingeniero");
            Property(g => g.Id).IsRequired();
            Property(g => g.Nombres).IsRequired().HasMaxLength(500);
            Property(g => g.ApellidoPaterno).IsOptional();
            Property(g => g.ApellidoMaterno).IsOptional();
            Property(g => g.FechaIngreso).IsRequired();
            Property(g => g.Activo).IsRequired();
        }
    }
}
