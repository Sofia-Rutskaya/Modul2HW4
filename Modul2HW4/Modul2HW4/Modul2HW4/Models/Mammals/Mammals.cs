using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2HW4.Models
{
    public abstract class Mammals : ChordatesAnimals
    {
        // public abstract TypeOfAnimal AnimalType { get; init; }
        public virtual int ConstantBodyTemperature { get; init; }
        public virtual bool PulmonaryRespiration { get; init; }
    }
}
