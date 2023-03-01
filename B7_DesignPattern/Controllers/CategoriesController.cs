using B7_DesignPattern.Services.InterfaceServices;
using Microsoft.AspNetCore.Mvc;

namespace B7_DesignPattern.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly ICategoriesService _iService;

        public CategoriesController(ICategoriesService iService)
        {
            _iService = iService;
        }

        public IActionResult Index()
        {
            var data = _iService.GetAll();
            return View(data);
        }
    }
}
