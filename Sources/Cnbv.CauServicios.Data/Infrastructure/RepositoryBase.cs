// ----------------------------------------------------------------------- 
// <copyright file="RepositoryBase.cs" company="C.N.B.V."> 
// Copyright © C.N.B.V. Todos los derechos reservados. 
// </copyright> 
// -----------------------------------------------------------------------
namespace Cnbv.CauServicios.Data.Infrastructure
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.Linq.Expressions;

    /// <summary>
    /// Class RepositoryBase.
    /// </summary>
    /// <typeparam name="T">Type class</typeparam>
    public abstract class RepositoryBase<T> where T : class
    {
        #region [Properties]

        /// <summary>
        /// The database set
        /// </summary>
        private readonly IDbSet<T> dbset;

        /// <summary>
        /// The data context
        /// </summary>
        private CauServiciosContext dataContext;

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryBase{T}"/> class.
        /// </summary>
        /// <param name="dbfactory">The database factory.</param>
        protected RepositoryBase(IDbFactory dbfactory)
        {
            this.DbFactory = dbfactory;
            this.dbset = this.DbContext.Set<T>();
        }

        /// <summary>
        /// Gets the database factory.
        /// </summary>
        /// <value>The database factory.</value>
        protected IDbFactory DbFactory
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the database context.
        /// </summary>
        /// <value>The database context.</value>
        protected CauServiciosContext DbContext
        {
            get { return this.dataContext ?? (this.dataContext = this.DbFactory.Init()); }
        }

        #endregion      

        #region [Implementation]

        /// <summary>
        /// Adds the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        public virtual void Add(T entity)
        {
            this.dbset.Add(entity);
        }

        /// <summary>
        /// Updates the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        public virtual void Update(T entity)
        {
            this.dbset.Attach(entity);
            this.dataContext.Entry(entity).State = EntityState.Modified;
        }

        /// <summary>
        /// Deletes the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        public virtual void Delete(T entity)
        {
            this.dbset.Remove(entity);
        }

        /// <summary>
        /// Deletes the specified where.
        /// </summary>
        /// <param name="where">The where.</param>
        public virtual void Delete(Expression<Func<T, bool>> where)
        {
            IEnumerable<T> objects = this.dbset.Where<T>(where).AsEnumerable();
            foreach (T obj in objects)
            {
                this.dbset.Remove(obj);
            }
        }

        /// <summary>
        /// Gets the by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Type class</returns>
        public virtual T GetById(int id)
        {
            return this.dbset.Find(id);
        }

        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns>IEnumerable{type class}.</returns>
        public virtual IEnumerable<T> GetAll()
        {
            return this.dbset.ToList();
        }

        /// <summary>
        /// Gets the many.
        /// </summary>
        /// <param name="where">The where.</param>
        /// <returns>IEnumerable{type class}.</returns>
        public virtual IEnumerable<T> GetMany(Expression<Func<T, bool>> where)
        {
            return this.dbset.Where(where).ToList();
        }

        /// <summary>
        /// Gets the specified where.
        /// </summary>
        /// <param name="where">The where.</param>
        /// <returns>object class</returns>
        public T Get(Expression<Func<T, bool>> where)
        {
            return this.dbset.Where(where).FirstOrDefault<T>();
        }
        #endregion
    }
}
