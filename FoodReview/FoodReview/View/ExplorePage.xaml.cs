﻿using FoodReview.Data;
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
    public partial class ExplorePage : ContentPage
    {
        //List<Restaurant> Restaurants;
        RestaurantRepository restaurantRepo;

        public ExplorePage()
        {
            InitializeComponent();

            BindingContext = this; 
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            RefreshGrid();
        }

        private void RefreshGrid()
        {
            try
            {
                restaurantRepo = new RestaurantRepository();
                //var temp = restaurantRepo.GetRestaurentList();

                //Handling Task Method
                var task = Task.Run(async () => await restaurantRepo.GetRestaurentList());
                RestaurantView.ItemsSource = task.Result;
            }
            catch (Exception ex)
            {
                DisplayAlert("Error", ex.Message, "Ok");
            }
        }

        private void RestaurantView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var item = e.CurrentSelection.FirstOrDefault() as Restaurant;
            String s = item.Name;
            Navigation.PushAsync(new RestaurantPage(item));
        }

        private void btnReview_Clicked(object sender, EventArgs e)
        {
            var btn = sender as Button;
            var item = btn.BindingContext as Restaurant;

            Navigation.PushAsync(new RestaurantReviewPage(item.ID));
        }
    }
}

//Back up test values
//Restaurants = new List<Restaurant>()
//{
//    new Restaurant()
//    {
//        ID = 1,
//        Name = "Tasty Treat",
//        Address = "Road 7, Rupnagar, Mirpur, Dhaka",
//        OpenAt = DateTime.Parse("7:00 PM").TimeOfDay,
//        CloseAt = DateTime.Parse("7:00 PM").TimeOfDay,
//        Delivery = true, Dining = true, TakeAway = true,
//        Phone = "01632740075",
//        Website = "shbsovon.info"
//    },
//    new Restaurant()
//    {
//        ID = 2,
//        Name = "Tasty Treat 2",
//        Address = "Road 7, Rupnagar, Mirpur, Dhaka",
//        OpenAt = DateTime.Parse("7:00 PM").TimeOfDay,
//        CloseAt = DateTime.Parse("7:00 PM").TimeOfDay,
//        Delivery = true, Dining = true, TakeAway = true,
//        Phone = "01632740075",
//        Website = "shbsovon.info"
//    },
//    new Restaurant()
//    {
//        ID = 3,
//        Name = "Tasty Treat 3",
//        Address = "Road 7, Rupnagar, Mirpur, Dhaka",
//        OpenAt = DateTime.Parse("7:00 PM").TimeOfDay,
//        CloseAt = DateTime.Parse("7:00 PM").TimeOfDay,
//        Delivery = true, Dining = true, TakeAway = true,
//        Phone = "01632740075",
//        Website = "shbsovon.info"
//    },
//    new Restaurant()
//    {
//        ID = 4,
//        Name = "Tasty Treat 4",
//        Address = "Road 7, Rupnagar, Mirpur, Dhaka",
//        OpenAt = DateTime.Parse("7:00 PM").TimeOfDay,
//        CloseAt = DateTime.Parse("7:00 PM").TimeOfDay,
//        Delivery = true, Dining = true, TakeAway = true,
//        Phone = "01632740075",
//        Website = "shbsovon.info"
//    },
//    new Restaurant()
//    {
//        ID = 5,
//        Name = "Tasty Treat 5",
//        Address = "Road 7, Rupnagar, Mirpur, Dhaka",
//        OpenAt = DateTime.Parse("7:00 PM").TimeOfDay,
//        CloseAt = DateTime.Parse("7:00 PM").TimeOfDay,
//        Delivery = true, Dining = true, TakeAway = true,
//        Phone = "01632740075",
//        Website = "shbsovon.info"
//    },
//    new Restaurant()
//    {
//        ID = 6,
//        Name = "Tasty Treat 6",
//        Address = "Road 7, Rupnagar, Mirpur, Dhaka",
//        OpenAt = DateTime.Parse("7:00 PM").TimeOfDay,
//        CloseAt = DateTime.Parse("7:00 PM").TimeOfDay,
//        Delivery = true, Dining = true, TakeAway = true,
//        Phone = "01632740075",
//        Website = "shbsovon.info"
//    },
//};