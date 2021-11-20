using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modul2HW4.Models.Animal_s_Specific;

namespace Modul2HW4.Models
{
    public abstract class ChordatesAnimals
    {
        public abstract string Name { get; set; }
        public abstract TypeOfAnimal AnimalType { get; init; }
        public abstract WayOfLife Way { get; init; }
        public virtual double Weight { get; set; }
    }
}
