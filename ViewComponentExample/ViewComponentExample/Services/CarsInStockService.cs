using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewComponentExample.Models;
using ViewComponentExample.Utility;


namespace ViewComponentExample.Services
{
    public class CarsInStockService : ICarsInStockService
    {
        private static ConcurrentBag<CarModel> _carStore;
        public CarsInStockService()
        {
            _carStore = new ConcurrentBag<CarModel>();
            List<CarModel> dummyCars = CreateDummyStock.GetDummyStock();
            foreach (CarModel carModel in dummyCars)
            {
                _carStore.Add(carModel);
            }
        }
        public Task<bool> AddCarToStock(CarModel model)
        {
            _carStore.Add(model);
            return Task.FromResult(true);
        }
        public Task<List<CarModel>> AllCars()
        {
            List<CarModel> allCars = new List<CarModel>();
            foreach (var car in _carStore)
            {
                allCars.Add(car);
            }
            return Task.FromResult(allCars);
        }


        public Task<CarModel> GetModelById(Guid? guid)
        {
            if (guid == null)
            {
                return Task.FromResult(_carStore.First());
            }
            else
            {
                return Task.FromResult(_carStore.FirstOrDefault(car => car.ID == guid));
            }
        }
    }
}
