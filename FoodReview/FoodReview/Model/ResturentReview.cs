using System;
using System.Collections.Generic;
using System.Text;

namespace FoodReview.Model
{
    class ResturentReview
    {
        public String Subject { get; set; }
        public String Details { get; set; }
        public int FoodRating { get; set; }
        public int ServiceRating { get; set; }
        public DateTime ReviewDate { get; set; }
        public int ResturentId { get; set; }
        public ResturentModel Resturent { get; set; }
        public int UserId { get; set; }
        public UserModel User { get; set; }
    }
}
