using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MobileStore.ViewService;

namespace MobileStore.Controllers
{
    public class HomeController : Controller
    {
        private ViewServiceClient db = new ViewServiceClient();
        public ActionResult Index()
        {
            List<product> lproducts = db.Get_product(0).ToList();
            return View(lproducts);
        }
        ~HomeController()
        {
            db.Close();
        }
    }
}