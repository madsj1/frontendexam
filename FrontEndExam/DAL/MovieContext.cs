using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FrontEndExam.Models;
using System.Data.Entity;

namespace FrontEndExam.DAL
{
    public class MovieContext : DbContext
    {
        public MovieContext() : base("MovieContext")
        {
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Genre> Genres { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}