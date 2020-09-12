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
    public partial class GalleryPage : ContentPage
    {
        //public List<ResturentModel> Resturents { get; set; }
        public GalleryPage()
        {
            InitializeComponent();
            var ListItem = new List<ResturentModel>()
            {
                new ResturentModel()
                {
                    Name = "Pizza Hut 3",
                    Address = "94 Dhaka",
                    Phone = "01111666",
                    Closed = DateTime.Now,
                    Opens = DateTime.Today
                },
                new ResturentModel()
                {
                    Name = "Pizza Hut 50",
                    Address = "94 Dhaka",
                    Phone = "01111666",
                    Closed = DateTime.Now,
                    Opens = DateTime.Today
                },
                new ResturentModel()
                {
                    Name = "Pizza Hut 555",
                    Address = "94 Dhaka",
                    Phone = "01111666",
                    Closed = DateTime.Now,
                    Opens = DateTime.Today
                }
            };
            ResturentCollection.ItemsSource = ListItem;
            BindingContext = this;
        }
    }
}