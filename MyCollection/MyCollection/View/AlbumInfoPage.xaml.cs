using MyCollection.Model;
using MyCollection.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyCollection.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AlbumInfoPage : ContentPage
    {
        AlbumViewModel avm;
        AlbumModel alb;
        bool isNew;

        public AlbumInfoPage(AlbumViewModel _avm, bool _isNew)
        {
            InitializeComponent();

            avm = _avm;
            isNew = _isNew;
            alb = new AlbumModel("", "", "", "", "");
            if(isNew)
            {

            }
            else
            {

                alb.Title = avm.SelectedAlbum.Title;
                alb.Artist = avm.SelectedAlbum.Artist;
                alb.Location = avm.SelectedAlbum.Location;
                alb.Thumb = avm.SelectedAlbum.Genre;

            }
            BindingContext = alb;
        }

        private async void btnCancel_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        private async void btnOk_Clicked(object sender, EventArgs e)
        {
            if (isNew)
            {
                avm.InsertAlbum(alb);

            }
            else
            {
                avm.UpdatAlbum(alb);
            }
            
            await Navigation.PopModalAsync();
        }
    }
}