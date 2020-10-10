using FoodReview.Data.Interface;
using FoodReview.Model;
using FoodReview.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodReview.Data
{
    class UserRepository : IUserRepository
    {
        public UserRepository()
        {

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

        public void Login(LoginViewModel login)
        {
            throw new NotImplementedException();
        }

        public void Logout()
        {
            throw new NotImplementedException();
        }

        public bool Register(User user)
        {
            throw new NotImplementedException();
        }

        public bool UpdateUserInfo(User user)
        {
            throw new NotImplementedException();
        }
    }
}
