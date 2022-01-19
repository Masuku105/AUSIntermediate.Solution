using AUSIntermediate.Solution.BusinessLogicLayer.DTOs;
using AUSIntermediate.Solution.ServiceLayer.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AUSIntermediate.Solution.BusinessLogicLayer
{
    public class BusinessMappingProfiles : Profile
    {
        public BusinessMappingProfiles()
        {
            CreateMap<UserDTO, User>()/*.ForMember(x=> x.Addresses, opt=> opt.Ignore())*/;
            CreateMap<User, UserDTO>();
            CreateMap<AddressDTO, Address>();
            CreateMap<Address, AddressDTO>();
        }
    }
}
