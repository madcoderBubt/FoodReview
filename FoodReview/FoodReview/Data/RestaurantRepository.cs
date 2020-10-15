using FoodReview.Data.Interface;
using FoodReview.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodReview.Data
{
    class RestaurantRepository //: IRestaurentRepository
    {
        readonly SQLiteAsyncConnection sQLite;
        public RestaurantRepository()
        {
            sQLite = new SQLiteAsyncConnection(App.DbPath);

            //Create Table on DB if there is none using model
            if (!sQLite.TableMappings.Any(m => m.MappedType.Name == typeof(Restaurant).Name))
                sQLite.CreateTableAsync<Restaurant>().Wait();
            if (!sQLite.TableMappings.Any(m => m.MappedType.Name == typeof(RestaurantReview).Name))
                sQLite.CreateTableAsync<RestaurantReview>().Wait();
        }
        
        public async Task<bool> AddRestaurent(Restaurant restaurant)
        {
            //Code here

            try
            {
                if (await sQLite.InsertAsync(restaurant) > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void DeleteRestaurent(int RestaurentId)
        {
            throw new NotImplementedException();
        }

        public Restaurant GetRestaurentById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IList<Restaurant>> GetRestaurentList()
        {
            try
            {
                var items = await sQLite.Table<Restaurant>().ToListAsync();
                return items;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public void GetRestaurentRankingById(int RestaurentId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Restaurant> GetRestaurentsByName()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<RestaurantReview> GetReviewList(int RestaurentId)
        {
            throw new NotImplementedException();
        }

        public bool UpdateRestaurent(Restaurant restaurant)
        {
            throw new NotImplementedException();
        }
    }
}
