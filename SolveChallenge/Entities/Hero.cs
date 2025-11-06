using SolveChallenge.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveChallenge.Entities
{
    class Hero : Player, SpecialAttack
    {
        //public Hero(string name, int health, double exp, int skill)
        //    : base(name, health, exp)
        //{
        //    Skill = skill;
        //}

        public int Skill { get; set; }
    }
}
