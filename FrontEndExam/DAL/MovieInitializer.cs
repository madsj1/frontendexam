using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FrontEndExam.Models;

namespace FrontEndExam.DAL
{
    public class MovieInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<MovieContext>
    {
        protected override void Seed(MovieContext context)
        {
            var movies = new List<Movie>
            {
            new Movie{Title="Star Wars: The Last Jedi",Poster="https://images-na.ssl-images-amazon.com/images/M/MV5BMjQ1MzcxNjg4N15BMl5BanBnXkFtZTgwNzgwMjY4MzI@._V1_SY1000_CR0,0,675,1000_AL_.jpg",Description="Rey develops her newly discovered abilities with the guidance of Luke Skywalker, who is unsettled by the strength of her powers. Meanwhile, the Resistance prepares for battle with the First Order.",ReleaseDate=DateTime.Parse("2017-12-15"),Price=99},
            new Movie{Title="Jumanji: Welcome to the Jungle",Poster="https://images-na.ssl-images-amazon.com/images/M/MV5BMTkyNDQ1MDc5OV5BMl5BanBnXkFtZTgwOTcyNzI2MzI@._V1_.jpg",Description="Four teenagers are sucked into a magical video game, and the only way they can escape is to work together to finish the game.",ReleaseDate=DateTime.Parse("2017-12-20"),Price=99},
            new Movie{Title="It",Poster="https://images-na.ssl-images-amazon.com/images/M/MV5BZDVkZmI0YzAtNzdjYi00ZjhhLWE1ODEtMWMzMWMzNDA0NmQ4XkEyXkFqcGdeQXVyNzYzODM3Mzg@._V1_SY1000_CR0,0,666,1000_AL_.jpg",Description="A group of bullied kids band together when a shapeshifting monster, taking the appearance of a clown, begins hunting children.",ReleaseDate=DateTime.Parse("2017-09-08"),Price=99},
            new Movie{Title="Die Hard",Poster="https://images-na.ssl-images-amazon.com/images/M/MV5BMzNmY2IwYzAtNDQ1NC00MmI4LThkOTgtZmVhYmExOTVhMWRkXkEyXkFqcGdeQXVyMTk5NDA3Nw@@._V1_.jpg",Description="John McClane, officer of the NYPD, tries to save his wife Holly Gennaro and several others that were taken hostage by German terrorist Hans Gruber during a Christmas party at the Nakatomi Plaza in Los Angeles.",ReleaseDate=DateTime.Parse("1988-07-20"),Price=20},
            new Movie{Title="Deadpool",Poster="https://images-na.ssl-images-amazon.com/images/M/MV5BMjQyODg5Njc4N15BMl5BanBnXkFtZTgwMzExMjE3NzE@._V1_UY268_CR1,0,182,268_AL_.jpg",Description="A fast-talking mercenary with a morbid sense of humor is subjected to a rogue experiment that leaves him with accelerated healing powers and a quest for revenge.",ReleaseDate=DateTime.Parse("2016-12-02"),Price=75},
            new Movie{Title="Harry Potter and the Sorcerer's Stone ",Poster="https://images-na.ssl-images-amazon.com/images/M/MV5BNjQ3NWNlNmQtMTE5ZS00MDdmLTlkZjUtZTBlM2UxMGFiMTU3XkEyXkFqcGdeQXVyNjUwNzk3NDc@._V1_UX182_CR0,0,182,268_AL_.jpg",Description="Rescued from the outrageous neglect of his aunt and uncle, a young boy with a great destiny proves his worth while attending Hogwarts School of Witchcraft and Wizardry.",ReleaseDate=DateTime.Parse("2001-11-16"),Price=15},
            new Movie{Title="The Godfather",Poster="https://images-na.ssl-images-amazon.com/images/M/MV5BY2Q2NzQ3ZDUtNWU5OC00Yjc0LThlYmEtNWM3NTFmM2JiY2VhXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_UY268_CR3,0,182,268_AL_.jpg",Description="The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son.",ReleaseDate=DateTime.Parse("1972-03-24"),Price=10},
            new Movie{Title="The Dark Knight",Poster="https://images-na.ssl-images-amazon.com/images/M/MV5BMTMxNTMwODM0NF5BMl5BanBnXkFtZTcwODAyMTk2Mw@@._V1_SY1000_CR0,0,675,1000_AL_.jpg",Description="When the menace known as the Joker emerges from his mysterious past, he wreaks havoc and chaos on the people of Gotham, the Dark Knight must accept one of the greatest psychological and physical tests of his ability to fight injustice.",ReleaseDate=DateTime.Parse("2008-07-18"),Price=25}
            };

            movies.ForEach(s => context.Movies.Add(s));
            context.SaveChanges();

            var genres = new List<Genre>
            {
            new Genre{MovieID=1,Genres=Genres.Action},
            new Genre{MovieID=1,Genres=Genres.Adventure},
            new Genre{MovieID=1,Genres=Genres.Fantasy},
            new Genre{MovieID=2,Genres=Genres.Action},
            new Genre{MovieID=2,Genres=Genres.Adventure},
            new Genre{MovieID=2,Genres=Genres.Comedy},
            new Genre{MovieID=3,Genres=Genres.Horror},
            new Genre{MovieID=4,Genres=Genres.Action},
            new Genre{MovieID=4,Genres=Genres.Thriller},
            new Genre{MovieID=5,Genres=Genres.Action},
            new Genre{MovieID=6,Genres=Genres.Fantasy},
            new Genre{MovieID=7,Genres=Genres.Drama},
            new Genre{MovieID=8,Genres=Genres.Action},
            new Genre{MovieID=8,Genres=Genres.Drama},
            };
            genres.ForEach(s => context.Genres.Add(s));
            context.SaveChanges();
        }
    }
}