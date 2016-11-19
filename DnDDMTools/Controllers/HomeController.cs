using DnDDMTools.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DnDDMTools.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            SelectListItem[] Race;
            SelectListItem Dwarf = new SelectListItem() { Text = "Dwarf", Value = "1" };
            SelectListItem Elf = new SelectListItem() { Text = "Elf", Value = "2" };
            SelectListItem Halfling = new SelectListItem() { Text = "Halfling", Value = "3" };
            SelectListItem Human = new SelectListItem() { Text = "Human", Value = "4" };
            SelectListItem Dragonborn = new SelectListItem() { Text = "Dragonborn", Value = "5" };

            Race = new SelectListItem[5] { Dwarf, Elf, Halfling, Human, Dragonborn };
            ViewBag.Race = Race;

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
            RaceModel[] subraces = null;
            switch (id)
            {
                case 1:
                    //user picked Dwarf
                    RaceModel HillDwarf = new RaceModel("Hill Dwarf", 0, 0, 2, 0, 1, 0, 4, 3, "25 feet or 5 5x5 squares", 12, 12);
                    RaceModel MountainDwarf = new RaceModel("Mountain Dwarf", 2, 0, 2, 0, 0, 0, 4, 2, "25 feet or 5 5x5 squares", 12, 12);
                    subraces = new RaceModel[2] { HillDwarf, MountainDwarf };
                    break;
                case 2:
                    //user picked elf
                    RaceModel HighElf = new RaceModel("High Elf", 0, 2, 0, 1, 0, 0, 6, 3, "30 feet or 6 5x5 squares", 12, 12);
                    RaceModel WoodElf = new RaceModel("Wood Elf", 0, 2, 0, 0, 1, 0, 6, 3, "35 feet or 7 5x5 squares", 12, 12);
                    RaceModel Drow = new RaceModel("Drow", 0, 2, 0, 0, 0, 1, 6, 3, "30 feet or 6 5x5 squares", 12, 12);
                    subraces = new RaceModel[3] { HighElf, WoodElf, Drow };
                    break;
                case 3:
                    //user picked halfling
                    RaceModel Lightfoot = new RaceModel("LightFoot", 0, 2, 0, 0, 0, 1, 3, 1, "25 feet or 5 5x5 squares", 6, 6);
                    RaceModel Stout = new RaceModel("Stout", 0, 2, 1, 0, 0, 0, 1, 3, "25 feet or 5 5x5 squares", 6, 6);
                    subraces = new RaceModel[2] { Lightfoot, Stout };
                    break;
                case 4:
                    //Human :P boring right?
                    RaceModel Human = new RaceModel("Human", 1, 1, 1, 1, 1, 1, 6, 4, "30 feet or 6 5x5 squares", 6, 6);
                    RaceModel HumanVARIANT = new RaceModel("HumanVARIANT", 0, 0, 0, 0, 0, 0, 6, 4, "30 feet or 6 5x5 squares", 6, 6);
                    //come back for the variant for noting that >user< picks his stat allocations as well as one feat and one skill
                    subraces = new RaceModel[2] { Human, HumanVARIANT };
                    break;
                case 5:
                    //Dragonborn - fucking a dude. yes.
                    //unfortunately, no alts here :(
                    break;


                default:
                    break;
            }

            SelectListItem[] returnToView = null;

            if (subraces != null)
            {
                returnToView = new SelectListItem[subraces.Count()];

                for (int i = 0; i < subraces.Count(); i++)
                {
                    returnToView[i] = new SelectListItem() { Text = subraces[i].Name, Value = (i).ToString() };
                }


            }





            if (returnToView != null)
            {
                return Json(returnToView, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json("sorry....no available subraces at this time");
            }
        }
    }
}