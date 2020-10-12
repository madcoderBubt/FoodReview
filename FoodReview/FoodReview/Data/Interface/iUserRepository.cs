using FoodReview.Model;
using FoodReview.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FoodReview.Data.Interface
{
    interface IUserRepository
    {
        public Task<bool> Login(LoginViewModel login); //session starts
        public void Logout(); //session ends
        public User GetUserInfo(); //using session if logged in
        public int GetUserId(); //only if logged in
        public bool ChangePassword(string oldPass, string newPass);
        public Task<bool> Register(User user);
        public Task<bool> UpdateUserInfo(User user);
    }
}
