using FoodReview.Data.Interface;
using FoodReview.Model;
using FoodReview.ViewModel;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodReview.Data
{
    class UserRepository : IUserRepository
    {
        readonly SQLiteAsyncConnection sQLite;
        public UserRepository()
        {
            sQLite = new SQLiteAsyncConnection(App.DbPath);

            //Create Table on DB if there is none using model
            //if(!sQLite.TableMappings.Any(m=>m.MappedType.Name == typeof(Role).Name))
                sQLite.CreateTableAsync<Role>().Wait();
            //if (!sQLite.TableMappings.Any(m => m.MappedType.Name == typeof(User).Name))
                sQLite.CreateTableAsync<User>().Wait();
        }

        public bool ChangePassword(string oldPass, string newPass)
        {
            throw new NotImplementedException();
        }

        public int GetUserId()
        {
            throw new NotImplementedException();
        }

        public User GetUserInfo()
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Login(LoginViewModel login)
        {
            try
            {
                var data = await sQLite.Table<User>().Where(f => f.Email == login.UserName && f.Password == login.Password).FirstOrDefaultAsync();

                if (data != null)
                {
                    UserSessionData.UserId = data.ID;
                    UserSessionData.UserEmail = data.Email;
                    UserSessionData.UserName = data.FirstName;
                    UserSessionData.StartAt = DateTime.Now;

                    return true;
                }
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void Logout()
        {
            UserSessionData.UserId = 0;
            UserSessionData.UserEmail = null;
            UserSessionData.UserName = null;
        }

        public async Task<bool> Register(User user)
        {
            try
            {
                if (await sQLite.InsertAsync(user) > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task<bool> UpdateUserInfo(User user)
        {
            try
            {
                if (await sQLite.UpdateAsync(user) > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
