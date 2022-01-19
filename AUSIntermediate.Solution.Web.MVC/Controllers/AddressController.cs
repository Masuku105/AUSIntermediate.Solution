using AUSIntermediate.Solution.BusinessLogicLayer.DTOs;
using AUSIntermediate.Solution.BusinessLogicLayer.Interfaces;
using AUSIntermediate.Solution.Web.MVC.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AUSIntermediate.Solution.Web.MVC.Controllers
{
    public class AddressController : Controller
    {
        private readonly IAddressBusinessLogic _addressBusiness;
        private readonly IMapper _objecMapper;

        public AddressController(IAddressBusinessLogic addressBusiness, IMapper objecMapper)
        {
            _addressBusiness = addressBusiness;
            _objecMapper = objecMapper;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }


        //POST - CREATE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(AddressModel address)
        {
            
            if (ModelState.IsValid)
            {
                var addressObject = _objecMapper.Map<AddressModel, AddressDTO>(address);  
                await _addressBusiness.AddAddress(addressObject);
            }
            return View(address);

        }
    }
}
