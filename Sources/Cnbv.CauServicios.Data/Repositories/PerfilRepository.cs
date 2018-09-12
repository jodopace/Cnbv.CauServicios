// ----------------------------------------------------------------------- 
// <copyright file="PrestamoRepository.cs" company="C.N.B.V."> 
// Copyright © C.N.B.V. Todos los derechos reservados. 
// </copyright> 
// -----------------------------------------------------------------------
namespace Cnbv.CauServicios.Data.Repositories
{
    using Cnbv.CauServicios.Data.Infrastructure;
    using Cnbv.CauServicios.Model;

    /// <summary>
    /// Class PrestamoRepository.
    /// </summary>
    public class PerfilRepository : RepositoryBase<Perfil>, IPerfilRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AportacionesRepository" /> class.
        /// </summary>
        /// <param name="dbFactory">The database factory.</param>
        public PerfilRepository(IDbFactory dbFactory) : base(dbFactory) { }
    }
}
