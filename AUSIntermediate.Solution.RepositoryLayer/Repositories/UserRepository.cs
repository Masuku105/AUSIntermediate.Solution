using AUSIntermediate.Solution.ServiceLayer;
using AUSIntermediate.Solution.ServiceLayer.Interfaces;
using AUSIntermediate.Solution.ServiceLayer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AUSIntermediate.Solution.RepositoryLayer.Repositories
{
    public class AddressRepositoryServic : IUserRepositoryService
    {
        private readonly AUSIntermediateDbContext _dbContext;

        public AddressRepositoryServic(AUSIntermediateDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<User> AddNewUser(User model)
        {
            _dbContext.Users.Add(model);
            await _dbContext.SaveChangesAsync();
            return model;
        }

        public async Task<User> DeleteUser(int id)
        {
            var user = _dbContext.Users.FirstOrDefault(x => x.UserId == id);
            _dbContext.Remove(user);
            await _dbContext.SaveChangesAsync();
            return user;
        }

        public async Task<List<User>> GetAllUsers()
        {
            var users = await _dbContext.Users.Include(x=> x.Addresses).Include(x=> x.Addresses).ToListAsync();
            return users;
        }

        public async Task<User> GetUserById(int id)
        {
            var user = await _dbContext.Users.Include(x => x.Addresses).FirstOrDefaultAsync(x => x.UserId == id);
            return user;
        }

        public async Task<User> UpdateUser(User model)
        {
            var user = await  _dbContext.Users.FirstOrDefaultAsync(x => x.UserId == model.UserId);

            user.UserId = model.UserId;
            user.Name = model.Name;
            user.Surname = model.Surname;
            user.IdentityNumber = model.IdentityNumber; 
            user.DateOfBirth = model.DateOfBirth;
            user.Email = model.Email;
            user.Contact = model.Contact;
            

            await _dbContext.SaveChangesAsync();

            return user;
        }
    }
}
