using DnDDMTools.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DnDDMTools.Data.Entities;

namespace DnDDMTools.Controllers
{
    public class HomeController : Controller
    {
        private Entities db = new Entities();
        public ActionResult Index()
        {
            var races = db.Races.Select(r=>r.Name);
            ViewBag.Race = races;

            SelectListItem[] LevelArray = new SelectListItem[20];
            for (int i = 0; i <= 19; i++)
            {
                LevelArray[i] = new SelectListItem() { Text = ("Level " + (i + 1).ToString()), Value = (i + 1).ToString() };
            }
            ViewBag.Levels = LevelArray;

            SelectListItem[] StatMethod;
            SelectListItem pointBuy = new SelectListItem { Text = "Point Buy Method", Value = "1" };
            SelectListItem machineRoll = new SelectListItem { Text = "Machine Roll (4d6 best 3)", Value = "2" };
            SelectListItem manualInput = new SelectListItem { Text = "Manually Input scores", Value = "3" };
            StatMethod = new SelectListItem[3] { pointBuy, machineRoll, manualInput };
            ViewBag.StatMethod = StatMethod;



            return View();
        }
        [HttpPost]
        public JsonResult PopulateSubraces(int id)
        {
            var subraces = db.SubRaces.Where(s=>s.RaceId == id).ToList();
            if (subraces != null)
            {
                return Json(subraces);
            }
            else
            {
                return Json("sorry....no available subraces at this time");
            }
        }

        [HttpPost]
        public JsonResult SelectedSubrace(int mainId, int srId)
        {
            SubRace selectedSubrace = GetSelectedSubRace(mainId, srId);
            return Json(selectedSubrace, JsonRequestBehavior.AllowGet);
        }


        public IEnumerable<SubRace> GetSubRaces(int id)
        {
            var subraces = db.SubRaces.Where(t=>t.RaceId == id);
            
            return subraces;
        }//end GetSubRace

        public SubRace GetSelectedSubRace(int mainId, int srId)
        {
            SubRace selected = db.SubRaces.Where(s=>s.RaceId == mainId && s.Id == srId).FirstOrDefault();
            return selected;
        }
    }
}