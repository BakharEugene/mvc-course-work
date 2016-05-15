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
    public class HomeController : Controller
    {
        UnitOfWork unitOfWork;
        public HomeController()
        {
            unitOfWork = new UnitOfWork();
        }


        public ActionResult Team(int? id=0)
        {
            return View();
        }
        public ActionResult Index()
        {
            var model = new TakeAllInfo()
            {
                Drivers = unitOfWork.Drivers.GetAll().ToList(),
                Teams = unitOfWork.Teams.GetAll().ToList(),
                Races = unitOfWork.Races.GetAll().ToList()
            };
            return View(model);
        }


        public ActionResult About()
        {
            var model = new TakeAllInfo()
            {
               Videos=unitOfWork.Videos.GetAll().ToList()
            };
            return View(model);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

    }
}