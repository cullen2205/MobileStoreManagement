using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dapper;
using MobileStore.Models.Helper;
using System.Data;
using MobileStore.ViewService;

namespace MobileStore.Controllers
{
    public class DetailController : Controller
    {
        private ViewServiceClient db = new ViewServiceClient();
        // GET: Detail
        public ActionResult Index(int id)
        {
            return View(db.Get_product(id).FirstOrDefault());
        }

        ~DetailController()
        {
            db.Close();
        }
    }
}