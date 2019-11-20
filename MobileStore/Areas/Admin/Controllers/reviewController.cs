using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MobileStore.Areas.Admin.Controllers
{
    public class ReviewController : Controller
    {
        // GET: review
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult listReviews()
        {
            return View();
        }
    }
}