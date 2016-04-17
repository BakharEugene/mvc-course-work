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
    public class RaceController : Controller
    {
        UnitOfWork unitOfWork;
        public RaceController()
        {
            unitOfWork = new UnitOfWork();
        }

        public ActionResult Index(int Id)
        {
            Race race = unitOfWork.Races.GetById(Id);
            return View(race);
        }

        public ActionResult All()
        {
            return View();
        }
       
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
    }
}