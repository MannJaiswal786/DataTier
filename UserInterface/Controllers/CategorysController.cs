using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UserInterface.Controllers
{
   // [Authorize]
    public class CategorysController : Controller
    {
        private CategoryBs objBs = new CategoryBs();
        // GET: Categorys
        public ActionResult Index()
        {
            //ViewBag.CategoryList = objBs.GetAll();

            var list = objBs.GetAll();
            return View(list);
        }
    }
}