// ----------------------------------------------------------------------- 
// <copyright file="IUnitOfWork.cs" company="C.N.B.V."> 
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
    /// Interface IUnitOfWork
    /// </summary>
    public interface IUnitOfWork
    {
        /// <summary>
        /// Commits this instance.
        /// </summary>
        void Commit();
    }
}
