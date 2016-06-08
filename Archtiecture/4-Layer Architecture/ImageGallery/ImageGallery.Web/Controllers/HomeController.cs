using System.Web.Mvc;

namespace ImageGallery.Web.Controllers
{
    //[Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.TheMessage = "Bepp";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ViewResult Album()
        {
            ViewBag.Message = "Album";

            return View();
        }

        //[HttpPost]
        //public ActionResult CreateAlbum(AlbumViewModel viewmodel)
        //{
        //    var albumdto = Mapper.Map<AlbumDto>(viewmodel);

        //    var newalbum = new Album(albumdto);

        //    return RedirectToAction("Index");
        //}

        [HttpPost]
        public ActionResult Contact(string message)
        {
            ViewBag.TheMessage = "Hepp";
            return PartialView("_Hepp");
        }
    }
}