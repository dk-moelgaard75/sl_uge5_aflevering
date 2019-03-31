using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ViewComponentExample.Services;
using ViewComponentExample.Models;

namespace ViewComponentExample.Controllers
{
    public class AddToStockController : Controller
    {
        private ICarsInStockService _carInStockService;
        public AddToStockController(ICarsInStockService carsInStockService)
        {
            _carInStockService = carsInStockService;
        }

        public IActionResult Index()
        {
            ViewData["Result"] = "No car has been added so far";
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index (CarModel carModel)
        {
            await _carInStockService.AddCarToStock(carModel);
            ViewBag.result = $"Car {carModel.Brand} - {carModel.Model} has been added to the stock ";
            return View();
        }        
    }
}