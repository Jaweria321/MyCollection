using MyCollection.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;

namespace MyCollection.ViewModel
{
    class AlbumViewModel : INotifyPropertyChanged
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

        public async  Task<bool> GetAlbums()
        {
            if ( AlbumList == null)
            {
                AlbumList = new List<AlbumModel>();
                AlbumList.Add(new AlbumModel("Volunteers", "Jefferson Airplane", "Box 1", "", "Rock"));
                AlbumList.Add(new AlbumModel("Escape", "Journey", "Box 2", "", "Rock"));
                AlbumList.Add(new AlbumModel("Exit", "Tangerine Dream", "Box 1", "", "Electronic"));
                AlbumList.Add(new AlbumModel("Rumors", "Fleetwood Mac", "Box 2", "", "Rock"));
                AlbumList.Add(new AlbumModel("LA Woman", "The Doors", "Box 1", "", "Rock"));
                AlbumList.Add(new AlbumModel("Moving Pictures", "Rush", "Box 2", "", "Rock"));

            }
            return true;
        }
        
        
        
        
        
        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string prop)
        {
            if (PropertyChanged != null) { PropertyChanged(this, new PropertyChangedEventArgs(prop)); }
        }
    }
}
