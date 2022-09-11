using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatsCreate
{
    internal class Unit
    {
        //Stats hero
        public double Strength;
        public double Dexterity;
        public double Constitution;
        public double Intellicence;

        public Unit(int Strength, int Dexterity, int Constitution,int Intellicence)
        {
            this.Strength = Strength;
            this.Dexterity = Dexterity;
            this.Constitution = Constitution;
            this.Intellicence = Intellicence;
        }
    }
}
