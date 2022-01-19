using AUSIntermediate.Solution.BusinessLogicLayer.DTOs;
using AUSIntermediate.Solution.BusinessLogicLayer.Interfaces;
using AUSIntermediate.Solution.ServiceLayer.Interfaces;
using AUSIntermediate.Solution.ServiceLayer.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AUSIntermediate.Solution.BusinessLogicLayer.Services.AddressBLL
{
    public class AddressBusinessLogic : IAddressBusinessLogic
    {
        private readonly IAddressRepositoryService _addressService;
        private readonly IMapper _objectMapper;

        public AddressBusinessLogic(IAddressRepositoryService addressService, IMapper objectMapper)
        {
            _addressService = addressService;
            _objectMapper = objectMapper;
        }
        public async Task<AddressDTO> AddAddress(AddressDTO address)
        {
            var model = _objectMapper.Map<AddressDTO, Address>(address);
            var newAddress = await _addressService.AddAddress(model);
            return _objectMapper.Map< Address, AddressDTO>(newAddress);
        }

        public async Task<AddressDTO> DeleteAddress(int userId)
        {
            var address = await _addressService.DeleteAddress(userId);
            return _objectMapper.Map<Address, AddressDTO>(address);
        }

        public async Task<List<AddressDTO>> GetAllAddress()
        {
            var addresses = await _addressService.GetAllAddress();
            return _objectMapper.Map<List<Address>,List<AddressDTO>>(addresses);
        }

        public async Task<List<AddressDTO>> GetUserAddressesByUserId(int id)
        {
            var addresses = await _addressService.GetUserAddressesByUserId(id);
            return _objectMapper.Map<List<Address>, List<AddressDTO>>(addresses);
        }

        public async Task<AddressDTO> UpdateAddress(AddressDTO address)
        {
            var model = _objectMapper.Map<AddressDTO, Address>(address);
            var newAddress = await _addressService.UpdateAddress(model);
            return _objectMapper.Map<Address, AddressDTO>(newAddress);
        }
    }
}
