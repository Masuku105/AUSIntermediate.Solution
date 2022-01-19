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

namespace AUSIntermediate.Solution.BusinessLogicLayer.Services.UserBLL
{
    public class UserBusinessLogic : IUserBusinessLogic
    {
        private readonly IUserRepositoryService _userService;
        private readonly IMapper _objectMapper;

        public UserBusinessLogic(IUserRepositoryService userService, IMapper objectMapper)
        {
            _userService = userService;
            _objectMapper = objectMapper;
        }
        public async Task<UserDTO> AddNewUser(UserDTO model)
        {
            var user = _objectMapper.Map<UserDTO, User>(model);
            var result = await _userService.AddNewUser(user);
            return _objectMapper.Map<User, UserDTO>(result);
        }

        public async Task<UserDTO> DeleteUser(int id)
        {
            var user = await _userService.DeleteUser(id);
            return  _objectMapper.Map<User, UserDTO>(user);
        }

        public async Task<List<UserDTO>> GetAllUsers()
        {
            var users = await _userService.GetAllUsers();
            return _objectMapper.Map<List<User>, List<UserDTO>>(users);
        }

        public async Task<UserDTO> GetUserById(int id)
        {
            var user = await _userService.GetUserById(id);
            return _objectMapper.Map<User, UserDTO>(user);
        }

        public async Task<UserDTO> UpdateUser(UserDTO model)
        {
            var user = _objectMapper.Map<UserDTO, User>(model);
            var result = await _userService.UpdateUser(user);
            return _objectMapper.Map<User, UserDTO>(result);
        }
    }
}
