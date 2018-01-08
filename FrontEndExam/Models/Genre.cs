using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FrontEndExam.Models
{
    public enum Genres
    {
        Scifi, Adventure, Action, Horror, Comedy, Fantasy, Thriller, Drama,
    }

    public class Genre
    {
        public int ID { get; set; }
        public int MovieID { get; set; }
        public Genres? Genres { get; set; }

        public virtual Movie Movie { get; set; }
    }
}