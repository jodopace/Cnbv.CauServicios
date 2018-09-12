// ----------------------------------------------------------------------- 
// <copyright file="DbFactory.cs" company="C.N.B.V."> 
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
    /// Class DbFactory.
    /// </summary>
    public class DbFactory : Disposable , IDbFactory
    {
        /// <summary>
        /// The database context
        /// </summary>
        private CauServiciosContext dbContext;

        /// <summary>
        /// Initializes this instance.
        /// </summary>
        /// <returns>Caf Context.</returns>
        public CauServiciosContext Init()
        {
            return dbContext ?? (dbContext = new CauServiciosContext());
        }

        /// <summary>
        /// Disposes the core.
        /// </summary>
        protected override void DisposeCore()
        {
            if (dbContext != null)
            {
                this.dbContext.Dispose();
            }                
        }
    }
}
