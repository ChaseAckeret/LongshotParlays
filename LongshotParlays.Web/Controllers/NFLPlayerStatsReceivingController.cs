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
    public class NFLPlayerStatsReceivingController : Controller
    {
        [Authorize]
        // GET: NFLPlayerStatsReceiving
        public ActionResult Index()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new NFLPlayerStats_ReceivingService(userId);
            var model = service.GetReceivingStats();
            return View(model);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(NFLPlayerStats_ReceivingCreate model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var service = CreateReceivingService();

            if (service.CreateReceivingStats(model))
            {
                TempData["SaveResult"] = "Receiving stats addded";
                return RedirectToAction("Index");
            };

            ModelState.AddModelError("", "Receiving stats could not be added");
            return View(model);
        }

        public ActionResult Details(int id)
        {
            var service = CreateReceivingService();
            var model = service.GetReceivingStatsById(id);

            return View(model);
        }

        public ActionResult Edit(int id)
        {
            var service = CreateReceivingService();
            var detail = service.GetReceivingStatsById(id);
            var model =
                new NFLPlayerStats_ReceivingEdit
                {
                    PlayerId = detail.PlayerId,
                    Targets = detail.Targets,
                    Receptions = detail.Receptions,
                    Touchdowns = detail.Touchdowns
                };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, NFLPlayerStats_ReceivingEdit model)
        {
            if (!ModelState.IsValid)
            return View(model);

            if(model.PlayerId != id)
            {
                ModelState.AddModelError("", "Id Mismatch");
                return View(model);
            }

            var service = CreateReceivingService();

            if (service.UpdateReceivingStats(model))
            {
                TempData["SaveResult"] = "Receiving stats were updated.";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Receiving stats could not be updated.");
            return View();
        }

        [ActionName("Delete")]
        public ActionResult Delete(int id)
        {
            var service = CreateReceivingService();
            var model = service.GetReceivingStatsById(id);

            return View(model);
        }

        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeletePost(int id)
        {
            var service = CreateReceivingService();

            service.DeleteReceivingStats(id);

            TempData["SaveResult"] = "Receiving stats were deleted.";

            return RedirectToAction("Index");
        }

        private NFLPlayerStats_ReceivingService CreateReceivingService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new NFLPlayerStats_ReceivingService(userId);
            return service;
        }
    }
}