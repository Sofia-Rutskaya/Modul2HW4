using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modul2HW4.Models.Animal_s_Specific;

namespace Modul2HW4.Models.Bird
{
    // Новонебные
    public abstract class Neognathae : Birds
    {
        public virtual TypeOfPalate Palate { get; init; }
    }
}
