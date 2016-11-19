using DnDDMTools.Models;
using System;
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







            return View();
        }
        public JsonResult PopulateSubraces(int id)
        {
            RaceModel[] subraces = null;
            switch (id)
            {
                case 1:
                    //user picked Dwarf
                    RaceModel HillDwarf = new RaceModel(0, 0, 2, 0, 1, 0, 4, 3, "25 feet or 5 5x5 squares", 12, 12);
                    RaceModel MountainDwarf = new RaceModel(2, 0, 2, 0, 0, 0, 4, 2, "25 feet or 5 5x5 squares", 12, 12);
                    subraces = new RaceModel[2] { HillDwarf, MountainDwarf };
                    break;
                case 2:
                    //user picked elf
                    RaceModel HighElf = new RaceModel(0, 2, 0, 1, 0, 0, 6, 3, "30 feet or 6 5x5 squares", 12, 12);
                    RaceModel WoodElf = new RaceModel(0, 2, 0, 0, 1, 0, 6, 3, "35 feet or 7 5x5 squares", 12, 12);
                    RaceModel Drow = new RaceModel(0, 2, 0, 0, 0, 1, 6, 3, "30 feet or 6 5x5 squares", 12, 12);
                    subraces = new RaceModel[3] { HighElf, WoodElf, Drow };
                    break;
                case 3:
                    //user picked halfling
                    RaceModel Lightfoot = new RaceModel(0, 2, 0, 0, 0, 1, 3, 1, "25 feet or 5 5x5 squares", 6, 6);
                    RaceModel Stout = new RaceModel(0, 2, 1, 0, 0, 0, 1, 3, "25 feet or 5 5x5 squares", 6, 6);
                    subraces = new RaceModel[2] { Lightfoot, Stout };
                    break;
                case 4:
                    //Human :P boring right?
                    RaceModel Human = new RaceModel(1, 1, 1, 1, 1, 1, 6, 4, "30 feet or 6 5x5 squares", 6, 6);
                    RaceModel HumanVARIANT = new RaceModel(0, 0, 0, 0, 0, 0, 6, 4, "30 feet or 6 5x5 squares", 6, 6);
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





            if (subraces != null)
            {
                return Json(subraces, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json("sorry....no available subraces at this time", JsonRequestBehavior.AllowGet);
            }
        }
    }
}