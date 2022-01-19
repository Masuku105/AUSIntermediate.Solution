using AUSIntermediate.Solution.BusinessLogicLayer.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AUSIntermediate.Solution.BusinessLogicLayer.Interfaces
{
    public interface IAddressBusinessLogic
    {
        Task<AddressDTO> AddAddress(AddressDTO address);
        Task<List<AddressDTO>> GetAllAddress();
        Task<List<AddressDTO>> GetUserAddressesByUserId(int id);
        Task<AddressDTO> UpdateAddress(AddressDTO address);
        Task<AddressDTO> DeleteAddress(int userId);
    }
}
