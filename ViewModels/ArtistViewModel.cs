using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MusicStore.Models;

namespace MusicStore.ViewModels
{
    public class ArtistViewModel
    {
        public List<Album> Album {  get; set; } = new List<Album>();
        public List<Artist> Artist { get; set; } = new List<Artist>();
    }
}