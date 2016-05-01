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
    public class DriverController : Controller
    {
        UnitOfWork unitOfWork;
        public DriverController()
        {
            unitOfWork = new UnitOfWork();
        }

        public ActionResult Index(int Id)
        {
            Driver driver = unitOfWork.Drivers.GetById(Id);
            return View(driver);
        }

        public ActionResult All()
        {
            var model = new TakeAllDrivers
            {
                Drivers = unitOfWork.Drivers.GetAll().ToList()
            };
            return View(model);
        }
    }
}