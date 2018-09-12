// -----------------------------------------------------------------------
// <copyright file="IActiveDirectoryService.cs" company="C.N.B.V.">
// Copyright © C.N.B.V. Todos los derechos reservados.
// </copyright>
// -----------------------------------------------------------------------
namespace Cnbv.CauServicios.Service
{
    using System.Collections.ObjectModel;
    using Cnbv.Sait.ActiveDirectory;

    /// <summary>
    /// Clase para el manejo de las funciones relacionadas con el directorio activo
    /// </summary>;
    public interface IActiveDirectoryService
    {
        #region Public Methods

        /// <summary>
        /// Regresa los usuarios del directorio activo de la CNBV
        /// </summary>
        /// <param name="value">Nombre del usuario a buscar.</param>
        /// <returns>
        /// Si <paramref name="value"/> es <see langword="null"/> o <see cref="string.Empty"/> 
        /// se regresan todos los usuarios del dominio, en caso contrario se realiza la búsqueda 
        /// del usuario que tenga como nombre <paramref name="value"/>.
        /// </returns>
        ObservableCollection<IDirectoryUser> GetUsers(string value);

        /// <summary>
        /// Valida que la el identificador del usuario y el password sean correctos
        /// </summary>
        /// <param name="identificadorUsuario">El identificador del usuario</param>
        /// <param name="password">El password del usuario</param>
        /// <returns>True cuando el identificador del usuario y el password no son correctos. False cuando el identificador del usuario y/o el password no son correctos</returns>
        bool IsCnbvUser(string identificadorUsuario, string password);

        /// <summary>
        /// Get name by id
        /// </summary>
        /// <param name="user">The user identifier</param>
        /// <returns>The name</returns>
        string GetNameById(string user);

        #endregion Public Methods
    }
}