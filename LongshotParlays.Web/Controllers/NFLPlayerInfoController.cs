using LongshotParlays.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LongshotParlays.Web.Controllers
{
    [Authorize]
    public class NFLPlayerInfoController : Controller
    {
        // GET: NFLPlayerInfo
        public ActionResult Index()
        {
            var model = new NFLPlayerInfoListItem[0];
            return View(model);
        }

        //GET
        public ActionResult Create()
        {
            return View();
        }
    }
}