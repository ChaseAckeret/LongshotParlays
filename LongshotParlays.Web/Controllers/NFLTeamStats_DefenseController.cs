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
    public class NFLTeamStats_DefenseController : Controller
    {
        [Authorize]
        // GET: NFLTeamStats_Defense
        public ActionResult Index()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new NFLTeamStats_DefenseService(userId);
            var model = service.GetDefenseStats();

            return View(model);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(NFLTeamStats_DefenseCreate model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var service = CreateDefenseStatsService();

            if (service.CreateDefenseStats(model))
            {
                TempData["SaveResult"] = "Defense stats were added.";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Defense stats could not be added.");
            return View(model);

        }

        public ActionResult Details(int id)
        {
            var service = CreateDefenseStatsService();
            var model = service.GetDefenseStatsById(id);

            return View(model);
        }

        public ActionResult Edit(int id)
        {
            var service = CreateDefenseStatsService();
            var detail = service.GetDefenseStatsById(id);
            var model =
                new NFLTeamStats_DefenseEdit
                {
                    TeamId = detail.TeamId,
                    Team = detail.Team,
                    GamesPlayed = detail.GamesPlayed,
                    PointsAllowed = detail.PointsAllowed,
                };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, NFLTeamStats_DefenseEdit model)
        {
            if (!ModelState.IsValid)
                return View(model);

            if(model.TeamId != id)
            {
                ModelState.AddModelError("", "Team Id Mismatch");
                return View(model);
            }

            var service = CreateDefenseStatsService();

            if (service.UpdateDefenseStats(model))
            {
                TempData["SaveResult"] = "Defense stats were updated.";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Defense stats could not be updated.");
            return View(model);
        }

        [ActionName("Delete")]
        public ActionResult Delete(int id)
        {
            var service = CreateDefenseStatsService();
            var model = service.GetDefenseStatsById(id);

            return View(model);
        }

        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeletePost(int id)
        {
            var service = CreateDefenseStatsService();

            service.DeleteDefenseStats(id);

            TempData["SaveResult"] = "Defense stats were deleted.";
            return RedirectToAction("Index");
        }


        private NFLTeamStats_DefenseService CreateDefenseStatsService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new NFLTeamStats_DefenseService(userId);
            return service;
        }
    }
}