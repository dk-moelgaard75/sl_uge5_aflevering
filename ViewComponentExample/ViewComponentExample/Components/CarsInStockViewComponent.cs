using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewComponentExample.Services;
using ViewComponentExample.Models;

namespace ViewComponentExample.Components
{
    [ViewComponent(Name = "CarsInStock")]
    public class CarsInStockViewComponent : ViewComponent
    {
        ICarsInStockService _carsInStockService;
        public CarsInStockViewComponent(ICarsInStockService carsInStockService)
        {
            _carsInStockService = carsInStockService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var cars = await _carsInStockService.AllCars();
            return View(cars);

        }


    }
}
