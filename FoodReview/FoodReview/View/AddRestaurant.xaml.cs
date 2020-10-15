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
    public partial class AddRestaurant : ContentPage
    {
        public AddRestaurant()
        {
            InitializeComponent();
        }

        public async void AddNewBtn_Clicked(object sender, EventArgs e)
        {
            Restaurant restaurant = new Restaurant()
            {
                ID = 0,
                Name = txtName.Text,
                Address = txtAddress.Text,
                OpenAt = dtOpenAt.Time,
                CloseAt = dtCloseAt.Time,
                Delivery = chkDeliver.IsChecked,
                Dining = chkDining.IsChecked,
                TakeAway = chkTakeAway.IsChecked,
                Phone = txtPhone.Text,
                Website = txtWebsite.Text
            };

            RestaurantRepository repository = new RestaurantRepository();
            if(await repository.AddRestaurent(restaurant))
            {
                if (await DisplayAlert("Notify", "Entity added successfull", "Done", "Add More"))
                {
                    await Navigation.PopAsync(true);
                }

            }
        }
    }
}