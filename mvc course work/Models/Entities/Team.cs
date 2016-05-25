using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvc_course_work.Models.Entities
{
    public class Team:BaseEntityWithId
    {

        public virtual ICollection<Driver> Drivers { get; set; }
        public string Name { get; set; }
        public int PodiumFinishes { get; set; }
        public int ChampinionshipTitles { get; set; }
        public virtual ICollection<Race> Races { get; set; }
        public string Photo { get; set; }

    }
}