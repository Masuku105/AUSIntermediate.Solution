using AUSIntermediate.Solution.BusinessLogicLayer.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AUSIntermediate.Solution.BusinessLogicLayer.Interfaces
{
    public interface IUserBusinessLogic
    {

        Task<List<UserDTO>> GetAllUsers();
        Task<UserDTO> GetUserById(int id);
        Task<UserDTO> AddNewUser(UserDTO model);
        Task<UserDTO> UpdateUser(UserDTO model);
        Task<UserDTO> DeleteUser(int id);
    }
}
