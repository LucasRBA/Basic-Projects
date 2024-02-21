using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace SQL_Challenge_DIO.Models
{
    public class Movies
    {
        private int id{get;set;}
        private string name{get;set;}
        private Int32 year{get;set;}
        private Int32 movieLength{get;set;}

        public Int32 Id 
        {
            get {return id;}
            set {id = value;}
        }

        public string Name
        {
            get {return name;}
            set {name = value;}
        }

        public Int32 Year
        {
            get {return year;}
            set {year = value;}
        }

        public Int32 MovieLength
        {
            get {return movieLength;}
            set {movieLength = value;}
        }

        public Movies([Optional]Int32 id, [Optional]string name, [Optional]Int32 year, [Optional]Int32 movieLength) 
        {
            this.Id = id;
            this.Name = name;
            this.Year = year;
            this.MovieLength = movieLength;
        }

    }
}