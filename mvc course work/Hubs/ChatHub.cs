using System;
using System.Web;
using Microsoft.AspNet.SignalR;
using mvc_course_work;
namespace mvc_course_work.Hubs
{
    public class ChatHub : Hub
    {
        public void Send(string name, string message)
        {
            // Call the broadcastMessage method to update clients.
            Clients.All.broadcastMessage(name, message, DateTime.Now.ToString("[hh:mm:ss]"));
        }
    }
}