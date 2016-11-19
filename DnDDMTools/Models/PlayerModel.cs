using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DnDDMTools.Models
{
    public class PlayerModel
    {
        public RaceModel Race { get; set; }
    }

    public class RaceModel
    {
        private int _minFoot;
        private int _minInch;
        private int _maxFoot;
        private int _maxInch;


        public int STRMod { get; set; }
        public int DEXMod { get; set; }
        public int CONMod { get; set; }
        public int INTMod { get; set; }
        public int WISMod { get; set; }
        public int CHAMod { get; set; }

        public string[] FemaleNames { get; set; }
        public string[] MaleNames { get; set; }
        public int Age { get; set; }
        public string Alignment { get; set; }
        public string Size { get; set; }
        public int MaxFoot { get; set; }
        public int MinFoot { get; set; }
        public int MaxInch { get; set; }
        public int MinInch { get; set; }
        public int Weight { get; set; }
        public string Speed { get; set; }




        public RaceModel(int strmod, int dexmod, int conmod, int intmod, int wismod, int chamod, string[] femnames,string[]malenames,
                        int age, string alignment, string size, int maxfoot, int minfoot, int weight, string speed, int mininch, int maxinch)
        {
            STRMod = strmod;
            DEXMod = dexmod;
            CONMod = conmod;
            INTMod = intmod;
            WISMod = wismod;
            CHAMod = chamod;
            FemaleNames = femnames;
            MaleNames = malenames;
            Age = age;
            Alignment = alignment;
            Size = size;
            MaxFoot = maxfoot;
            MinFoot = minfoot;
            Weight = weight;
            Speed = speed;
            MaxInch = maxinch;
            MinInch = mininch;
        }
        /// <summary>
        /// SubRaceModel
        /// </summary>
        /// <param name="strmod"></param>
        /// <param name="dexmod"></param>
        /// <param name="conmod"></param>
        /// <param name="intmod"></param>
        /// <param name="wismod"></param>
        /// <param name="chamod"></param>
        /// <param name="maxfoot"></param>
        /// <param name="minfoot"></param>
        /// <param name="speed"></param>
        /// <param name="mininch"></param>
        /// <param name="maxinch"></param>
        public RaceModel(int strmod, int dexmod, int conmod, int intmod, int wismod, int chamod,
                       int maxfoot, int minfoot, string speed, int mininch, int maxinch)
        {
            STRMod = strmod;
            DEXMod = dexmod;
            CONMod = conmod;
            INTMod = intmod;
            WISMod = wismod;
            CHAMod = chamod;
            MaxFoot = maxfoot;
            MinFoot = minfoot;
            Speed = speed;
            MaxInch = maxinch;
            MinInch = mininch;
        }
    }
}