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
    public class NFLTeamInfoController : Controller
    {
        // GET: NFLTeamInfo
        public ActionResult Index()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new NFLTeamInfoService(userId);
            var model = service.GetTeams();

            return View(model);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(NFLTeamInfoCreate model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var service = CreateTeamService();

            if (service.CreateTeam(model))
            {
                TempData["SaveResult"] = "Team was created";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Team could not be created.");
            return View(model);

        }

        public ActionResult Details(int id)
        {
            var service = CreateTeamService();
            var model = service.GetTeamById(id);

            return View(model); 
        }

        public ActionResult Edit(int id)
        {
            var service = CreateTeamService();
            var detail = service.GetTeamById(id);
            var model =
                new NFLTeamInfoEdit
                {
                    TeamId = detail.TeamId,
                    Name = detail.Name,
                    Abbreviation = detail.Abbreviation,
                    City = detail.City,
                    Stadium = detail.Stadium,
                    HeadCoach = detail.HeadCoach,
                    Conference = detail.Conference,
                    Division = detail.Division
                };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, NFLTeamInfoEdit model)
        {
            if(!ModelState.IsValid)
            return View(model);

            if(model.TeamId != id)
            {
                ModelState.AddModelError("", "Team Id Mismatch");
                return View(model);
            }

            var service = CreateTeamService();

            if (service.UpdateNFLTeamInfo(model))
            {
                TempData["SaveResult"] = "Team was updated.";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Team could not be updated.");
            return View();
        }

        [ActionName("Delete")]
        public ActionResult Delete(int id)
        {
            var service = CreateTeamService();
            var model = service.GetTeamById(id);

            return View(model);
        }

        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeletePost(int id)
        {
            var service = CreateTeamService();
            service.DeleteNFLTeamInfo(id);

            TempData["SaveResult"] = "Team was deleted";

            return RedirectToAction("Index");
        }

        private NFLTeamInfoService CreateTeamService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new NFLTeamInfoService(userId);
            return service;
        }
    }
}