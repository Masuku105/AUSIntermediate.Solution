using AUSIntermediate.Solution.BusinessLogicLayer.DTOs;
using AUSIntermediate.Solution.BusinessLogicLayer.Interfaces;
using AUSIntermediate.Solution.Web.MVC.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreHero.ToastNotification.Abstractions;

namespace AUSIntermediate.Solution.Web.MVC.Controllers
{
    public class UserController : BaseController
    {
        private readonly IUserBusinessLogic _userBusiness;
        private readonly IMapper _objecMapper;
        private readonly IAddressBusinessLogic _addressBusiness;
        private readonly INotyfService _notyf;

        public UserController(IUserBusinessLogic userBusiness
            ,IAddressBusinessLogic addressBusiness
            , IMapper objecMapper, INotyfService notyf)
        {
            _userBusiness = userBusiness;
            _objecMapper = objecMapper;
            _addressBusiness = addressBusiness;
            _notyf = notyf;


        }
        public async Task<IActionResult> Index()
        {
            var results = await _userBusiness.GetAllUsers();
            var users = _objecMapper.Map<List<UserDTO>, List<UserModel>>(results);
            return View(users);
        }

        public async Task<IActionResult> Details(int id)
        {
            var userDto = await _userBusiness.GetUserById(id);
            var userDetails = _objecMapper.Map<UserModel>(userDto);
            return View(userDetails);
        }

        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(UserModel user)
        {
            
            var userDto = new UserDTO();
            if(ModelState.IsValid)
            {

                var newUser = _objecMapper.Map<UserModel, UserDTO>(user);
                try
                {
                    if(user.IdentityNumber.Length!=13)
                    {
                        _notyf.Error("Invalid ID Number");
                        return View(user);
                    }
                    if (user.Contact.Length != 10)
                    {
                        _notyf.Error("Invalid Contact Number");
                        return View(user);  
                    }

                    var savedUser = await _userBusiness.AddNewUser(newUser);
                    
                    if (user.ResidentialAddress != null)
                    {
                        var residentialAddress = _objecMapper.Map<AddressModel, AddressDTO>(user.ResidentialAddress);
                        residentialAddress.IsResidentialAddress = true;
                        residentialAddress.UserId = savedUser.UserId;                       
                        await _addressBusiness.AddAddress(residentialAddress);
                    }
                    if (user.PostalAddress != null)
                    {

                        var postalAddress = _objecMapper.Map<AddressModel, AddressDTO>(user.ResidentialAddress);
                        postalAddress.UserId = savedUser.UserId;                    
                        await _addressBusiness.AddAddress(postalAddress);
                      
                    }
                    _notyf.Success($"{savedUser.Name} Successfully Added");
                    return RedirectToAction("Index");
                }
                catch (Exception ex)
                {
                    _notyf.Error($"An Exception Occured {ex.Message}");

                }        


            }

            return View(user);
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var user = await _userBusiness.GetUserById(Convert.ToInt32(id));
            if (user == null)
            {
                return NotFound();
            }
            return View(_objecMapper.Map<UserModel>(user));
        }

       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(UserModel user)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    if (user.IdentityNumber.Length != 13)
                    {
                        _notyf.Error("Invalid ID Number");
                        return View(user);
                    }
                    if (user.Contact.Length != 10)
                    {
                        _notyf.Error("Invalid Contact Number");
                        return View(user);
                    }
                    await _userBusiness.UpdateUser(_objecMapper.Map<UserDTO>(user));
                    if (user.PostalAddress != null)
                        await _addressBusiness.UpdateAddress(_objecMapper.Map<AddressDTO>(user.PostalAddress));
                    if (user.PostalAddress != null)
                        await _addressBusiness.UpdateAddress(_objecMapper.Map<AddressDTO>(user.ResidentialAddress));
                    _notyf.Success("Successfully Updated Data");
                }                
            }
            catch (Exception ex)
            {
                _notyf.Error($"An Exception Occured {ex.Message}");
                return RedirectToAction("Index");
            }
           
            return RedirectToAction("Index");         
       
        }
        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var user = await _userBusiness.GetUserById(id);
            try
            {
                if (user == null)
                {
                    return RedirectToAction("Index");

                }
                await _userBusiness.DeleteUser(id);
                foreach (var address in user.Addresses)
                {
                    await _addressBusiness.DeleteAddress(address.AddressId);
                }
                _notyf.Success("User Removed");

            }
            catch (Exception ex)
            {
                _notyf.Error($"An Exception Occured {ex.Message}");
            }
            return RedirectToAction("Index");
        }


       

        [HttpGet]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var user = await _userBusiness.GetUserById(Convert.ToInt32(id));
            if (user == null)
            {
                return NotFound();
            }
            return View(_objecMapper.Map<UserModel>(user));
        }
    }
}
