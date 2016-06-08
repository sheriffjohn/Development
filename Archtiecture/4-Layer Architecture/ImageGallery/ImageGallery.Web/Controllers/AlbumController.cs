using ImageGallery.Domain;
using ImageGallery.Services.Facade;
using System.Web.Mvc;

namespace ImageGallery.Web.Controllers
{
    public class AlbumController : Controller
    {

        private IServiceFacade _servicefacade;

        public AlbumController(IServiceFacade servicefacade)
        {
            _servicefacade = servicefacade;
        }

        public AlbumController()
        {

        }

        // GET: Album
        public ActionResult Index()
        {
            return View();
        }

        // GET: Album/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Album/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Album/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                User user = new User() { Id = 1, Name = "John" }; //Use Identity to get user
                Album album = new Album(user, collection.GetValue("Test").ToString());

                var status = _servicefacade.CreateAlbum(album);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Album/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Album/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Album/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Album/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
