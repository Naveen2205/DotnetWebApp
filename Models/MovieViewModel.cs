using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvMovies.Models
{
    public class MovieViewModel
    {
        public string searchString { get; set; }
        public List<Movie> Movies { get; set; }
        public SelectList GenreList { get; set; }
        public string Genre { get; set; }
    }
}
