using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseData { get; set; }
        public DateTime DateAdded { get; set; }
        public int NumbersInStock { get; set; }
        public GenreDto Genre { get; set; }
        public byte GenreId { get; set; }
    }
}