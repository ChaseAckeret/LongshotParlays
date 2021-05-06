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
    public class NFLTeamStats_OffenseController : Controller
    {
        [Authorize]
        // GET: NFLTeamStats_Offense
        public ActionResult Index()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new NFLTeamStats_OffenseService(userId);
            var model = service.GetOffenseStats();
            return View(model);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(NFLTeamStats_OffenseCreate model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var service = CreateOffenseStatsService();

            if (service.CreateOffenseStats(model))
            {
                TempData["SaveResult"] = "Offense stats were added.";
                return RedirectToAction("Index");

            }

            ModelState.AddModelError("", "Offense stats could not be added.");
            return View(model);

        }

        public ActionResult Details(int id)
        {
            var service = CreateOffenseStatsService();
            var model = service.GetOffenseStatsById(id);

            return View(model);
        }

        public ActionResult Edit(int id)
        {
            var service = CreateOffenseStatsService();
            var detail = service.GetOffenseStatsById(id);
            var model =
                new NFLTeamStats_OffenseEdit
                {
                    TeamId = detail.TeamId,
                    Team = detail.Team,
                    GamesPlayed = detail.GamesPlayed,
                    PointsForced = detail.PointsForced
                };
            return View(model);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, NFLTeamStats_OffenseEdit model)
        {
            if (!ModelState.IsValid)
                return View(model);

            if(model.TeamId != id)
            {
                ModelState.AddModelError("", "Team Id Mismatch");
                return View(model);
            }

            var service = CreateOffenseStatsService();

            if (service.UpdateOffenseStats(model))
            {
                TempData["SaveResult"] = "Offense stats were updated.";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Offense stats could not be updated");
            return View(model);
        }

        [ActionName("Delete")]
        public ActionResult Delete(int id)
        {
            var service = CreateOffenseStatsService();
            var model = service.GetOffenseStatsById(id);

            return View(model);
        }

        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeletePost(int id)
        {
            var service = CreateOffenseStatsService();

            service.DeleteOffenseStats(id);

            TempData["SaveResult"] = "Offense stats were deleted";
            return RedirectToAction("Index");

        }

        private NFLTeamStats_OffenseService CreateOffenseStatsService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new NFLTeamStats_OffenseService(userId);
            return service;
        }
    }
}