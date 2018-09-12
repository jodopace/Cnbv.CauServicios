// ----------------------------------------------------------------------- 
// <copyright file="ISocioService.cs" company="C.N.B.V."> 
// Copyright © C.N.B.V. Todos los derechos reservados. 
// </copyright> 
// -----------------------------------------------------------------------
namespace Cnbv.CauServicios.Service
{
    using System.Collections.Generic;
    using Cnbv.CauServicios.Model;

    /// <summary>
    /// Interface ISocioService
    /// </summary>
    public interface ICauServiciosService
    {
        /// <summary>
        /// Gets the socio by email.
        /// </summary>
        /// <param name="Id">The email.</param>
        /// <returns>Socio.</returns>
        Usuario GetUsuarioById(string Id);

        /// <summary>
        /// Gets the categories.
        /// </summary>
        /// <returns>IEnumerable{Socio}.</returns>
        IEnumerable<Usuario> GetUsuario();

        /// <summary>
        /// Asigna un nuevo folio al ingeniero con menos reportes
        /// </summary>
        /// <param name="folio">folio de Help desk</param>
        /// <returns>Booleano que inidica si la operacion fue exitosa o no.</returns>
        string AsignarFolioNuevo(string folio);

        /// <summary>
        /// Gets the category.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Socio.</returns>
        Usuario GetUsuario(int id);

        /// <summary>
        /// Gets the category.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>Socio.</returns>
        Usuario GetUsuario(string name);

        /// <summary>
        /// Creates the category.
        /// </summary>
        /// <param name="usuario">The socio.</param>
        void CreateUsuario(Usuario usuario);

        /// <summary>
        /// Saves the socio.
        /// </summary>
        void Save();

        /// <summary>
        /// Get Folios Asignados Del Dia
        /// </summary>
        /// <returns></returns>
        List<Usuario> GetFoliosAsignadosDelDia();

       bool CerrarFolio(int id,string commentario);

        List<Solicitud> GetAllSolicitud();
    }
}
