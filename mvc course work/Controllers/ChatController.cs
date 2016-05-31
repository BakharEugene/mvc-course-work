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
using System.Text;

namespace mvc_course_work.Controllers
{
    public class ChatController:Controller
    {
        [Authorize(Roles = "Admin, User")]
        public ActionResult Chat(mvc_course_work.Models.ViewModel.ChatModel model)
        {
           
            return View(model);
        }

    }
}

