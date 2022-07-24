using MyCollection.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;

namespace MyCollection.ViewModel
{
    public class AlbumViewModel : INotifyPropertyChanged
    {

        private string _CollectionName;
        public string CollectionName
        {
            get
            {
                return _CollectionName;
            }
            set
            { 
                _CollectionName = value;
                RaisePropertyChanged("CollectionName");
            }

        }

        // A list of custom type named AlbumModel
        public List<AlbumModel> AlbumList;
        public AlbumModel SelectedAlbum;

        public async Task<bool> GetAlbums()
        {
            if ( AlbumList == null)
            {
                AlbumList = new List<AlbumModel>();
                AlbumList.Add(new AlbumModel("Volunteers", "Jefferson Airplane", "Box 1", "album1.jpg", "Rock"));
                AlbumList.Add(new AlbumModel("Escape", "Journey", "Box 2", "album2.jpg", "Rock"));
                AlbumList.Add(new AlbumModel("Exit", "Tangerine Dream", "Box 1", "album3.jpg", "Electronic"));
                AlbumList.Add(new AlbumModel("Rumors", "Fleetwood Mac", "Box 2", "album4.jpg", "Rock"));
                AlbumList.Add(new AlbumModel("LA Woman", "The Doors", "Box 1", "album5.jpg", "Rock"));
                AlbumList.Add(new AlbumModel("Moving Pictures", "Rush", "Box 2", "album6.jpg", "Rock"));
                AlbumList.Add(new AlbumModel("The Doors", "The Doors", "Box 1", "album7.jpg", "Rock"));
                AlbumList.Add(new AlbumModel("Volunteers", "Jefferson Airplane", "Box 1", "album1.jpg", "Rock"));
                AlbumList.Add(new AlbumModel("Escape", "Journey", "Box 2", "album2.jpg", "Rock"));
                AlbumList.Add(new AlbumModel("Exit", "Tangerine Dream", "Box 1", "album3.jpg", "Electronic"));
            }
            return true;
        }
        
        
        public bool UpdatAlbum(AlbumModel alb)
        {
            SelectedAlbum.Title = alb.Title;
            SelectedAlbum.Artist = alb.Artist;
            SelectedAlbum.Location = alb.Location;
            SelectedAlbum.Thumb = alb.Thumb;
            SelectedAlbum.Genre = alb.Genre;

            return true;
        }

        public bool InsertAlbum(AlbumModel alb)
        {

            AlbumList.Add(alb);
            return true;
        }



        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string prop)
        {
            if (PropertyChanged != null) { PropertyChanged(this, new PropertyChangedEventArgs(prop)); }
        }
    }
}
