using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment3.Models
{
    //This is where the values are stored when we add a movie.
    public class TempStorage
    {
        private static List<MovieResponse> movies = new List<MovieResponse>();

        public static IEnumerable<MovieResponse> Movies => movies;

        public static void AddMovie(MovieResponse movie)
        {
            movies.Add(movie);
        }
    }
}
