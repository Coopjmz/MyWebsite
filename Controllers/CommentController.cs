using System;
using System.Linq;
using System.Web.Mvc;
using MyWebsite.Models;

namespace MyWebsite.Controllers
{
    public class CommentController : Controller
    {
        private readonly CommentContext _db = new CommentContext();

        public ActionResult Index()
        {
            var moreRecentEntries = (from entry in _db.Entries
                                     orderby entry.Date descending
                                     select entry).Take(20);

            ViewBag.Entries = moreRecentEntries.ToList();

            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(CommentEntry entry)
        {
            entry.Date = DateTime.Now;

            _db.Entries.Add(entry);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}