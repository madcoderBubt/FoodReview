using FoodReview.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FoodReview.Data
{
    public class Database
    {
        readonly SQLiteAsyncConnection _database;

        public Database(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Restaurant>().Wait();
            _database.CreateTableAsync<RestaurantReview>().Wait();
            _database.CreateTableAsync<Images>().Wait();
            _database.CreateTableAsync<imgResturant>().Wait();
            _database.CreateTableAsync<Role>().Wait();
            _database.CreateTableAsync<User>().Wait();
        }

        public Task<List<Restaurant>> GetPeopleAsync()
        {
            return _database.Table<Restaurant>().ToListAsync();
        }

        public Task<int> SavePersonAsync(Restaurant person)
        {
            return _database.InsertAsync(person);
        }
    }
}
