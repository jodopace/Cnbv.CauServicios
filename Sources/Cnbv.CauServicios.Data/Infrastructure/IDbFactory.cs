// ----------------------------------------------------------------------- 
// <copyright file="IDbFactory.cs" company="C.N.B.V."> 
// Copyright © C.N.B.V. Todos los derechos reservados. 
// </copyright> 
// -----------------------------------------------------------------------
namespace Cnbv.CauServicios.Data.Infrastructure
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Interface IDbFactory
    /// </summary>
    public interface IDbFactory : IDisposable
    {
        CauServiciosContext Init();
    }
}
