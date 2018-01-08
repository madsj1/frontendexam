using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FrontEndExam.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Poster { get; set; }
        public string Description { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public Decimal Price { get; set; }

        public virtual ICollection<Genre> Genres { get; set; }
    }
}