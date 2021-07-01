using AutoMapper;
using AutoMapperAppPresents.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AutoMapperAppPresents.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMapper mapper;

        public HomeController(IMapper mapper)
        {
            this.mapper = mapper;
        }

        public IActionResult Index()
        {
            var user = AppRepository.GetUser();
            var model = mapper.Map<UserViewModel>(user);
            return View(model);
        }

        public IActionResult UserProducts()
        {
            var products = AppRepository.GetUser().Products;
            var models = mapper.Map<List<ProductViewModel>>(products);
            return View(models);
        }
    }
}
