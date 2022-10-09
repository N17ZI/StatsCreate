using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatsCreate
{
    internal class Equipment
    {
        public Equipment(string equipmentName)
        {
            EquipmentName = equipmentName;
        }

        public string EquipmentName { get; set; }
    }
}
