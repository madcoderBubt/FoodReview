using FoodReview.Model.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodReview.Model
{
    public class Restaurant : SModel
    {
        public String Name { get; set; }
        public String Address { get; set; }
        public TimeSpan OpenAt { get; set; }
        public TimeSpan CloseAt { get; set; }
        //public String Direction { get; set; }
        public String Phone { get; set; }
        public String Website { get; set; }
        public bool Dining { get; set; }
        public bool TakeAway { get; set; }
        public bool Delivery { get; set; }
        //public double FoodRating { get; set; }
        //public double ServiceRating { get; set; }
    }
}
