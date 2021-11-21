using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modul2HW4.Models;
using Modul2HW4.Services.Abstractions;

namespace Modul2HW4.Services
{
    public class SortAnimalService : IComparer<ChordatesAnimals>
    {
        private readonly ChordatesAnimals[] _animals;
        private readonly ISafariParkSectionService _safariParkSectionService;

        public SortAnimalService(ISafariParkSectionService safariParkSectionService)
        {
            _safariParkSectionService = safariParkSectionService;
            _animals = _safariParkSectionService.GetAnimal();
        }

        public int Compare(ChordatesAnimals x, ChordatesAnimals y)
        {
            if (y == null || x == null)
            {
                return 0;
            }

            if (x.Weight < y.Weight)
            {
                var a = x;
                x = y;
                y = a;

                return 1;
            }
            else if (x.Weight > y.Weight)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
