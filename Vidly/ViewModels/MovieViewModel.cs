using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class MovieViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }
        [Display(Name = "Genre")]
        public byte GenreId { get; set; }
        public int NumberInStock { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseData { get; set; }
    }
}