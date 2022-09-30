using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatsCreate
{
    internal class Level
    {
        public Level(string levelName, int levelCount)
        {
            LevelName = levelName;
            LevelCount = levelCount;
        }

        public string LevelName { get; set; }
        public int LevelCount { get; set; }
    }
}
