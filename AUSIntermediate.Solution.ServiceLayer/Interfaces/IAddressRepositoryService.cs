using AUSIntermediate.Solution.ServiceLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AUSIntermediate.Solution.ServiceLayer.Interfaces
{
    public interface IAddressRepositoryService
    {
        Task<Address> AddAddress(Address address);
        Task<List<Address>> GetAllAddress();
        Task<List<Address>> GetUserAddressesByUserId(int userId);
        Task<Address> UpdateAddress(Address address);
        Task<Address> DeleteAddress(int userId);
    }
}
