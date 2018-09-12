// ----------------------------------------------------------------------- 
// <copyright file="SocioRepository.cs" company="C.N.B.V."> 
// Copyright © C.N.B.V. Todos los derechos reservados. 
// </copyright> 
// -----------------------------------------------------------------------
namespace Cnbv.CauServicios.Data.Repositories
{
    using Cnbv.CauServicios.Data.Infrastructure;
    using Cnbv.CauServicios.Model;
    using System.Linq;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Class PrestamoRepository.
    /// </summary>
    public class UsuarioRepository : RepositoryBase<Usuario>, IUsuarioRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AportacionesRepository" /> class.
        /// </summary>
        /// <param name="dbFactory">The database factory.</param>
        public UsuarioRepository(IDbFactory dbFactory) : base(dbFactory) { }

        public Usuario GetUsuarioById(string usuario)
        {
            var user = this.DbContext.Usuario.Where(s => s.Expediente == usuario).FirstOrDefault();
            return user;
        }

      
    }
}
