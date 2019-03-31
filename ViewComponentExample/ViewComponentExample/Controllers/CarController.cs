using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ViewComponentExample.Models;
using ViewComponentExample.Services;

namespace ViewComponentExample.Controllers
{
    public class CarController : Controller
    {
        private ICarsInStockService _carsInStockService;
        public CarController(ICarsInStockService carsInStock)
        {
            _carsInStockService = carsInStock;
        }
        public IActionResult Index()
        {
            var model = _carsInStockService.GetModelById(null).Result;
            return View(model);
        }      
        public IActionResult ViewAllCars()
        {
            return View();
        }
    }
}