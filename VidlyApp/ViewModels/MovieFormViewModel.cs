using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VidlyApp.Models;

namespace VidlyApp.ViewModels
{
    public class MovieFormViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }

        public Movie Movie { get; set; }
        
        public string Title
        {
            get
            {
                return (Movie != null) ? "Edit Movie" : "New Movie";
            }
        }
    }
}