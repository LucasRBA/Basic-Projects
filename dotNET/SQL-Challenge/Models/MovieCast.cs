using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace SQL_Challenge_DIO.Models
{
    public class MovieCast
    {
        private  Int32 id;
        private Int32 actorId;
        private Int32 movieId;
        private string role;

        public Int32 Id
        {
            get{return id;}
            set{id = value;}
        }

        public Int32 ActorId
        {
            get{return actorId;}
            set{actorId = value;}
        }

        public Int32 MovieId
        {
            get{return movieId;}
            set{movieId = value;}
        }

        public string Role 
        {
            get{return role;}
            set{role = value;}
        }

        public MovieCast([Optional]Int32 id, [Optional]Int32 actorId, [Optional]Int32 movieId, [Optional]string role)
        {
            this.id= id;
            this.actorId= actorId;
            this.movieId= movieId;
            this.role = role;
        }
    }
}