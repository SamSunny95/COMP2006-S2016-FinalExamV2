using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using COMP2006_S2016_FinalExamV2.Models;

namespace COMP2006_S2016_FinalExamV2.Controllers
{
    public class ArtistController : Controller
    {
        MVCMusicStoreContext storeDB = new MVCMusicStoreContext();

        // GET: Artist
        public ActionResult Index()
        {
            // List of all artists in the database
            List < Artist > artists = storeDB.Artists.ToList();
            // returns the artists list to the Index view
            return View(artists);
        }
    }
}