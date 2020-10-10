using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodReview.Model.Shared
{
    public class SModel
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
    }
}
