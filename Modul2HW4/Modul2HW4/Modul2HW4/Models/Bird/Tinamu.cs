using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modul2HW4.Models.Animal_s_Specific;

namespace Modul2HW4.Models.Bird
{
    public class Tinamu : Keelless
    {
        public override string Name { get; set; }
        public override TypeOfAnimal AnimalType { get; init; }
        public override WayOfLife Way { get; init; }
        public override bool AbilityToFly { get; init; }
        public bool MonotonyOfVoice { get; init; }
    }
}
