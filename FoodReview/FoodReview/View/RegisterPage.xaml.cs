using FoodReview.Data;
using FoodReview.Data.Interface;
using FoodReview.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FoodReview.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterPage : ContentPage
    {
        UserRepository User;
        public RegisterPage()
        {
            InitializeComponent();
        }

        private void btnBack_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new MainPage();
        }

        private async void btnSign_Clicked(object sender, EventArgs e)
        {
            User = new UserRepository();

            if (txtPassword.Text == txtPassRenter.Text)
            {
                User user = new User()
                {
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    Email = txtEmail.Text,
                    Password = txtPassword.Text,
                    PhoneNo = txtPhone.Text
                };
                try
                {
                    if(await User.Register(user))
                    {
                        await DisplayAlert("Alert", "Register Successed", "Ok");
                        await App.Current.MainPage.Navigation.PopAsync();
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
            else
            {
                msgError.Text = "Pass & RePass not matched.";
            }
            
        }
    }
}