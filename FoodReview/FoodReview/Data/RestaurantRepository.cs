using FoodReview.Data.Interface;
using FoodReview.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodReview.Data
{
    class RestaurantRepository : IRestaurentRepository
    {
        public bool AddRestaurent(Restaurant restaurant)
        {
            //Code here
            

            return true;
        }

        public void DeleteRestaurent(int RestaurentId)
        {
            throw new NotImplementedException();
        }

        public Restaurant GetRestaurentById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Restaurant> GetRestaurentList()
        {
            throw new NotImplementedException();
        }

        public void GetRestaurentRankingById(int RestaurentId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Restaurant> GetRestaurentsByName()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<RestaurantReview> GetReviewList(int RestaurentId)
        {
            throw new NotImplementedException();
        }

        public bool UpdateRestaurent(Restaurant restaurant)
        {
            throw new NotImplementedException();
        }
    }
}
