using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;
using Cnbv.CauServicios.Model;
using Cnbv.CauServicios.Web.Models;
using AutoMapper.XpressionMapper;

namespace Cnbv.CauServicios.Web.Mapping
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        //protected override void Configure()
        //{
        //    var config = new MapperConfiguration(cfg => {
        //        cfg.CreateMap<SocioViewModel, Socio>();
        //    });

        //    IMapper mapper = config.CreateMapper();
        //    var source = new Source();
        //    var dest = mapper.Map<SocioViewModel, Socio>(source);          
        //    //.ForMember(g => g.Name, map => map.MapFrom(vm => vm.GadgetTitle))
        //    //.ForMember(g => g.Description, map => map.MapFrom(vm => vm.GadgetDescription))
        //    //.ForMember(g => g.Price, map => map.MapFrom(vm => vm.GadgetPrice))
        //    //.ForMember(g => g.Image, map => map.MapFrom(vm => vm.File.FileName))
        //    //.ForMember(g => g.CategoryID, map => map.MapFrom(vm => vm.GadgetCategory));
        //}
    }
}
