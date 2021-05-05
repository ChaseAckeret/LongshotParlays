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
    [Authorize]
    public class NFLPlayerStats_PassingController : Controller
    {
        // GET: NFLPlayerStatsPassing
        public ActionResult Index()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new NFLPlayerStats_PassingService(userId);
            var model = service.GetPlayerPassingStats();
            return View(model);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(NFLPlayerStats_PassingCreate model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var service = CreatePassingStatsService();

            if (service.CreatePassingStats(model))
            {
                TempData["SaveResult"] = "Passing Stat was created.";
                return RedirectToAction("Index");
            };

            ModelState.AddModelError("", "Passing stat could not be created.");
            return View(model);
        }

        public ActionResult Details(int id)
        {
            var service = CreatePassingStatsService();
            var model = service.GetPlayerPassingStatsById(id);

            return View(model);
        }

        public ActionResult Edit(int id)
        {
            var service = CreatePassingStatsService();
            var detail = service.GetPlayerPassingStatsById(id);
            var model =
                new NFLPlayerStats_PassingEdit
                {
                    PlayerId = detail.PlayerId,
                    Player = detail.Player,
                    Completions = detail.Completions,
                    Attempts = detail.Attempts,
                    Yards = detail.Yards
                };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, NFLPlayerStats_PassingEdit model)
        {
            if(!ModelState.IsValid)
            return View(model);

            if(model.PlayerId != id)
            {
                ModelState.AddModelError("", "Player ID mismatch");
                return View(model);
            }

            var service = CreatePassingStatsService();

            if(service.UpdatePassingStats(model))
            {
                TempData["SaveResult"] = "Passing Stats updated";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Passing stats could not be updated.");
            return View();
        }

        [ActionName("Delete")]
        public ActionResult Delete(int id)
        {
            var service = CreatePassingStatsService();
            var model = service.GetPlayerPassingStatsById(id);

            return View(model);
        }

        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeletePost(int id)
        {
            var service = CreatePassingStatsService();

            service.DeletePlayerPassingStats(id);

            TempData["SaveResult"] = "Player passing stats were deleted.";

            return RedirectToAction("Index");
        }

        private NFLPlayerStats_PassingService CreatePassingStatsService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new NFLPlayerStats_PassingService(userId);
            return service;
        }
    }
}