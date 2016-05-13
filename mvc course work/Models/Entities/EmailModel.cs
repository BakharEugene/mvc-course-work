using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;
using System.ComponentModel.DataAnnotations;

using System.Net;
namespace mvc_course_work.Models.Entities
{
    public class EmailModel
    {

        [Required, Display(Name = "Your name")]
        public string FromName { get; set; }
        [Required, Display(Name = "Your email"), EmailAddress]
        public string FromEmail { get; set; }
        [Required]
        public string Message { get; set; }

        public void sendMessage()
        {
            mvc_course_work.Controllers.ContactsController ctrl = new Controllers.ContactsController();
            var res = ctrl.Contact(new EmailModel());
        }

    }
}