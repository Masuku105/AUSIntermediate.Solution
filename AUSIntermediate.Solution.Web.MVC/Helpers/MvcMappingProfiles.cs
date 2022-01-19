using AUSIntermediate.Solution.BusinessLogicLayer.DTOs;
using AUSIntermediate.Solution.ServiceLayer.Models;
using AUSIntermediate.Solution.Web.MVC.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AUSIntermediate.Solution.Web.MVC.Helpers
{
    public class MvcMappingProfiles : Profile
    {
        public MvcMappingProfiles()
        {
            CreateMap<UserModel, UserDTO>()/*.ForMember(x => x.Addresses, opt => opt.Ignore())*/;
            CreateMap<UserDTO, UserModel>();
           

            CreateMap<AddressModel, AddressDTO>();
            CreateMap<AddressDTO, AddressModel>();
         


        }
    }
}
