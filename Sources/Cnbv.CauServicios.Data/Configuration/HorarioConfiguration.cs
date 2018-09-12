// ----------------------------------------------------------------------- 
// <copyright file="CatPeriodoConfiguration.cs" company="C.N.B.V."> 
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
    /// Class CatPeriodoConfiguration.
    /// </summary>
    public class HorarioConfiguration : EntityTypeConfiguration<Horario>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HorarioConfiguration"/> class.
        /// </summary>
        public HorarioConfiguration()
        {
            ToTable("Horario");
            Property(g => g.Id).IsRequired();
            Property(g => g.Inicio).IsRequired();
            Property(g => g.Fin).IsRequired();
            Property(g => g.Activo).IsRequired();
        }

    }
}
