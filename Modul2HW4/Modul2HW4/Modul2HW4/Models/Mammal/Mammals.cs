using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2HW4.Models.Mammal
{
    public abstract class Mammals : ChordatesAnimals
    {
        public virtual int ConstantBodyTemperature { get; init; }
        public virtual bool PulmonaryRespiration { get; init; }
    }
}
