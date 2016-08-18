using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using COMP2006_S2016_FinalExamV2.Models;

namespace COMP2006_S2016_FinalExamV2.Controllers
{
    public class AlbumController : Controller
    {
        MVCMusicStoreContext storeDB = new MVCMusicStoreContext();
        // GET: Album
        public ActionResult Index()
        {
            // List of all albums in the database
            List<Album> albums = storeDB.Albums.ToList();
            // Returns the albums list to the Index view
            return View(albums);
        }
    }
}