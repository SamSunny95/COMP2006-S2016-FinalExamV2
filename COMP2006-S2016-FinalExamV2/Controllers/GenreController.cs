using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using COMP2006_S2016_FinalExamV2.Models;

namespace COMP2006_S2016_FinalExamV2.Controllers
{
    public class GenreController : Controller
    {

        MVCMusicStoreContext storeDB = new MVCMusicStoreContext();
        // GET: Genre
        public ActionResult Index()
        {
            // List of all genres in the database
            List<Genre> genres = storeDB.Genres.ToList();
            // returns the genres list to the Index view
            return View(genres);
        }
    }
}