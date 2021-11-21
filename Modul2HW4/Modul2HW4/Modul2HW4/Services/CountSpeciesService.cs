using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modul2HW4.Services.Abstractions;
using Modul2HW4.Models;

namespace Modul2HW4.Services
{
    public class CountSpeciesService : ICountSpeciesService
    {
        private ChordatesAnimals[] _forCountAnimal;

        public CountSpeciesService()
        {
            _forCountAnimal = new ChordatesAnimals[1];
        }

        int? ICountSpeciesService.CoutSpecies(ChordatesAnimals[] animals)
        {
            if (animals == null)
            {
                return null;
            }

            _forCountAnimal[0] = animals[0];

            for (var i = 1; i < animals.Length; i++)
            {
                var count = 0;
                for (var j = 0; j < _forCountAnimal.Length; j++)
                {
                    if (animals[i].AnimalType != _forCountAnimal[j].AnimalType)
                    {
                        count++;
                    }

                    if (count == _forCountAnimal.Length)
                    {
                        count = 0;
                        Array.Resize<ChordatesAnimals>(ref _forCountAnimal, _forCountAnimal.Length + 1);
                        _forCountAnimal[j + 1] = animals[i];
                        break;
                    }
                }
            }

            return _forCountAnimal.Length;
        }
    }
}
