// ----------------------------------------------------------------------- 
// <copyright file="SocioConfiguration.cs" company="C.N.B.V."> 
// Copyright © C.N.B.V. Todos los derechos reservados. 
// </copyright> 
// -----------------------------------------------------------------------
namespace Cnbv.CauServicios.Data
{
    using System.Data.Entity.ModelConfiguration;
    using Cnbv.CauServicios.Model;

    /// <summary>
    /// Class SocioConfiguration.
    /// </summary>
    public class UsuarioConfiguration : EntityTypeConfiguration<Usuario>
    {
        public UsuarioConfiguration()
        {
            ToTable("Usuario");
            Property(g => g.Id).IsRequired();
            Property(g => g.Expediente).IsRequired().HasMaxLength(50); 
            Property(g => g.Nombres).IsRequired().HasMaxLength(250);
            Property(g => g.ApellidoPaterno).IsRequired().HasMaxLength(250);
            Property(g => g.ApellidoMaterno).IsRequired().HasMaxLength(250);

            Property(g => g.Password).IsRequired().HasMaxLength(50);
            Property(g => g.Color).IsRequired().HasMaxLength(150);
            Property(g => g.Activo).IsRequired();
            this.HasMany<Perfil>(g => g.Perfiles).WithMany(t => t.Usuarios)
                .Map(gt =>
                {
                    gt.MapLeftKey("IdUsuario");
                    gt.MapRightKey("IdPerfil");
                    gt.ToTable("UsuarioPerfil");
                }

                );

            this.HasMany<Solicitud>(g => g.Solicitudes).WithRequired(u => u.Usuario).HasForeignKey<int>(x=>x.UsuarioId);

            //this.HasMany<Solicitud>(g => g.Solicitudes).WithMany()
            //    .Map(gt =>
            //    {
            //        gt.MapLeftKey("IdUsuario");
            //        gt.MapRightKey("IdSolicitud");
            //        gt.ToTable("UsuarioSolicitud");
            //    }
            //    );




            //this.HasMany<Solicitud>(g => g.Solicitudes).WithRequired(t=>t.UsuarioSolicitud).HasForeignKey<int>(t=>t.UsuarioId);
            ///// this.HasOptional<Solicitud>(s=>s.)

            this.HasRequired<Horario>(h => h.HorarioActual).WithMany(i=>i.Usuarios)
                .HasForeignKey<int>(h=>h.IdHorario);
        }

    }
}
