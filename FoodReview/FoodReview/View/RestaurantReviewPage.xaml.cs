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
    public partial class RestaurantReviewPage : ContentPage
    {
        public RestaurantReviewPage()
        {
            InitializeComponent();
        }

        public RestaurantReviewPage(int id)
        {
            InitializeComponent();
            txtResturantId.Text = id.ToString();
        }

        private async void btnAddNew_Clicked(object sender, EventArgs e)
        {
            RestaurantReview review = new RestaurantReview()
            {
                ID = 0,
                Title = txtName.Text,
                Details = txtDetails.Text,
                FoodRating = pkrFood.SelectedIndex,
                ServiceRating = pkrService.SelectedIndex,
                ReviewDate = DateTime.Now,
                ResturentId = Int32.Parse(txtResturantId.Text),
                UserId = UserSessionData.UserId
            };

            ReviewRepository repository = new ReviewRepository();
            if (await repository.AddReview(review))
            {
                if (await DisplayAlert("Notify", "Entity added successfull", "Done", "Add More"))
                {
                    await Navigation.PopAsync(true);
                }

            }
        }
    }
}