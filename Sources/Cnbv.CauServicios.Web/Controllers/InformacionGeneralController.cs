// ----------------------------------------------------------------------- 
// <copyright file="InformacionGeneralController.cs" company="C.N.B.V."> 
// Copyright © C.N.B.V. Todos los derechos reservados. 
// </copyright> 
// -----------------------------------------------------------------------
namespace Cnbv.CauServicios.Web.Controllers
{
    using System.Web.Mvc;
    using System.Web.Security;
    using Cnbv.CauServicios.Model;
    using Cnbv.CauServicios.Service;

    /// <summary>
    /// Class InformacionGeneralController.
    /// </summary>
    [Authorize]
    public class InformacionGeneralController : Controller
    {
        private readonly ICauServiciosService socioService;

        public InformacionGeneralController(ICauServiciosService socioService)
        {
            this.socioService = socioService;
        }

        /// <summary>
        /// Informacions the general.
        /// </summary>
        /// <returns>Action Result.</returns>
        public ActionResult InformacionGeneral()
        {
            var socio = this.socioService.GetUsuarioById(User.Identity.Name);           
            return this.View(socio);
        }
    }
}
