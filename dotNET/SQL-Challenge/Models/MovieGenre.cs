using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace SQL_Challenge_DIO.Models
{
    public class MovieGenre
    {
        private Int32 id;
        private Int32 genreId;
        private Int32 movieId;

        public Int32 Id 
        {
            get{return id;}
            set{id = value;}
        }

        public Int32 GenreId 
        {
            get{return genreId;}
            set{genreId = value;}
        }

        public Int32 MovieId
        {
            get{return movieId;}
            set{movieId = value;}
        }


        public MovieGenre([Optional]Int32 id, [Optional]Int32 genreId, [Optional]Int32 movieId)
        {
            this.id = id;
            this.genreId = genreId;
            this.movieId = movieId;
        }
    }
}