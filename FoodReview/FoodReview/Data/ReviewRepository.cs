using FoodReview.Data.Interface;
using FoodReview.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FoodReview.Data
{
    class ReviewRepository 
    {
        private readonly SQLiteAsyncConnection sQLite;

        public ReviewRepository()
        {
            sQLite = new SQLiteAsyncConnection(App.DbPath);
        }

        public async Task<bool> AddReview(RestaurantReview review)
        {
            try
            {
                if (await sQLite.InsertAsync(review) > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteReview(RestaurantReview review)
        {
            throw new NotImplementedException();
        }

        public bool EditReview(RestaurantReview review)
        {
            throw new NotImplementedException();
        }

        public RestaurantReview GetReviewById(int ReviewId)
        {
            throw new NotImplementedException();
        }
    }
}
