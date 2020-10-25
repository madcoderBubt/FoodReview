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
    public partial class RestaurantPage : ContentPage
    {
        Restaurant restaurant;
        public RestaurantPage()
        {
            InitializeComponent();
        }
        public RestaurantPage(Restaurant restaurant)
        {
            InitializeComponent();

            this.restaurant = restaurant;
            BindingContext = this;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            txtAddress.Text = restaurant.Address;
            txtWebsite.Text = restaurant.Website;
            txtPhone.Text = restaurant.Phone;
            txtName.Text = restaurant.Name;

            txtDelivery.Text = (restaurant.Delivery) ? "Delivery" : "";
            txtTakeaway.Text = (restaurant.TakeAway) ? "TakeAway" : "";
            txtDining.Text = (restaurant.Dining) ? "Dining" : "";

            var now = DateTime.Now.TimeOfDay;
            if (restaurant.OpenAt < now && restaurant.CloseAt > now)
            {
                txtStatus.Text = "Open Now";
                txtStatus.TextColor = Color.Green;
                txtTime.Text = "Close At: " + DateTime.Parse(restaurant.CloseAt.ToString()).ToString("t");
            }
            else
            {
                txtStatus.Text = "Closed";
                txtStatus.TextColor = Color.Red;
                txtTime.Text = "Opens At: " + DateTime.Parse(restaurant.OpenAt.ToString()).ToString("t");
            }
        }

        private void ReviewItem_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}