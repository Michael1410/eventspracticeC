using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Player
    {
        public string Name { get; set; }
        public double Health { get; set; }
        public double Attack { get; set; }
        public double Block { get; set; }
        public int Level { get; set; }

        // Character Stats
        public double Strength { get; set; }
        public double Dex { get; set; }
        public double Endurance { get; set; }
        public double Intelligence { get; set; }
        public double Wisdom { get; set; }
        public double Charisma { get; set; }
        public double ArmourScore { get; set; }
        public int initiatives { get; set; }

        // Damage Resistances
        public double FireResistance { get; set; }
        public double LightningResistance { get; set; }
        public double WaterResistance { get; set; }
        public double WindResistance { get; set; }
        public double HolyResistance { get; set; }

        // Status Resistances

        public double PoisonResistence { get; set; }
        public double DiseaseResistance { get; set; }
        public double SleepResistance { get; set; }
        public double ConfuseResistance { get; set; }
        public double FearResistance { get; set; }
        public double InstanceDeathResistance { get; set; }

        public double RightHand { get; set; }
        public double LeftHand { get; set; }
        public double ArmourChest { get; set; }
        public double ArmourHelm { get; set; }

        public double ArmourGloves { get; set;}
        public double ArmourBoots { get; set; }

        public bool Turn { get; set; }

        // Constructer for Player
        public Player(string name, double health, double attack, double block,
                        double strength, double dex, double endurance, 
                        double intelligence, double charisma, double wisdom,
                        double armourScore, double fireResistance,
                        double lightningResistance, double waterResistance,
                        double windResistance, double holyResistance,
                        double poisonResistence, double sleepResistance,
                        double confuseResistance, double fearResistance, 
                        double instanceDeathResistance,
                        double rightHand, double leftHand, double armourChest,
                        double armourHelm, double armourGloves, double armourBoots, 
                        int level, int _initiative, bool turn )
        {
            Name = name;
            Health = health;
            Attack = attack;
            Block = block;
            Level = level;

            Strength = strength;
            Dex = dex;
            Endurance = endurance;
            Intelligence = intelligence;
            Charisma = charisma;
            Wisdom = wisdom;
            ArmourScore = armourScore;
            initiatives = _initiative;

            FireResistance = fireResistance;
            LightningResistance = lightningResistance;
            WaterResistance = waterResistance;
            WindResistance = windResistance;
            HolyResistance = holyResistance;

            PoisonResistence = poisonResistence;
            SleepResistance = sleepResistance;
            ConfuseResistance = confuseResistance;
            FearResistance = fearResistance;
            InstanceDeathResistance = instanceDeathResistance;

            RightHand = rightHand;
            LeftHand = leftHand;
            ArmourChest = armourChest;
            ArmourHelm = armourHelm;
            ArmourGloves = armourGloves;
            ArmourBoots = armourBoots;

            Turn = turn;

        }

    }
}