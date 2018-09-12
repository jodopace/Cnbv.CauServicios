// ----------------------------------------------------------------------- 
// <copyright file="DomainToViewModelMappingProfile.cs" company="C.N.B.V."> 
// Copyright © C.N.B.V. Todos los derechos reservados. 
// </copyright> 
// -----------------------------------------------------------------------
namespace Cnbv.CauServicios.Web.Mapping
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using AutoMapper;
    using Cnbv.CauServicios.Model;
    using Cnbv.CauServicios.Web.Models;

    /// <summary>
    /// Class DomainToViewModelMappingProfile.
    /// </summary>
    public class DomainToViewModelMappingProfile : Profile
    {        
        ///// <summary>
        ///// Override this method in a derived class and call the CreateMap method to associate that map with this profile.
        ///// Avoid calling the <see cref="T:AutoMapper.Mapper" /> class from this method.
        ///// </summary>
        //protected override void Configure()
        //{
        //    Mapper.CreateMap<Socio, SocioViewModel>();
        //}
    }
}
