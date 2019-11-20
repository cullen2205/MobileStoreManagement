using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MobileStore.ViewService;

namespace MobileStore.Controllers
{
    public class ListProductController : Controller
    {
        private ViewServiceClient db = new ViewServiceClient();
        // GET: ListProduct
        public ActionResult Index()
        {
            List<product> product = db.Get_product(0).ToList();
            return View(product);
        }
        [HttpPost]
        public ActionResult Search(string Desc)
        {
            List<product> lproducts = db.Get_product(0).Where(m => m.name.Contains(Desc)).ToList();
            var result = lproducts.ToList();
            return View(result);
        }
        ~ListProductController()
        {
            db.Close();
        }
    }
}