using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modul2HW4.Models;

namespace Modul2HW4.Services.Abstractions
{
    public interface ICountSpeciesService
    {
        public int? CoutSpecies(ChordatesAnimals[] animals);
    }
}
