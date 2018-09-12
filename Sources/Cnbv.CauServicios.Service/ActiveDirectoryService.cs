// -----------------------------------------------------------------------
// <copyright file="ActiveDirectoryService.cs" company="C.N.B.V.">
// Copyright © C.N.B.V. Todos los derechos reservados.
// </copyright>
// -----------------------------------------------------------------------
namespace Cnbv.CauServicios.Service
{
    using System;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Security;
    using Cnbv.Sait.ActiveDirectory;
    using Cnbv.Sait.SystemSecurity;
    using Cnbv.Sait.Utilities.Conversions;
    using Cnbv.Sait.Utilities.Extensions;
    using Cnbv.Sait.Utilities.Validations;

    /// <summary>
    /// Clase para el manejo de las funciones relacionadas con el directorio activo
    /// </summary>
    public class ActiveDirectoryService : IActiveDirectoryService
    {       
        /// <summary>
        /// Regresa los usuarios del directorio activo de la CNBV
        /// </summary>
        /// <param name="value">Nombre del usuario a buscar.</param>
        /// <returns>
        /// Si <paramref name="value"/> es <see langword="null"/> o <see cref="string.Empty"/> 
        /// se regresan todos los usuarios del dominio, en caso contrario se realiza la búsqueda 
        /// del usuario que tenga como nombre <paramref name="value"/>.
        /// </returns>
        public ObservableCollection<IDirectoryUser> GetUsers(string value)
        {
            DirectoryDomain domain = new DirectoryDomain();
            if (value.IsNullOrWhiteSpace())
            {
                return domain.SearchUsers();
            }
            else
            {
                var results = new ObservableCollection<IDirectoryUser>();
                var result = domain.SearchUserByName(value);
                if (result == null)
                {
                    result = domain.SearchUserById(value);
                }

                if (result != null)
                {
                    results.Add(result);
                }

                return results;
            }
        }

        /// <summary>
        /// Get name by id
        /// </summary>
        /// <param name="user">The user identifier</param>
        /// <returns>The name</returns>
        public string GetNameById(string user)
        {
            user.ThrowIfNullOrEmpty("user");
            string name = string.Empty;
            ObservableCollection<IDirectoryUser> users = this.GetUsers(user);
            if (users != null && users.Count > 0)
            {
                IDirectoryUser directoryUser = users.FirstOrDefault();

                name = string.IsNullOrWhiteSpace(directoryUser.GivenName) ? string.Empty : directoryUser.GivenName;
                name += " ";
                name += string.IsNullOrWhiteSpace(directoryUser.Surname) ? string.Empty : directoryUser.Surname;
            }

            return name;
        }

        /// <summary>
        /// Registra la subaplicación en la bitácora de acceso.
        /// </summary>
        /// <param name="identificadorUsuario">USer to validate</param>
        /// <param name="password">User's Password</param>
        /// <returns>True cuando la información del usuario es correcta. False cuando la información del usuario no es correcta</returns>
        public bool IsCnbvUser(string identificadorUsuario, string password)
        {
            identificadorUsuario.ThrowIfNullOrWhiteSpace("identificadorUsuario");
            password.ThrowIfNullOrWhiteSpace("password");

            bool isAuthenticated = false;

            try
            {
                AuthenticationState resultAuthentication = ValidateInDomain(identificadorUsuario, password.ToSecureString());
                if (resultAuthentication == AuthenticationState.AuthenticatedAndInRole)
                {
                    isAuthenticated = true;
                }
            }
            catch (Exception)
            {
                throw;
            }

            return isAuthenticated;
        }

        /// <summary>
        /// Realiza la validación del usuario en el dominio.
        /// </summary>
        /// <param name="usuario">User to validate</param>
        /// <param name="password">user's password </param>
        /// <returns>El resultado de la validación.</returns>
        private static AuthenticationState ValidateInDomain(string usuario, SecureString password)
        {
            IAuthenticateUser cnbvAuthentication = new AuthenticateUser(usuario, password);

            // ToDo: Remover magis strings para Dominio y Role 
            return cnbvAuthentication.ValidateUserAndRole("CNBYV.GOB", "Domain Users");
        }
       
    }
}