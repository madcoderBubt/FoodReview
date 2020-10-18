using FoodReview.Data;
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
    public partial class HomePageDetail : ContentPage
    {
        public HomePageDetail()
        {
            InitializeComponent();
        }

        private async void btnAddRestaurent_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddRestaurant());
        }

        private async void btnUsers_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new UserView());
        }
        private async void btnAddRole_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddRole());
        }
    }
}