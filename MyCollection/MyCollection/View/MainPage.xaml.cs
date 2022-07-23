using MyCollection.Model;
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

        private void AlbumListview_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                avm.SelectedAlbum = (AlbumModel)e.SelectedItem;
                DisplayAlert(avm.SelectedAlbum.Title, avm.SelectedAlbum.Artist, "ok");
            }
        }

        private async void btnName_Clicked(object sender, EventArgs e)
        {


            string result = await DisplayPromptAsync("Question 1", "What's your name?");
            if(result != null)
            {
                avm.CollectionName = result;
            }

        }
    }
}
