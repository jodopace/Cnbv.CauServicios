using Cnbv.CauServicios.Service;
using Cnbv.CauServicios.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cnbv.CauServicios.Web.Controllers
{
    public class ConsultaFoliosController : Controller
    {
        private readonly ICauServiciosService cauServiciosService;

        /// <summary>
        /// Constructor of then controller
        /// </summary>
        /// <param name="cauServiciosService"></param>
        public ConsultaFoliosController(ICauServiciosService cauServiciosService)
        {
            this.cauServiciosService = cauServiciosService;
        }


        // GET: ConsultaFolios
        [Authorize(Roles = "")]
        public ActionResult ConsultaFolios()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GetAllFolios()
        {

          

            
            try
            {
                string usr = HttpContext.User.Identity.Name;
                bool isadministrator = HttpContext.User.IsInRole("Administrador");
                List<SolicitudViewModel> result = new List<SolicitudViewModel>();
                if (isadministrator)
                {
                    var solicitudesaux = this.cauServiciosService.GetAllSolicitud();
                    result = GetSolicitudViewModelList(solicitudesaux);
                }
                else
                {
                    var currentuser = this.cauServiciosService.GetUsuarioById(usr);
                   
                    result = GetSolicitudViewModelList(currentuser.Solicitudes);
                }

                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        private List<SolicitudViewModel> GetSolicitudViewModelList(ICollection<Model.Solicitud> solicitudes)
        {
            List<SolicitudViewModel> result = new List<SolicitudViewModel>();
            foreach (var a in solicitudes)
            {
                SolicitudViewModel tmp = new SolicitudViewModel();
                tmp.Activo = a.Activo;
                tmp.Comentario = a.Comentario;
                tmp.FechaAsignado = a.FechaAsignado.ToString("dd/MM/yyyy HH:mm:ss");
                tmp.Id = a.Id;
                tmp.NumeroReporte = a.NumeroReporte;
                tmp.UsuarioSolicitud = a.Usuario.Expediente;
                result.Add(tmp);
            }

            return result;
        }
        /// <summary>
        /// Update Solicitud
        /// </summary>
        /// <param name="solicitud"></param>
        /// <returns>resultado de la operacion</returns>
        public JsonResult UpdateSolicitud(SolicitudViewModel solicitud)
        {
            try
            {
                this.cauServiciosService.CerrarFolio(solicitud.Id, solicitud.Comentario);
                this.cauServiciosService.Save();
                var data = new { result = true, mensaje = "El folio se cerro correctamente." };
                return Json(data, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}