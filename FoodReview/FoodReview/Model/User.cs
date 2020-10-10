using FoodReview.Model.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodReview.Model
{
    class User : SModel
    {
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Password { get; set; }
        public String PhoneNo { get; set; }
        public String Email { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }
    }
}
