using System;
using System.Collections.Generic;
using System.Text;

namespace MyCollection.Model
{
    public class AlbumModel
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public string Location { get; set; }
        public string Thumb { get; set; }
        public string Genre { get; set; }

        public AlbumModel(string title,string artist, string location,string thumb,string genre)
        {
            Title = title;  
            Artist = artist;
            Location = location;
            Thumb = thumb;
            Genre = genre;
        }
    }

    
}
