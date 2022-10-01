using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatsCreate
{
    internal class Skill
    {
        public Skill(string skillName)
        {
            SkillName = skillName;
        }

        public string SkillName { get; set; }
    }
}
