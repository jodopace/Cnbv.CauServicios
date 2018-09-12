// ----------------------------------------------------------------------- 
// <copyright file="SocioService.cs" company="C.N.B.V."> 
// Copyright © C.N.B.V. Todos los derechos reservados. 
// </copyright> 
// -----------------------------------------------------------------------
namespace Cnbv.CauServicios.Service
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Cnbv.CauServicios.Data.Infrastructure;
    using Cnbv.CauServicios.Data.Repositories;
    using Cnbv.CauServicios.Model;

    /// <summary>
    /// Class SocioService.
    /// </summary>
    public class CauServiciosService : ICauServiciosService
    {
        /// <summary>
        /// The socio repository
        /// </summary>
        private readonly IUsuarioRepository socioRepository;


        private readonly ISolicitudRepository solicitudRepository;

        /// <summary>
        /// The unit of work
        /// </summary>
        private readonly IUnitOfWork unitOfWork;

        /// <summary>
        /// Initializes a new instance of the <see cref="CauServiciosService"/> class.
        /// </summary>
        /// <param name="socioRepository">The socio repository.</param>
        /// <param name="unitOfWork">The unit of work.</param>
        public CauServiciosService(IUsuarioRepository socioRepository, IUnitOfWork unitOfWork, ISolicitudRepository solicitudRepository)
        {
            this.socioRepository = socioRepository;
            this.unitOfWork = unitOfWork;
            this.solicitudRepository = solicitudRepository;
        }

        /// <summary>
        /// Gets the categories.
        /// </summary>
        /// <returns>IEnumerable{Socio}.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public IEnumerable<Model.Usuario> GetUsuario()
        {
            return this.socioRepository.GetAll();
        }

        /// <summary>
        /// Gets the category.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Socio.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public Model.Usuario GetUsuario(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the category.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>Socio.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public Model.Usuario GetUsuario(string name)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates the category.
        /// </summary>
        /// <param name="socio">The socio.</param>
        /// <exception cref="System.NotImplementedException"></exception>
        public void CreateUsuario(Model.Usuario socio)
        {
            this.socioRepository.Add(socio);
        }

        /// <summary>
        /// Saves the socio.
        /// </summary>
        /// <exception cref="System.NotImplementedException"></exception>
        public void Save()
        {
            unitOfWork.Commit();
        }

        /// <summary>
        /// Gets the socio by email.
        /// </summary>
        /// <param name="Idusuario">The email.</param>
        /// <returns>Socio.</returns>
        public Usuario GetUsuarioById(string Idusuario)
        {
            return this.socioRepository.GetUsuarioById(Idusuario);
        }


        public List<Solicitud> GetAllSolicitud()
        {
            List<Solicitud> result = new List<Solicitud>();

            result = this.solicitudRepository.GetAll().ToList();

            return result;
        }

        /// <summary>
        /// Get Folios Asignados Del Dia
        /// </summary>
        /// <returns></returns>
        public List<Usuario> GetFoliosAsignadosDelDia()
        {
            var ingenieros = this.socioRepository.GetAll().ToList();

            return ingenieros.Where(i => i.Perfiles.Select(x => x.Id).Contains(2)).ToList();
        }

        /// <summary>
        /// Asignar Folio Nuevo
        /// </summary>
        /// <param name="folio"></param>
        /// <returns></returns>
        public string AsignarFolioNuevo(string folio)
        {
            try
            {
                var users = this.socioRepository.GetAll().Where(u=>u.Activo);
               //// var ingenieros = users.Where(u => u.Perfiles.Select(sl => sl.Activo).Count()==0 && u.Perfiles.Select(p => p.Id).ToList().Contains(2));
                var ingenieros = users.Where(u =>  u.Perfiles.Select(p => p.Id).ToList().Contains(2));
                var mincount = ingenieros.Min(x => x.Solicitudes.Count);/// && u.Perfiles.Select(p => p.Id).ToList().Contains(2));
                var usr = users.Where(u => u.Solicitudes.Count == mincount && u.Perfiles.Select(p=>p.Id).ToList().Contains(2)).ToList().FirstOrDefault();

                var aux = new Solicitud();
                aux.Id = this.solicitudRepository.GetNextId();
                aux.NumeroReporte = folio;
                aux.Comentario = "Nuevo reporte";
                aux.fechaRegistro = DateTime.Now;
                aux.Activo = true;
                aux.FechaAsignado = DateTime.Now;
                aux.FechaLiberado = DateTime.Now;


                usr.Solicitudes.Add(aux);
                
                this.socioRepository.Update(usr);              

                return usr.NombreCompleto;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        /// <summary>
        /// Cerrar Folio
        /// </summary>
        /// <param name="id">identificador</param>
        /// <param name="commentario">comentario</param>
        /// <returns>resultado de </returns>
        public bool CerrarFolio(int id, string commentario)
        {
            try
            {
                bool result;
                var solicitud = this.solicitudRepository.GetById(id);
                solicitud.Comentario = commentario;
                solicitud.Activo = false;
                this.solicitudRepository.Update(solicitud);
                result = true;
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }            
        }

    }
}