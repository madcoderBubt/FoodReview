using System;
using System.Collections.Generic;
using System.Text;

namespace FoodReview.ViewModel
{
    class RestaurantViewModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string OpenRange { get; set; }
        public string Phone { get; set; }
        public string Website { get; set; }
        public bool Dinning { get; set; }
        public bool TakeAway { get; set; }
        public bool Delivery { get; set; }

        
    }
}
