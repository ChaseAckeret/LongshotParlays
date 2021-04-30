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
    public class NFLPlayerInfoController : Controller
    {
        // GET: NFLPlayerInfo
        public ActionResult Index()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new NFLPlayerInfoService(userId);
            var model = service.GetPlayers();
            return View(model);
        }

        //GET
        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(NFLPlayerInfoCreate model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var service = CreatePlayerService();

            if (service.CreatePlayer(model))
            {
                TempData["SaveResult"] = "Player was created.";
                return RedirectToAction("Index");
            };

            ModelState.AddModelError("", "Player could not be created.");

            return View(model);
        }

        public ActionResult Details(int id)
        {
            var service = CreatePlayerService();
            var model = service.GetPlayerById(id);

            return View(model);
        }

        public ActionResult Edit(int id)
        {
            var service = CreatePlayerService();
            var detail = service.GetPlayerById(id);
            var model =
                new NFLPlayerInfoEdit
                {
                    PlayerId = detail.PlayerId,
                    FirstName = detail.FirstName,
                    LastName = detail.LastName,
                    Age = detail.Age,
                    Position = detail.Position,
                    Team = detail.Team,
                    InjuryStatus = detail.InjuryStatus
                };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, NFLPlayerInfoEdit model)
        {
            if(!ModelState.IsValid)
            return View(model);

            if(model.PlayerId != id)
            {
                ModelState.AddModelError("", "Id Mistmatch");
                return View(model);
            }

            var service = CreatePlayerService();

            if (service.UpdateNFLPlayerInfo(model))
            {
                TempData["SaveResult"] = "Player info was saved.";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Player info could not be updated.");
            return View(model);
        }

        [ActionName("Delete")]
        public ActionResult Delete(int id)
        {
            var service = CreatePlayerService();
            var model = service.GetPlayerById(id);

            return View(model);
        }

        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeletePost(int id)
        {
            var service = CreatePlayerService();

            service.DeletePlayer(id);

            TempData["SaveResult"] = "Player was deleted";

            return RedirectToAction("Index");
        }


        private NFLPlayerInfoService CreatePlayerService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new NFLPlayerInfoService(userId);
            return service;
        }
    }
}