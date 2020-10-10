using FoodReview.Model.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodReview.Model
{
    class imgResturant : SModel
    {
        public int RestaurantId { get; set; }
        public Restaurant Restaurant { get; set; }

        public int RestaurentReviewId { get; set; }
        public RestaurantReview RestaurantReview { get; set; }
    }
}
