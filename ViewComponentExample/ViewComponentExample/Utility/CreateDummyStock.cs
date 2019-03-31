using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewComponentExample.Models;
using ViewComponentExample.Services;

namespace ViewComponentExample.Utility
{
    public static class CreateDummyStock
    {
        public static List<CarModel> GetDummyStock()
        {
            List<CarModel> models = new List<CarModel>();
            CarModel dummy1 = new CarModel
            {
                Header = "Ny Skoda Octavia",
                Brand = "Skoda",
                Model = "Octavia",
                NrOfKM = 0,
                Year = 2019,
                Price = 300000
            };
            CarModel dummy2 = new CarModel
            {
                Header = "Næste ny Passat",
                Brand = "VW",
                Model = "Passat",
                NrOfKM = 100,
                Year = 2018,
                Price = 250000
            };

            CarModel dummy3 = new CarModel
            {
                Header = "Ældre Porche",
                Brand = "Porche",
                Model = "911",
                NrOfKM = 100000,
                Year = 2010,
                Price = 500000
            };

            models.Add(dummy1);
            models.Add(dummy2);
            models.Add(dummy3);
            return models;


        }
    }
}
