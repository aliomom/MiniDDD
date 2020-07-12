using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Service.Dto;
using Service.Service.ServiceInterface;

namespace Web.Controllers
{
    public class ProductController : Controller
    {
        IProuductService _prouductService; 
        public ProductController(IProuductService productService)
        {
            _prouductService = productService;
        }

        public IActionResult Add()
        {
     
            return View();
        }

        [HttpPost]
        public IActionResult Add(ProductDto dto)
        {
            _prouductService.add(dto);

            return View();
        }
    }
}
