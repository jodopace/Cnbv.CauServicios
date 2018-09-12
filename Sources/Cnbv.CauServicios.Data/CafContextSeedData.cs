// ----------------------------------------------------------------------- 
// <copyright file="CafContextDBInicializer.cs" company="C.N.B.V."> 
// Copyright © C.N.B.V. Todos los derechos reservados. 
// </copyright> 
// -----------------------------------------------------------------------
namespace Cnbv.CauServicios.Data
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using Cnbv.CauServicios.Model;

    /// <summary>
    /// Class CafContextDBInicializer.
    /// </summary>
    public class CafContextSeedData : DropCreateDatabaseAlways<CauServiciosContext>
    {

        public CafContextSeedData()
        {
        }
        /// <summary>
        /// Seeds the specified context.
        /// </summary>
        /// <param name="context">The context.</param>
        protected override void Seed(CauServiciosContext context)
        {
            try
            {

                //IList<Perfil> defaultPerfiles = new List<Perfil>();
                //defaultPerfiles.Add(new Perfil() { Id = 1, Descripcion = "Administrador", Activo = true});
                ////defaultRoles.Add(new Horario() { CatRolId = 2, DescripcionRol = "Socio", FechaRegistro = DateTime.Now, UsuarioRegistra = "Default", FechaActualizacion = DateTime.Now, UsuarioActualiza = "Default" });

                //foreach (var perfil in defaultPerfiles)
                //{
                //    context.Perfil.Add(perfil);
                //}


                //IList<Usuario> defaultSocios = new List<Usuario>();

                //defaultSocios.Add(new Usuario() { Id = 1, Nombres = "Usuario Administrador", ApellidoMaterno = "Administrador", ApellidoPaterno = "Admin", Activo = true, Password = "administrador" });
                ///////defaultSocios.Add(new Usuario() { Id = 1, Nombres = "Socio de prueba", ApellidoMaterno = "Socio", ApellidoPaterno = "Socio", RolUserId = 2, CatPeriodoId = 1, CorreoElectronico = "socio@mail.com", Password = "socio" });

                //foreach (var socio in defaultSocios)
                //{
                //    context.Usuario.Add(socio);
                //}


                //IList<UsuarioPerfil> defaultUsuarioPerfil = new List<UsuarioPerfil>();
                //defaultUsuarioPerfil.Add(new UsuarioPerfil() {Id=1, IdUsuario= 1, IdPerfil= 1});
                ////defaultPeriodos.Add(new UsuarioPerfil() { CatPeriodoId = 2, IdUsuario = "Quincenal", FechaRegistro = DateTime.Now, IdPerfil = "Default", FechaActualizacion = DateTime.Now, UsuarioActualiza = "Default" });
                ////defaultPeriodos.Add(new UsuarioPerfil() { CatPeriodoId = 3, IdUsuario = "Mensual", FechaRegistro = DateTime.Now, IdPerfil = "Default", FechaActualizacion = DateTime.Now, UsuarioActualiza = "Default" });
                //foreach (var usuarioperfil in defaultUsuarioPerfil)
                //{
                //    context.UsuarioPerfil.Add(usuarioperfil);
                //}


                //IList<Solicitud> defaultSolicitudes = new List<Solicitud>();
                //defaultSolicitudes.Add(new Solicitud() { Id = 1, Comentario = "Prueba de Solicitud", fechaRegistro = DateTime.Now, NumeroReporte = "Test reporte" });
                ////defaultRoles.Add(new Horario() { CatRolId = 2, DescripcionRol = "Socio", FechaRegistro = DateTime.Now, UsuarioRegistra = "Default", FechaActualizacion = DateTime.Now, UsuarioActualiza = "Default" });

                //foreach (var solicitud in defaultSolicitudes)
                //{
                //    context.Solicitud.Add(solicitud);
                //}

                //IList<UsuarioSolicitud> defaultUsuarioSolicitud = new List<UsuarioSolicitud>();
                //defaultUsuarioSolicitud.Add(new UsuarioSolicitud() { Id = 1, IdUsuario = 1 });
                ////defaultPeriodos.Add(new UsuarioPerfil() { CatPeriodoId = 2, IdUsuario = "Quincenal", FechaRegistro = DateTime.Now, IdPerfil = "Default", FechaActualizacion = DateTime.Now, UsuarioActualiza = "Default" });
                ////defaultPeriodos.Add(new UsuarioPerfil() { CatPeriodoId = 3, IdUsuario = "Mensual", FechaRegistro = DateTime.Now, IdPerfil = "Default", FechaActualizacion = DateTime.Now, UsuarioActualiza = "Default" });
                //foreach (var usuarioSolicitud in defaultUsuarioSolicitud)
                //{
                //    context.UsuarioSolicitud.Add(usuarioSolicitud);
                //}

                //context.Commit();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
