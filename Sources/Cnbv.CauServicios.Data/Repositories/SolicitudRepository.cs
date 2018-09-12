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
    public class SolicitudRepository : RepositoryBase<Solicitud>, ISolicitudRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AportacionesRepository" /> class.
        /// </summary>
        /// <param name="dbFactory">The database factory.</param>
        public SolicitudRepository(IDbFactory dbFactory) : base(dbFactory) { }

        public int GetNextId()
        {
            var maxId = this.DbContext.Solicitud.Max(x=> x.Id);
            return maxId+1;
        }

    }
}
