using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modul2HW4.Models;

namespace Modul2HW4.Services
{
    public class SortAnimalService : IComparer<ChordatesAnimals>
    {
        private readonly ChordatesAnimals[] _animals;
        private readonly SafariParkSectionService _safariParkSectionService;

        public SortAnimalService()
        {
            _safariParkSectionService = new SafariParkSectionService();
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
