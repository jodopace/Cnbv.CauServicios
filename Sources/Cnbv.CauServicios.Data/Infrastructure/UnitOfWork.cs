// ----------------------------------------------------------------------- 
// <copyright file="UnitOfWork.cs" company="C.N.B.V."> 
// Copyright © C.N.B.V. Todos los derechos reservados. 
// </copyright> 
// -----------------------------------------------------------------------
namespace Cnbv.CauServicios.Data.Infrastructure
{
    /// <summary>
    /// Class UnitOfWork.
    /// </summary>
    public class UnitOfWork : IUnitOfWork
    {
        /// <summary>
        /// The database factory
        /// </summary>
        private readonly IDbFactory dbFactory;

        /// <summary>
        /// The database context
        /// </summary>
        private CauServiciosContext dbContext;

        /// <summary>
        /// Initializes a new instance of the <see cref="UnitOfWork"/> class.
        /// </summary>
        /// <param name="dbFactory">The database factory.</param>
        public UnitOfWork(IDbFactory dbFactory)
        {
            this.dbFactory = dbFactory;
        }

        /// <summary>
        /// Gets the database context.
        /// </summary>
        /// <value>The database context.</value>
        public CauServiciosContext DbContext
        {
            get { return dbContext ?? (dbContext = dbFactory.Init()); }
        }

        /// <summary>
        /// Commits this instance.
        /// </summary>
        public void Commit()
        {
            DbContext.Commit();
        }
    }
}
