namespace Cnbv.CauServicios.Data
{
    using Model;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.ModelConfiguration;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SolicitudConfiguracion : EntityTypeConfiguration<Solicitud>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PerfilConfiguration"/> class.
        /// </summary>
        public SolicitudConfiguracion()
        {
            ToTable("Solicitud");
            Property(g => g.Id).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(g => g.Comentario).IsRequired();
            Property(g => g.fechaRegistro).IsRequired();
            Property(g => g.NumeroReporte).IsRequired();
            Property(g => g.FechaAsignado).IsRequired();
            Property(g => g.FechaLiberado).IsRequired();
            Property(g => g.Activo).IsRequired();
            
            this.HasRequired<Usuario>(h => h.Usuario).WithMany(i => i.Solicitudes)
              .HasForeignKey<int>(h => h.UsuarioId);
        }
    }
}
