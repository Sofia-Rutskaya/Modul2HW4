using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modul2HW4.Providers;
using Modul2HW4.Models;
using Modul2HW4.Models.Animal_s_Specific;

namespace Modul2HW4.Services
{
    public class SafariParkSectionService
    {
        private readonly SafariParkProvider _safariParkProvider;

        public SafariParkSectionService()
        {
            _safariParkProvider = new SafariParkProvider();
        }

        public ChordatesAnimals[] GetAnimal()
        {
            return _safariParkProvider.GetAnimals();
        }

        public void FindAnimal(string name, TypeOfAnimal type, double weight)
        {
        }

        public void Sort()
        {
            Array.Sort(GetAnimal(), new SortAnimalService());
        }
    }
}
