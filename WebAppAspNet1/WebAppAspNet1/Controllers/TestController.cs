using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppAspNet1.Controllers
{
    public class TestController : Controller
    {
        public ActionResult Index()
        {
            string message = "Ok";

            return Json(message);
        }

    }
}