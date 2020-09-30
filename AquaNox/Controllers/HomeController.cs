using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AquaNox.Controllers
{

    [BasicAuthenticationAttribute("ma7", "1234567", BasicRealm = "your-realm")]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult BeachSafety()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Quiz()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        public ActionResult Gear()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult BeachDay()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Map()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult BeachPlay()
        {
            ViewBag.Message = "Your contact page.";

            return View();

        }
    }

    public class BasicAuthenticationAttribute : ActionFilterAttribute
        {
            public string BasicRealm { get; set; }
            protected string Username { get; set; }
            protected string Password { get; set; }

            public BasicAuthenticationAttribute(string username, string password)
            {
                this.Username = username;
                this.Password = password;
            }

            public override void OnActionExecuting(ActionExecutingContext filterContext)
            {
                var req = filterContext.HttpContext.Request;
                var auth = req.Headers["Authorization"];
                if (!String.IsNullOrEmpty(auth))
                {
                    var cred = System.Text.ASCIIEncoding.ASCII.GetString(Convert.FromBase64String(auth.Substring(6))).Split(':');
                    var user = new { Name = cred[0], Pass = cred[1] };
                    if (user.Name == Username && user.Pass == Password) return;
                }
                var res = filterContext.HttpContext.Response;
                res.StatusCode = 401;
                res.AddHeader("WWW-Authenticate", String.Format("Basic realm=\"{0}\"", BasicRealm ?? "Ryadel"));
                res.End();
            }


        }
   
}