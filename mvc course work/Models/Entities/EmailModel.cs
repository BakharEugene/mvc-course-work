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
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }

        public void setName(String x)
        {
            FirstName = x;
        }

        private void SendMail(String smtpServer, string from, string password, string mailto, string caption, string message)
        {
            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(from);
                mail.To.Add(new MailAddress(mailto));
                mail.Subject = caption;
                mail.Body = message;
                SmtpClient client = new SmtpClient();
                client.Host = smtpServer;
                client.Port = 587;
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential(from, password);
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.Send(mail);
                mail.Dispose();
            }
            catch (Exception e)
            {
                throw new Exception("Mail.Send: " + e.Message);
            }
        }

        public void sendMessage()
        {
            String UserName = "Formula1project.contact@gmail.com";
            String Password = "4)kobejan";

            //String Message = String.Format(
            //    "{0}\nFrom {1} {2}\nPhone: {3}\nAddres: {4}\nEmail\nEmail{5}", 
            //    Description, 
            //    FirstName, 
            //    LastName, 
            //    Phone,
            //    Address, 
            //    Email);

            String Message = "Test Message";

            try
            {
                SendMail(
                              "smtp.gmail.com",
                              UserName,
                              Password,
                              UserName,
                              "noreply",
                              Message);
            }
            catch (Exception ex)
            {
              
            }
        }
    }
}