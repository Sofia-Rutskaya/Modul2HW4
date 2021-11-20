using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modul2HW4.Models.Animal_s_Specific;

namespace Modul2HW4.Models
{
    public abstract class Birds : ChordatesAnimals
    {
        public abstract bool AbilityToFly { get; init; }
        public virtual ColorPlumage Color { get; set; }
    }
}
