using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modul2HW4.Providers;
using Modul2HW4.Services.Abstractions;
using Modul2HW4.Providers.Abstractions;
using Modul2HW4.Models;
using Modul2HW4.Models.Animal_s_Specific;

namespace Modul2HW4.Services
{
    public class SafariParkSectionService : ISafariParkSectionService
    {
        private readonly ISafariParkProvider _safariParkProvider;

        public SafariParkSectionService(ISafariParkProvider safariParkProvider)
        {
            _safariParkProvider = safariParkProvider;
        }

        ChordatesAnimals[] ISafariParkSectionService.GetAnimal()
        {
            return _safariParkProvider.GetAnimals();
        }

        void ISafariParkSectionService.FindAnimal(string name, TypeOfAnimal type, double weight)
        {
        }
    }
}
