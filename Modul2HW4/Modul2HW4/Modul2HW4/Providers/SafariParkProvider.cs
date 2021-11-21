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
                    Name = "Tiger Maya",
                    Way = Models.Animal_s_Specific.WayOfLife.Carnivores,
                    Weight = 250,
                    AnimalType = Models.Animal_s_Specific.TypeOfAnimal.Tiger,
                    Tigres = Models.Animal_s_Specific.TigerSubspecies.AmurTiger,
                    ClawsRetract = true,
                    ConstantBodyTemperature = 42,
                    ClimbsTrees = true,
                    PulmonaryRespiration = false
                },
                new Leopard
                {
                    Name = "Leopard Chara",
                    AnimalType = Models.Animal_s_Specific.TypeOfAnimal.Leopard,
                    Weight = 31,
                    Way = Models.Animal_s_Specific.WayOfLife.Carnivores,
                    Leopards = Models.Animal_s_Specific.LeopardSubspecies.IndianLeopard
                },
                new Leopard
                {
                    Name = "Leopard Hamarin",
                    AnimalType = Models.Animal_s_Specific.TypeOfAnimal.Leopard,
                    Weight = 26,
                    Way = Models.Animal_s_Specific.WayOfLife.Carnivores,
                    Leopards = Models.Animal_s_Specific.LeopardSubspecies.FarEasternLeopard,
                    ClimbsTrees = true
                },
            };
        }

        public ChordatesAnimals[] GetAnimals()
        {
            return _animals;
        }
    }
}
