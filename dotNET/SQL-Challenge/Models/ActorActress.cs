using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace SQL_Challenge_DIO.Models
{
    public class ActorActress
    {
        private Int32 id;
        private string firstName;
        private string lastName;
        private string gender;

        public Int32 Id 
        {
            get{return id;}
            set{id = value;}
        }

        public string FirstName
        {
            get{return firstName;}
            set{firstName = value;}
        }

        public string LastName
        {
            get{return lastName;}
            set{lastName = value;}
        }

        public string Gender
        {
            get{return gender;}
            set{gender = value;}
        }

        public ActorActress([Optional]Int32 id, [Optional]string firstName, [Optional]string lastName, [Optional]string gender)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Gender = gender;
        }
    }
}