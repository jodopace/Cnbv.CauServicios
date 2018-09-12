// ----------------------------------------------------------------------- 
// <copyright file="CafContext.cs" company="C.N.B.V."> 
// Copyright © C.N.B.V. Todos los derechos reservados. 
// </copyright> 
// -----------------------------------------------------------------------
namespace Cnbv.CauServicios.Data
{
    using System.Data.Entity;
    using Cnbv.CauServicios.Data.Configuration;
    using Cnbv.CauServicios.Model;
    using Data;

    /// <summary>
    /// Class CafContext.
    /// </summary>
    public class CauServiciosContext : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CauServiciosContext" /> class.
        /// </summary>
        public CauServiciosContext()  : base("CAUServicios")
        {

            ////Database.SetInitializer<CauServiciosContext>(new CreateDatabaseIfNotExists<CauServiciosContext>());
            //Database.SetInitializer<CauServiciosContext>(new DropCreateDatabaseIfModelChanges<CauServiciosContext>());
           //// Database.SetInitializer<CauServiciosContext>(new DropCreateDatabaseAlways<CauServiciosContext>());
            //Database.SetInitializer<CauServiciosContext>(new CauServiciosContextInicializer());

        }

        /// <summary>
        /// Gets or sets the socios.
        /// </summary>
        /// <value>The socios.</value>
        public DbSet<Usuario> Usuario { get; set; }

        ///// <summary>
        ///// Gets or sets the periodos.
        ///// </summary>
        ///// <value>The periodos.</value>
        //public DbSet<Model.UsuarioPerfil> UsuarioPerfil { get; set; }

        /// <summary>
        /// Gets or sets the periodos.
        /// </summary>
        /// <value>The periodos.</value>
        public DbSet<Model.UsuarioSolicitud> UsuarioSolicitud { get; set; }

        /// <summary>
        /// Gets or sets the socios.
        /// </summary>
        /// <value>The socios.</value>
        public DbSet<Horario> Horario { get; set; }

        /// <summary>
        /// Gets or sets the periodos.
        /// </summary>
        /// <value>The periodos.</value>
        public DbSet<Ingeniero> Ingeniero { get; set; }

        /// <summary>
        /// Gets or sets the periodos.
        /// </summary>
        /// <value>The periodos.</value>
        public DbSet<Perfil> Perfil { get; set; }

        /// <summary>
        /// Gets or sets the periodos.
        /// </summary>
        /// <value>The periodos.</value>
        public DbSet<Solicitud> Solicitud { get; set; }

        /// <summary>
        /// Commits this instance.
        /// </summary>
        public virtual void Commit()
        {
            base.SaveChanges();
        }

        /// <summary>
        /// This method is called when the model for a derived context has been initialized, but
        /// before the model has been locked down and used to initialize the context.  The default
        /// implementation of this method does nothing, but it can be overridden in a derived class
        /// such that the model can be further configured before it is locked down.
        /// </summary>
        /// <param name="modelBuilder">The builder that defines the model for the context being created.</param>
        /// <remarks>Typically, this method is called only once when the first instance of a derived context
        /// is created.  The model for that context is then cached and is for all further instances of
        /// the context in the app domain.  This caching can be disabled by setting the ModelCaching
        /// property on the given ModelBuidler, but note that this can seriously degrade performance.
        /// More control over caching is provided through use of the DbModelBuilder and DbContextFactory
        /// classes directly.</remarks>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {            
            modelBuilder.Configurations.Add(new HorarioConfiguration());
            modelBuilder.Configurations.Add(new IngenieroConfiguration());
            modelBuilder.Configurations.Add(new PerfilConfiguration());            
            modelBuilder.Configurations.Add(new SolicitudConfiguracion());            
            modelBuilder.Configurations.Add(new UsuarioConfiguration());

        }
    }
}
