using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FoodReview.View.SharedView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RestaurentView : ContentView
    {
        public RestaurentView()
        {
            InitializeComponent();
        }
    }
}