﻿using System;
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
using mvc_course_work.Models;
namespace mvc_course_work.Controllers
{
    public class ContactsController : Controller
    {
        public ContactsController()
        {

        }
        public ActionResult Index()
        {
            var model = new mvc_course_work.Models.ContactViewModel();
            return View(model);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Contact()
        {
            var model =new  mvc_course_work.Models.Entities.Email();
            if (ModelState.IsValid)
            {
                var body = "<p>Email From: {0} ({1})</p><p>Message:</p><p>{2}</p>";
                var message = new MailMessage();
                message.To.Add(new MailAddress("eugenebakhar@gmail.com"));  // replace with valid value 
                message.From = new MailAddress("zenia31@mail.ru");  // replace with valid value
                message.Subject = "Your email subject";
                message.Body = string.Format(body, model.FromName, model.FromEmail, model.Message);
                message.IsBodyHtml = true;

                using (var smtp = new SmtpClient())
                {
                    var credential = new NetworkCredential
                    {
                        UserName = "user@outlook.com",  // replace with valid value
                        Password = "password"  // replace with valid value
                    };
                    smtp.Credentials = credential;
                    smtp.Host = "smtp-mail.outlook.com";
                    smtp.Port = 587;
                    smtp.EnableSsl = true;
                    await smtp.SendMailAsync(message);
                    return RedirectToAction("Sent");
                }
            }
            return View(model);
        }

    }
}