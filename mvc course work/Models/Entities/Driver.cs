using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace mvc_course_work.Models.Entities
{
    public class Driver : BaseEntityWithId
    {
        public string name { get; set; }
        public string familyName { get; set; }
        public string country { get; set; }
        public string placeOfBirth { get; set; }
        public int points { get; set; }
        public int number {get;set;}
        public string car { get; set; }
        public int? IdTeam { get; set; }
        
        public virtual Team Team { get; set; }

        public string date { get; set; }
        public string picture { get; set; }
        public string shortBiography { get; set; }
        public string longBiography { get; set; }
        public virtual ICollection<Race> races { get; set; }
        public virtual ICollection<Podium> podiums { get; set; }
    }
}