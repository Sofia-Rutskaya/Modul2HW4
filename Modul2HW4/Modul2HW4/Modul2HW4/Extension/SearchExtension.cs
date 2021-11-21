using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modul2HW4.Providers;
using Modul2HW4.Providers.Abstractions;
using Modul2HW4.Services;
using Modul2HW4.Services.Abstractions;
using Modul2HW4.Models;
using Modul2HW4.Models.Mammal;
using Modul2HW4.Models.Animal_s_Specific;

namespace Modul2HW4.Extension
{
    public static class SearchExtension
    {
        public static bool? FindAnimal(this ChordatesAnimals[] animals, string name, TypeOfAnimal typeOfAnimal, double weight)
        {
            for (var i = 0; i < animals.Length; i++)
            {
                if (animals[i] == null)
                {
                    return null;
                }

                if (animals[i].Name == name && animals[i].AnimalType == typeOfAnimal && animals[i].Weight == weight)
                {
                    return true;
                }
            }

            return true;
        }
    }
}
