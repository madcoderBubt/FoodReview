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

        public RestaurantReviewPage(string Name)
        {
            InitializeComponent();
            txtRestaurant.Text = Name;
        }
    }
}