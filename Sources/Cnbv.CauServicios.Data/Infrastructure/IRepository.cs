// ----------------------------------------------------------------------- 
// <copyright file="IRepository.cs" company="C.N.B.V."> 
// Copyright © C.N.B.V. Todos los derechos reservados. 
// </copyright> 
// -----------------------------------------------------------------------
namespace Cnbv.CauServicios.Data.Infrastructure
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;

    /// <summary>
    /// Interface IRepository
    /// </summary>
    /// <typeparam name="T">Type class</typeparam>
    public interface IRepository<T> where T : class
    {

        /// <summary>
        /// Adds the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        void Add(T entity);

        /// <summary>
        /// Updates the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        void Update(T entity);

        /// <summary>
        /// Deletes the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        void Delete(T entity);

        /// <summary>
        /// Deletes the specified where.
        /// </summary>
        /// <param name="where">The where.</param>
        void Delete(Expression<Func<T, bool>> where);

        /// <summary>
        /// Gets the by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>`0.</returns>
        T GetById(int id);

        /// <summary>
        /// Gets the specified where.
        /// </summary>
        /// <param name="where">The where.</param>
        /// <returns>`0.</returns>
        T Get(Expression<Func<T, bool>> where);

        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns>IEnumerable{`0}.</returns>
        IEnumerable<T> GetAll();

        /// <summary>
        /// Gets the many.
        /// </summary>
        /// <param name="where">The where.</param>
        /// <returns>IEnumerable{`0}.</returns>
        IEnumerable<T> GetMany(Expression<Func<T, bool>> where);
    }
}
