﻿using System;
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
        
        //automapper
        public virtual ICollection<Team> Team { get; set; }
        public virtual ICollection<Driver> Drivers { get; set; }
    }
}