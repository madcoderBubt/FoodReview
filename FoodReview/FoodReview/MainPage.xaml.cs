using FoodReview.Data;
using FoodReview.Model;
using FoodReview.View;
using FoodReview.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FoodReview
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        UserRepository user;
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnSign_Clicked(object sender, EventArgs e)
        {
            user = new UserRepository();
            try
            {
                LoginViewModel login = new LoginViewModel()
                {
                    UserName = txtUserName.Text,
                    Password = txtPassword.Text
                };

                //txtUserName.Text == "madcoder" && txtPassword.Text == "1234"
                if (await user.Login(login))
                {
                    //await App.Current.MainPage.Navigation.PushAsync(new HomePage());
                    App.Current.MainPage = new HomePage();
                }
                else
                {
                    await DisplayAlert("Login Error", "You are not authorized user.", "ok");
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error Notify", ex.Message, "Ok");
            }
            
        }

        private async void btnSignUp_Clicked(object sender, EventArgs e)
        {
            try
            {
                await App.Current.MainPage.Navigation.PushAsync(new RegisterPage());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error Notify", ex.Message, "Ok");
            }
        }
    }
}
