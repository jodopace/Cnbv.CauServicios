using Cnbv.CauServicios.Service;
using Cnbv.CauServicios.Web.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace Cnbv.CauServicios.Web.Controllers
{
    public class AsignarFoliosController : Controller
    {
        private readonly ICauServiciosService cauServiciosService;

        /// <summary>
        /// Constructor of then controller
        /// </summary>
        /// <param name="cauServiciosService"></param>
        public AsignarFoliosController(ICauServiciosService cauServiciosService)
        {
            this.cauServiciosService = cauServiciosService;
        }

        // GET: AsignarFolios
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult AsignNewFolio(string folio)
        {
            try
            {
               string asignadoa= this.cauServiciosService.AsignarFolioNuevo(folio);
                this.cauServiciosService.Save();

                var data = new { Name = asignadoa, result = "Se asigno nuevo correectamente" };
                
                return Json(data, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        [Authorize(Roles = "Administrador,IngenieroSoporte,Gerente")]
        public ActionResult AsignarFolio()
       {
            return View();
        }

        [HttpPost]
        public JsonResult NewChart()
        {
            List<ChartViewModel> result = this.GetAllCurrentIncidents();
            List<object> iData = new List<object>();
            object Nombre = (from a in result select a.Name).ToList();
            object Solicitudes = (from a in result select a.NoSolicitudesAsignadasHoy).ToList();
            object Color = (from a in result select a.Color).ToList();
            iData.Add(Nombre);
            iData.Add(Solicitudes);
            iData.Add(Color);          
            return Json(iData, JsonRequestBehavior.AllowGet);
        }

        private List<ChartViewModel> GetAllCurrentIncidents()
        {
            try
            {

                List<Model.Usuario> result = this.cauServiciosService.GetFoliosAsignadosDelDia();
                List<ChartViewModel> ChartViewModelList = new List<ChartViewModel>();

                foreach (var x in result)
                {
                    ChartViewModel aux = new ChartViewModel();
                    aux.IngenieroId = x.Id;
                    aux.Name = x.NombreCompleto;
                    aux.Color = x.Color;
                    aux.IdentificadorHorario = x.IdHorario;
                    aux.NoSolicitudesAsignadasHoy = x.Solicitudes.Count;

                    ChartViewModelList.Add(aux);
                }

                
                

                return ChartViewModelList;               
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}