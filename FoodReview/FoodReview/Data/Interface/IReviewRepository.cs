using FoodReview.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodReview.Data.Interface
{
    interface IReviewRepository
    {
        public bool AddReview(RestaurantReview review);
        public bool EditReview(RestaurantReview review);
        public bool DeleteReview(RestaurantReview review);
        public RestaurantReview GetReviewById(int ReviewId);
    }
}
