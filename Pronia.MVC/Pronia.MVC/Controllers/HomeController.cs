using Microsoft.AspNetCore.Mvc;
using Pronia.BL.Services.Abstractions;
using Pronia.DAL.Contexts;
using Pronia.DAL.Models;

namespace Pronia.MVC.Controllers
{
    public class HomeController : Controller
    {

        //public readonly ProniaDbContext _context;
        //public HomeController()
        //{

        //    _context = new ProniaDbContext();
        //}
        //private readonly ProniaDbContext _context;

        //public HomeController(ProniaDbContext context)
        //{
        //    _context = context;
        //}
        private readonly ISliderItemService _sliderItemService;

        public HomeController(ISliderItemService sliderItemService)
        {
            _sliderItemService = sliderItemService;
        }

        public async Task<IActionResult> Index()
        {
            List<SliderItem> sliderItems = await _sliderItemService.GetAllSliderItemsAsync();
            return View(sliderItems);
        }
    }
}
