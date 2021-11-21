using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modul2HW4.Models;
using Modul2HW4.Models.Animal_s_Specific;

namespace Modul2HW4.Services.Abstractions
{
    public interface ISafariParkSectionService
    {
        public ChordatesAnimals[] GetAnimal();
        public void FindAnimal(string name, TypeOfAnimal type, double weight);
    }
}
