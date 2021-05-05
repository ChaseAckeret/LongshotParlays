using LongshotParays.Service;
using LongshotParlays.Model;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LongshotParlays.Web.Controllers
{
    public class NFLPlayerStats_RushingController : Controller
    {
        [Authorize]
        // GET: NFLPlayerStatsRushing
        public ActionResult Index()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new NFLPlayerStats_RushingService(userId);
            var model = service.GetRushingStats();
            return View(model);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(NFLPlayerStats_RushingCreate model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var service = CreateRushingService();

            if (service.CreateRushingStats(model))
            {
                TempData["SaveResult"] = "Rushing stats added";
                return RedirectToAction("Index");
            };

            ModelState.AddModelError("", "Rushing stats could not be added.");
            return View(model);
        }

        public ActionResult Details(int id)
        {
            var service = CreateRushingService();
            var model = service.GetRushingStatsById(id);

            return View(model);

        }

        public ActionResult Edit(int id)
        {
            var service = CreateRushingService();
            var detail = service.GetRushingStatsById(id);
            var model =
                new NFLPlayerStats_RushingEdit
                {
                    PlayerId = detail.PlayerId,
                    Attempts = detail.Attempts,
                    Yards = detail.Yards,
                    Touchdowns = detail.Touchdowns
                };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, NFLPlayerStats_RushingEdit model)
        {
            if(!ModelState.IsValid)
            return View(model);

            if(model.PlayerId != id)
            {
                ModelState.AddModelError("", "Id Mismatch");
                return View(model);
            }

            var service = CreateRushingService();

            if (service.UpdateRushingStats(model))
            {
                TempData["SaveResult"] ="Rushing stats were updated.";
                return RedirectToAction("Index");
            }


            ModelState.AddModelError("", "Rushing stats could not be updated.");
            return View();
        }

        [ActionName("Delete")]
        public ActionResult Delete(int id)
        {
            var service = CreateRushingService();
            var model = service.GetRushingStatsById(id);

            return View(model);

        }

        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeletePost(int id)
        {
            var service = CreateRushingService();

            service.DeleteRushingStats(id);

            TempData["SaveResult"] = "Rushing stats were deleted.";

            return RedirectToAction("Index");
        }

        private NFLPlayerStats_RushingService CreateRushingService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new NFLPlayerStats_RushingService(userId);
            return service;
        }
    }
}