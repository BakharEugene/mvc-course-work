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
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Contact(EmailModel model)
        {
            if (model == null)
            {
                return null;
            }
            if (model.FromEmail == null || model.FromName == null || model.Message == null)
            {
                return null;
            }
            try
            {

            if (ModelState.IsValid)
            {
                var body = "<p>Email From: {0} ({1})</p><p>Message:</p><p>{2}</p>";
                var message = new MailMessage();
                message.To.Add(new MailAddress("Formula1project.contact@gmail.com"));  // replace with valid value 
                message.From = new MailAddress("eugenebakhar@gmail.com");  // replace with valid value
                message.Subject = "Your email subject";
                message.Body = string.Format(body, model.FromName, model.FromEmail, model.Message);
                message.IsBodyHtml = true;

                using (var smtp = new SmtpClient())
                {
                    var credential = new NetworkCredential
                    {
                        UserName = "Formula1project.contact@gmail.com",  // replace with valid value
                        Password = "4)kobejan"  // replace with valid value
                    };
                    smtp.Credentials = credential;
                    smtp.Host = "smtp-mail.outlook.com";
                    smtp.Port = 587;
                    smtp.EnableSsl = true;
                    await smtp.SendMailAsync(message);
                    return RedirectToAction("Sent");
                }
            }
                
            } catch (Exception ex)
            {
                return null;
            }
            return View(model);
        }
        public ActionResult Sent()
        {
            return View();
        }
    }
}