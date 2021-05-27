using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OdeToFood.Data.Models;


namespace OdeToFood.Data.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> restaurants;

        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant {Id = 1, Name = "Jasmine's Pizza", Cuisine = CuisineType.Italian},
                new Restaurant {Id = 2, Name = "Pind Balluchi", Cuisine = CuisineType.Indian},
                new Restaurant {Id = 3, Name = "Coup De Food", Cuisine = CuisineType.French}
            };
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return restaurants.OrderBy(r => r.Name);
        }
    }
}
