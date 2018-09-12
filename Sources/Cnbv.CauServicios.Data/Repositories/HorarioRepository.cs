﻿// ----------------------------------------------------------------------- 
// <copyright file="CatRolRepository.cs" company="C.N.B.V."> 
// Copyright © C.N.B.V. Todos los derechos reservados. 
// </copyright> 
// -----------------------------------------------------------------------
namespace Cnbv.CauServicios.Data.Repositories
{
    using Cnbv.CauServicios.Data.Infrastructure;
    using Cnbv.CauServicios.Model;

    /// <summary>
    /// Class AportacionesRepository.
    /// </summary>
    public class HorarioRepository : RepositoryBase<Horario>, IHorarioRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AportacionesRepository" /> class.
        /// </summary>
        /// <param name="dbFactory">The database factory.</param>
        public HorarioRepository(IDbFactory dbFactory) : base(dbFactory) { }
    }
}
