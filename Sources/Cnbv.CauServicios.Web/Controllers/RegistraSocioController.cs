// ----------------------------------------------------------------------- 
// <copyright file="RegistraSocioController.cs" company="C.N.B.V."> 
// Copyright © C.N.B.V. Todos los derechos reservados. 
// </copyright> 
// -----------------------------------------------------------------------
namespace Cnbv.CauServicios.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;
    using Cnbv.CauServicios.Model;
    using Cnbv.CauServicios.Service;

    /// <summary>
    /// Class RegistraSocioController.
    /// </summary>
    [Authorize]
    public class RegistraSocioController : Controller
    {

        private readonly ICauServiciosService socioService;

        public RegistraSocioController(ICauServiciosService socioService)
        {
            this.socioService = socioService;
        }

        /// <summary>
        /// Registras the socio.
        /// </summary>
        /// <returns>ActionResult.</returns>
        public ActionResult RegistraSocio()
        {
            this.ViewData["Periodo"] = this.ObtenerPeriodos();
            this.ViewData["Rol"] = this.ObtenerRoles();
            return View();
        }

        /// <summary>
        /// Guardas the datos socio.
        /// </summary>
        /// <param name="usuario">The usuario.</param>
        /// <returns>ActionResult.</returns>
        public ActionResult GuardaDatosSocio(Usuario usuario)
        {
            if (usuario != null)
            {
                this.socioService.CreateUsuario(usuario);
                this.socioService.Save();
            }

            return RedirectToAction("Socios", "Socios");
        }

        /// <summary>
        /// Obteners the periodos.
        /// </summary>
        /// <returns>List{SelectListItem}.</returns>
        private List<SelectListItem> ObtenerPeriodos()
        {
            return new List<SelectListItem>()
           {
                new SelectListItem()
                {
                    Selected = false,
                    Text = "Semanal",
                    Value = "1"
                },
                new SelectListItem()
                {
                    Selected = false,
                    Text = "Quincenal",
                    Value = "2"
                },
                new SelectListItem()
                {
                    Selected = false,
                    Text = "Mensual",
                    Value = "3"
                },
           };
        }

        /// <summary>
        /// Obteners the roles.
        /// </summary>
        /// <returns>List{SelectListItem}.</returns>
        private List<SelectListItem> ObtenerRoles()
        {
            return new List<SelectListItem>()
           {
                new SelectListItem()
                {
                    Selected = false,
                    Text = "Administrador",
                    Value = "1"
                },
                new SelectListItem()
                {
                    Selected = false,
                    Text = "Socio",
                    Value = "2"
                }
           };
        }
    }
}
