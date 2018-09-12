// ----------------------------------------------------------------------- 
// <copyright file="SociosController.cs" company="C.N.B.V."> 
// Copyright © C.N.B.V. Todos los derechos reservados. 
// </copyright> 
// -----------------------------------------------------------------------
namespace Cnbv.CauServicios.Web.Controllers
{
    using Cnbv.CauServicios.Model;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;
    using Cnbv.CauServicios.Service;

    /// <summary>
    /// Class SociosController.
    /// </summary>
    [Authorize]
    public class SociosController : Controller
    {
        private readonly ICauServiciosService socioService;

        public SociosController(ICauServiciosService socioService)
        {
            this.socioService = socioService;
        }


        /// <summary>
        /// Socioses this instance.
        /// </summary>
        /// <returns>ActionResult.</returns>
        public ActionResult Socios()
        {            
            return View();
        }

        /// <summary>
        /// Gets the data.
        /// </summary>
        /// <returns>JsonResult.</returns>
        [HttpGet]
        public JsonResult GetData()
        {
            List<Usuario> myList = this.socioService.GetUsuario().ToList();
            return new JsonResult()
            {
                Data = myList.ToArray(),
                JsonRequestBehavior = JsonRequestBehavior.AllowGet
            };
        }
      
    }
}
