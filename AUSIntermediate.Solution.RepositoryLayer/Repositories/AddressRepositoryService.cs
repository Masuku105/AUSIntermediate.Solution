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
    public class AddressRepositoryService : IAddressRepositoryService
    {
        private readonly AUSIntermediateDbContext _dbContext;

        public AddressRepositoryService(AUSIntermediateDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Address> AddAddress(Address address)
        {
             _dbContext.Addresses.Add(address);
            await _dbContext.SaveChangesAsync();    
            return address;
        }

        public async Task<List<Address>> GetAllAddress()
        {
            var addresses = await _dbContext.Addresses.Include(a => a.User).ToListAsync();
            return addresses;
        }

        public async Task<List<Address>> GetUserAddressesByUserId(int userId)
        {
            var userAddresses = await _dbContext.Addresses.Include(a=> a.User).Where(a => a.UserId == userId).ToListAsync();
            return userAddresses;   
        }

        public async Task<Address> UpdateAddress(Address address)
        {
            var oldAddress = await _dbContext.Addresses.FirstOrDefaultAsync(x => x.AddressId == address.AddressId);

            oldAddress.Country = address.Country;   
            oldAddress.Province = address.Province; 
            oldAddress.City = address.City;
            oldAddress.Suburb = address.Suburb;
            oldAddress.UnitNUmber = address.UnitNUmber; 
            oldAddress.PostalCode = address.PostalCode;
            oldAddress.ComplexName = address.ComplexName;
            oldAddress.UserId = address.UserId;            


            await _dbContext.SaveChangesAsync();

            return oldAddress;
        }

        public async Task<Address> DeleteAddress(int userId)
        {
            var address = _dbContext.Addresses.FirstOrDefault(x => x.UserId == userId);
            _dbContext.Remove(address);
            await _dbContext.SaveChangesAsync();
            return address;
        }
    }
}
