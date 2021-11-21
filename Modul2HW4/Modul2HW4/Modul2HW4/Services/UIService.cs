using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modul2HW4.Services.Abstractions;
using Modul2HW4.Extension;

namespace Modul2HW4.Services
{
    public class UIService : IUIService
    {
        private readonly ICountSpeciesService _icountSpeciesService;
        private readonly ISafariParkSectionService _sectionService;
        private StringBuilder _message;

        public UIService(ICountSpeciesService countSpecies, ISafariParkSectionService safariParkSection)
        {
            _icountSpeciesService = countSpecies;
            _sectionService = safariParkSection;
            _message = new StringBuilder();
        }

        void IUIService.InfoAboutSafariPark()
        {
            _message.Append($"Park has a");
            _message.Append($" {_icountSpeciesService.CoutSpecies(_sectionService.GetAnimal())}");
            _message.Append($" different species of animals");
            Console.WriteLine(_message);
        }

        void IUIService.Sort()
        {
            _message.Clear();
            Array.Sort(_sectionService.GetAnimal(), new SortAnimalService(_sectionService));
            _message.Append('-', 10);
            _message.Append("Array sorted");
            _message.Append('-', 10);
            Console.WriteLine(_message);
        }

        void IUIService.FindAnimal()
        {
            if (_sectionService.GetAnimal().FindAnimal("Tiger Aska", Models.Animal_s_Specific.TypeOfAnimal.Tiger, 300) == false)
            {
                Console.WriteLine("Animal doesn't exist in Safari Park!");
            }
            else if (_sectionService.GetAnimal().FindAnimal("Tiger Aska", Models.Animal_s_Specific.TypeOfAnimal.Tiger, 300) == true)
            {
                Console.WriteLine("The animal is in the Safari Park!");
            }
        }
    }
}
