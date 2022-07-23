using MyCollection.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MyCollection
{
    public partial class MainPage : ContentPage
    {

        AlbumViewModel avm;
        public MainPage()
        {
            InitializeComponent();
            avm = new AlbumViewModel();// AlbumViewModel's object
            avm.CollectionName = "Jaweria's Collection"; // Assigning value AlbumViewModel's object
            // Binding AlbumViewModel with MainPage
            BindingContext = avm;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await avm.GetAlbums();
            //AlbumListview is ListView name 
            AlbumListview.ItemsSource = avm.AlbumList;
        }
    }
}
