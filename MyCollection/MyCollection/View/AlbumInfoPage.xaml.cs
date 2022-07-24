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

        public AlbumInfoPage(AlbumViewModel _avm)
        {
            InitializeComponent();

            avm = _avm;
            alb = avm.SelectedAlbum;

            BindingContext = alb;
        }

        private async void btnCancel_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        private async void btnOk_Clicked(object sender, EventArgs e)
        {
            avm.UpdatAlbum(alb);
            await Navigation.PopModalAsync();
        }
    }
}