using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using mvc_course_work.Models.Entities;
namespace mvc_course_work.Models.ViewModel
{
    public class TakeAllInfo
    {
        public List<Driver> Drivers { get; set; }
        public List<Race> Races { get; set; }
        public List<Video> Videos { get; set; }
        public List<Team> Teams { get; set; }
    }
}