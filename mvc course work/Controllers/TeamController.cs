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
    public class TeamController : Controller
    {
        UnitOfWork unitOfWork;
        public TeamController()
        {
            unitOfWork = new UnitOfWork();
        }

        public ActionResult Index(int Id)
        {
            Team  team = unitOfWork.Teams.GetById(Id);
            return View(team);
        }

        public ActionResult All()
        {
            var model = new mvc_course_work.Models.ViewModel.TakeAllTeams()
            {
                Teams = unitOfWork.Teams.GetAll().ToList()
            };
            return View(model);
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }
    }
}