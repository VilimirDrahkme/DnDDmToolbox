using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DnDDMTools.Models
{
    public class PlayerModel
    {
        public RaceModel Race { get; set; }
        public RaceModel SubRace { get; set; }
        public int Level { get; set; }
        public ClassModel Class { get; set; }
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

        public string Name { get; set; }
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




        public RaceModel(string name, int strmod, int dexmod, int conmod, int intmod, int wismod, int chamod, string[] femnames, string[] malenames,
                        int age, string alignment, string size, int maxfoot, int minfoot, int weight, string speed, int mininch, int maxinch)
        {
            Name = name;
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
        public RaceModel(string name, int strmod, int dexmod, int conmod, int intmod, int wismod, int chamod,
                       int maxfoot, int minfoot, string speed, int mininch, int maxinch)
        {
            Name = name;
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
    }//end class

    public class ClassModel
    {
        public int HitDie { get; set; }
        public AbilityModel Primary { get; set; }
        public AbilityModel Secondary { get; set; }
        public AbilityModel Tertiary { get; set; }
        public int ProficiencyBonus { get; set; }
    }

    public class AbilityModel
    {
        private int _abilityScoreMax { get; set; }
        private int _abilityScore { get; set; }
        private int _abilityScoreMin { get; set; }

        public int AbilityScore
        {
            get { return _abilityScore; }
            set
            {
                if (value > _abilityScoreMax)
                {
                    _abilityScore = _abilityScoreMax;
                }
                else if (value < _abilityScoreMin)
                {
                    _abilityScore = _abilityScoreMin;
                }
                else
                {
                    _abilityScore = value;
                }
            }
        }//end logic for abilityscore

        public int AbilityModifier { get; set; }

        public AbilityModel(int abilityScoreMax, int abilityScore, int abilityScoreMin)
        {
            _abilityScoreMax = abilityScoreMax;
            _abilityScoreMin = abilityScoreMin;
            _abilityScore = abilityScore;
        }


    }




}//end namespace