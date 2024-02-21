using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace SQL_Challenge_DIO.Models
{
    public class GenresName
    {
        private Int32 id;
        private string movieGenre;

        public Int32 Id
        {
            get {return id;}
            set {id = value;}
        }

        public string MovieGenre
        {
            get {return movieGenre;}
            set {movieGenre = value;}
        }

        public GenresName([Optional]Int32 id, [Optional]string movieGenre)
        {
            this.id = id;
            this.movieGenre = movieGenre;
        }
    }
}