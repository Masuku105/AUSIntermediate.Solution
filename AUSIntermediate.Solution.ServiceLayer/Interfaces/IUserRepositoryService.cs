using AUSIntermediate.Solution.ServiceLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AUSIntermediate.Solution.ServiceLayer.Interfaces
{
    public interface IUserRepositoryService
    {
        Task<List<User>> GetAllUsers();
        Task<User> GetUserById(int id);
        Task<User> AddNewUser(User model);
        Task<User> UpdateUser(User model);
        Task<User> DeleteUser(int id);
    }
}
