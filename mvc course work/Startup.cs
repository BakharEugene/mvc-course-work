using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mvc_course_work.Startup))]
namespace mvc_course_work
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            app.MapSignalR();
        }
    }
}
