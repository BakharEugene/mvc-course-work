using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvc_course_work.Models.Entities
{
    public class Race:BaseEntityWithId
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string photo { get; set; }
        public string country { get; set; }
        public int day { get; set; }
        public int year { get; set; }
        public int month { get; set; }
       public  bool finished { get; set; }
        public string mapPhoto { get; set; }
        public int firstGrandPrix { get; set; }
        public int numberOfLaps { get; set; }
        public double circuitLength { get; set; }
        public double raceDistance { get; set; }
        public string lapRecord { get; set; }
        public virtual ICollection<Team> Team { get; set; }
        public virtual ICollection<Driver> Drivers { get; set; }
        public virtual ICollection<Podium> podiums { get; set; }

        public string getDate()
        {
            DateTime tm = DateTime.Now;
            tm = tm.AddMonths(month-tm.Month);
            tm = tm.AddDays(day-tm.Day);
            return tm.ToString("r");
        }
    }
}