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
            await Navigation.PopAsync(true);
        }
    }
}