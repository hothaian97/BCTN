using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using WebSportOnline.Models;

namespace WebSportOnline.Controllers
{
    public class TinTucController : Controller
    {
        //
        // GET: /TinTuc/
        AnSportEntities db = new AnSportEntities();
        public ActionResult Index()
        {
            return View("TinTuc", db.TinTucs.OrderBy(n => n.IdTinTuc));
        }
        public ActionResult TinTuc(int? id)
        {
            return View(db.TinTucs.Where(n => n.IdTinTuc == id));
        }
        public ActionResult NoiDung(int? id)
        {
            return View(db.TinTucs.SingleOrDefault(n => n.IdTinTuc == id));
        }
    }
}