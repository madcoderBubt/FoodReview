using FoodReview.View;
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
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnSign_Clicked(object sender, EventArgs e)
        {
            try
            {
                if (txtUserName.Text == "madcoder" && txtPassword.Text == "1234")
                {
                    //await App.Current.MainPage.Navigation.PushAsync(new HomePage());
                    App.Current.MainPage = new NavigationPage(new HomePage());
                }
            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }
}
