using FoodReview.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodReview.Data.Interface
{
    interface IRestaurentRepository
    {
        public IEnumerable<Restaurant> GetRestaurentList();
        public Restaurant GetRestaurentById(int id);
        public IEnumerable<Restaurant> GetRestaurentsByName();
        public bool UpdateRestaurent(Restaurant restaurant);
        public void GetRestaurentRankingById(int RestaurentId);
        public bool AddRestaurent(Restaurant restaurant);
        public void DeleteRestaurent(int RestaurentId);
        public IEnumerable<RestaurantReview> GetReviewList(int RestaurentId);
    }
}
