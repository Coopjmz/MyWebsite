using System.Linq;
using System.Web.Mvc;

namespace MyWebsite.Controllers
{
    public class GalleryController : Controller
    {
        // Directory.GetFiles(string path) doesn't work with relative paths because of IIS :(
        const string relativePath = "Content/Images";
        static readonly string[] imageFileNames = {
            "crossfire.jpg", "eva.jpg", "gameloft.jpg",
            "reaper.jpg", "shotgun.jpg", "team.jpg"
        };

        public ActionResult Index()
        {
            ViewBag.Images = imageFileNames.Select(imageFileName => $"/{relativePath}/{imageFileName}");

            return View();
        }
    }
}