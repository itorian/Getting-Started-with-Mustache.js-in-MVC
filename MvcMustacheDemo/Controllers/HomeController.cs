using MvcMustacheDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMustacheDemo.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public JsonResult MyFriends()
        {
            List<Friend> friends = new List<Friend>();
            friends.Add(new Friend { Name = "Deepak", Address = "Bokaro", Mobile = "9966453241" });
            friends.Add(new Friend { Name = "Rohit", Address = "Dhanbad", Mobile = "5454544533" });
            friends.Add(new Friend { Name = "Ram", Address = "Dumka", Mobile = "4456576589" });
            friends.Add(new Friend { Name = "Shyam", Address = "Ranchi", Mobile = "9876543456" });
            friends.Add(new Friend { Name = "Mohan", Address = "Giridih", Mobile = "9876567439" });

            return Json(friends, JsonRequestBehavior.AllowGet);
        }

    }
}
