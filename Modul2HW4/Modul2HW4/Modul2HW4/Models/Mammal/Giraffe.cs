using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modul2HW4.Models.Animal_s_Specific;

namespace Modul2HW4.Models.Mammal
{
    public class Giraffe : Artiodactyls
    {
        public override string Name { get; set; }
        public override TypeOfAnimal AnimalType { get; init; }
        public override WayOfLife Way { get; init; }
        public GiraffeSubspecies Gireffes { get; set; }
    }
}
