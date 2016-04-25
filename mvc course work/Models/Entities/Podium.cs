using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvc_course_work.Models.Entities
{
    public class Podium : BaseEntityWithId
    {
        public virtual Race race { get; set; }
        public virtual ICollection<Driver> drivers { get; set; }
        public int place { get; set; }
        public int year { get; set; }
    }
}