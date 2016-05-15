using System;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.Net.Mail;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using mvc_course_work.Models.Entities;
namespace mvc_course_work.Controllers
{
    public class ContactsController : Controller
    {
        public ActionResult Index()
        {
            mvc_course_work.Models.Entities.EmailModel model = new EmailModel();
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Contact(EmailModel model)
        {
            return View(model);
        }
        public ActionResult Sent()
        {
            return View();
        }

    }
}