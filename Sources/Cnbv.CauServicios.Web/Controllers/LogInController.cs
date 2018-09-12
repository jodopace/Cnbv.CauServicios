// ----------------------------------------------------------------------- 
// <copyright file="LogInController.cs" company="C.N.B.V."> 
// Copyright © C.N.B.V. Todos los derechos reservados. 
// </copyright> 
// -----------------------------------------------------------------------
namespace Cnbv.CauServicios.Web.Controllers
{
    using Cnbv.CauServicios.Web.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;
    using System.Web.Security;
    using Cnbv.CauServicios.Data;
    using Cnbv.CauServicios.Model;
    using Cnbv.CauServicios.Service;
    using System.Collections.ObjectModel;
    using System.Collections.Specialized;

    /// <summary>
    /// Class LogInController.
    /// </summary>
    public class LogInController : Controller
    {
        private readonly ICauServiciosService socioService;
        private readonly IActiveDirectoryService activeDirectorySrv;
        private NameValueCollection perfilesUsuario;
        private readonly TimeSpan expirationTimeSpan;

        public LogInController(ICauServiciosService socioService, IActiveDirectoryService activeSrv)
        {
            this.socioService = socioService;
            this.activeDirectorySrv = activeSrv;
            this.expirationTimeSpan= FormsAuthentication.Timeout;
        }


        /// <summary>
        /// Logs the in.
        /// </summary>
        /// <returns>ActionResult.</returns>
        public ActionResult LogIn()
        {
            return View();
        }

        /// <summary>
        /// Logs the off.
        /// </summary>
        /// <returns>ActionResult.</returns>
        public ActionResult LogOff()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("LogIn", "LogIn");
        }

        /// <summary>
        /// Logs the in user.
        /// </summary>
        /// <param name="usuario">The usuario.</param>
        /// <returns>ActionResult.</returns>
        public ActionResult LogInUser(ModelUser usuario)
        {
            if (ValidaUsuario(usuario))
            {               
                this.CreateTiket(usuario);
                return RedirectToAction("AsignarFolio", "AsignarFolios");
            }
            else
            {
                ModelState.AddModelError("Password", "Usuario o password invalidos.");
                return this.View("LogIn");
            }
        }

        private void CreateTiket(ModelUser usuario)
        {
            var now = DateTime.UtcNow.ToLocalTime();
            var socio = this.socioService.GetUsuarioById(usuario.User);

            var ticket = new FormsAuthenticationTicket(
            version: 1,
            name: usuario.User,
            issueDate: now,
            expiration: now.Add(this.expirationTimeSpan),
            isPersistent: false,
            userData: String.Join("|", socio.Perfiles.Select(x=>x.Descripcion).ToArray()));

            var encryptedTicket = FormsAuthentication.Encrypt(ticket);
            var cookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptedTicket);
            HttpContext.Response.Cookies.Add(cookie);
        }




        /// <summary>
        /// Validas the usuario.
        /// </summary>
        /// <param name="usuario">The usuario.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        private bool ValidaUsuario(ModelUser usuario)        
            {
            try
            {
                if (usuario != null)
                {
                    var socio = this.socioService.GetUsuarioById(usuario.User);
                    /////bool active = this.activeDirectorySrv.IsCnbvUser(usuario.User, usuario.Password);
                    bool active = string.Equals(usuario.Password, socio.Password);
                    bool userval = socio != null && socio.Perfiles.Count > 0;
                    HttpContext.Session["Usuario"] = socio;
                    return active && userval;

                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
