using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modul2HW4.Models;
using Modul2HW4.Models.Mammal;
using Modul2HW4.Models.Bird;
using Modul2HW4.Providers.Abstractions;

namespace Modul2HW4.Providers
{
    public class SafariParkProvider : ISafariParkProvider
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
                new Tiger
                {
                    Name = "Tiger Aska",
                    Way = Models.Animal_s_Specific.WayOfLife.Carnivores,
                    Weight = 300,
                    AnimalType = Models.Animal_s_Specific.TypeOfAnimal.Tiger,
                    Tigres = Models.Animal_s_Specific.TigerSubspecies.BengalTiger,
                    ClawsRetract = true,
                    ConstantBodyTemperature = 41,
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
                new Deer
                {
                    Name = "Deer Capa",
                    AnimalType = Models.Animal_s_Specific.TypeOfAnimal.Deer,
                    Weight = 120,
                    Way = Models.Animal_s_Specific.WayOfLife.Herbivores,
                    Deers = Models.Animal_s_Specific.DeerSubspecies.RedDeer,
                    Horns = true
                },
                new Bucerotiformes
                {
                    Name = "Bird-Rhino Eve",
                    AbilityToFly = true,
                    LargeGrowthOnTheBeak = true,
                    AnimalType = Models.Animal_s_Specific.TypeOfAnimal.Bucerotiformes,
                    Color = Models.Animal_s_Specific.ColorPlumage.Green,
                    Way = Models.Animal_s_Specific.WayOfLife.Herbivores,
                    Palate = Models.Animal_s_Specific.TypeOfPalate.DromeognathicType,
                    Weight = 7
                },
                new Leopard
                {
                    Name = "Leopard Hamarin",
                    AnimalType = Models.Animal_s_Specific.TypeOfAnimal.Leopard,
                    Weight = 26,
                    Way = Models.Animal_s_Specific.WayOfLife.Carnivores,
                    Leopards = Models.Animal_s_Specific.LeopardSubspecies.FarEasternLeopard,
                    ClimbsTrees = true
                }
            };
        }

        ChordatesAnimals[] ISafariParkProvider.GetAnimals()
        {
            return _animals;
        }
    }
}
