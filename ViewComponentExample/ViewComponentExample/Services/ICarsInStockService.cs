using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ViewComponentExample.Models;

namespace ViewComponentExample.Services
{
    public interface ICarsInStockService
    {
        Task<bool> AddCarToStock(CarModel model);
        Task<CarModel> GetModelById(Guid? guid);
        Task<List<CarModel>> AllCars();
    }
}