// ----------------------------------------------------------------------- 
// <copyright file="ISocioRepository.cs" company="C.N.B.V."> 
// Copyright © C.N.B.V. Todos los derechos reservados. 
// </copyright> 
// -----------------------------------------------------------------------
namespace Cnbv.CauServicios.Data.Repositories
{    
    using Cnbv.CauServicios.Data.Infrastructure;
    using Cnbv.CauServicios.Model;

    /// <summary>
    /// Interface ISocioRepository
    /// </summary>
    public interface IUsuarioRepository : IRepository<Usuario>
    {
        Usuario GetUsuarioById(string Id);
    }
}
