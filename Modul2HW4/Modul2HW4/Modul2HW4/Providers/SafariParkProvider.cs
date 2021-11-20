using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modul2HW4.Models;
using Modul2HW4.Models.Mammal;

namespace Modul2HW4.Providers
{
    public class SafariParkProvider
    {
        private readonly ChordatesAnimals[] _animals;
        public SafariParkProvider()
        {
            _animals = new ChordatesAnimals[]
            {
                new Tiger
                {
                    Name = "Tiger",
                    Way = Models.Animal_s_Specific.WayOfLife.Carnivores,
                    Weight = 500,
                    AnimalType = Models.Animal_s_Specific.TypeOfAnimal.Tiger,
                    Tigres = Models.Animal_s_Specific.TigerSubspecies.AmurTiger
                }
            };
        }
    }
}
