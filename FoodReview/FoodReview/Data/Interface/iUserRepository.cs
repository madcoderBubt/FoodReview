using FoodReview.Model;
using FoodReview.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodReview.Data.Interface
{
    interface IUserRepository
    {
        public void Login(LoginViewModel login); //session starts
        public void Logout(); //session ends
        public bool Register(User user);
        public User GetUserInfo(); //using session if logged in
        public int GetUserId(); //only if logged in
        public bool ChangePassword(string oldPass, string newPass);
        public bool UpdateUserInfo(User user);
    }
}
