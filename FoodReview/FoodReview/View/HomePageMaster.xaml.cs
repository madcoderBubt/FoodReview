using FoodReview.Data;
using FoodReview.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FoodReview.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePageMaster : ContentPage
    {
        public ListView ListView;

        public HomePageMaster()
        {
            InitializeComponent();

            BindingContext = new HomePageMasterViewModel();
            ListView = MenuItemsListView;

            
        }

        class HomePageMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MasterMenuItem> MenuItems { get; set; }

            public HomePageMasterViewModel()
            {
                //Listing Menu Items
                MenuItems = new ObservableCollection<MasterMenuItem>(new[]
                {
                    new MasterMenuItem { 
                        IconSource = "logo.png",
                        DisplayName = "Detail Page",
                        TargetType = typeof(DetailsPage)
                    },
                    new MasterMenuItem {
                        IconSource = "twitter.png",
                        DisplayName = "Gallery Page",
                        TargetType = typeof(GalleryPage)
                    },
                    new MasterMenuItem {
                        IconSource = "logo.png",
                        DisplayName = "Detail Page 2",
                        TargetType = typeof(HomePageDetail)
                    },
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }

        private void btnLogOut_Clicked(object sender, EventArgs e)
        {
            var user = new UserRepository();
            user.Logout();

            App.Current.MainPage = new NavigationPage(new MainPage());
        }
    }
}