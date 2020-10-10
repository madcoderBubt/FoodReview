using FoodReview.Model.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodReview.Model
{
    class RestaurantReview : SModel
    {
        public String Title { get; set; }
        public String Details { get; set; }        
        public int FoodRating { get; set; }
        public int ServiceRating { get; set; }
        public DateTime ReviewDate { get; set; }
        public int ResturentId { get; set; }
        public Restaurant Resturent { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }

    }
}
