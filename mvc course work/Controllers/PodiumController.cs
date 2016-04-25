using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvc_course_work.Models.Entities;
using mvc_course_work.Models.ViewModel;
using mvc_course_work.Models.DAL;
namespace mvc_course_work.Controllers
{
    public class PodiumController : Controller
    {
        public ActionResult Index(int Id)
        {
            return View();
        }

        public ActionResult All()
        {
            return View();
        }
    }
}