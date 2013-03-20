using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MvcProject2.Models
{
    public class MovieInitializer : DropCreateDatabaseIfModelChanges<MovieDBContext>
    {
        protected override void Seed(MovieDBContext context)
        {
            var movies = new List<Movie> {
                new Movie { Title = "Suicide Club",   
                             ReleaseDate=DateTime.Parse("2001-10-29"),   
                             Genre="Romantic Comedy",  
                             Rating="R",  
                             DateViewed=DateTime.Parse("2013-3-20")}, 
                             };

            movies.ForEach(d => context.Movies.Add(d));
        }
    }
}