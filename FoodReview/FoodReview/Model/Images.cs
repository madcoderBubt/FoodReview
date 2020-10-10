using FoodReview.Model.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodReview.Model
{
    class Images : SModel
    {
        public string imgUri { get; set; }
        public DateTime UpdateAt { get; set; }
    }
}
