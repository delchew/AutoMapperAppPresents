using AutoMapperAppPresents.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AutoMapperAppPresents.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var user = AppRepository.GetUser();
            var model = new UserViewModel
            {
                Id = user.Id,
                Name = user.Name,
                Surname = user.Surname,
                Email = user.Email
            };
            return View(model);
        }

        public IActionResult UserProducts()
        {
            var model = AppRepository.GetUser().Products.Select(p => new ProductViewModel { Title = p.Title, Cost = p.Cost, Description = p.Description});
            return View(model);
        }
    }
}
