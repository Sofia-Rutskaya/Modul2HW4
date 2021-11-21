using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modul2HW4.Services.Abstractions;

namespace Modul2HW4.Services
{
    public class UIService : IUIService
    {
        private readonly SafariParkSectionService _sectionService;
        private readonly ICountSpeciesService _icountSpeciesService;
        private StringBuilder _message;

        public UIService(ICountSpeciesService countSpecies)
        {
            _sectionService = new SafariParkSectionService();
            _icountSpeciesService = countSpecies;
            _message = new StringBuilder();
        }

        void IUIService.InfoAboutSafariPark()
        {
            _message.Append($"Park has a");
            _message.Append($" {_icountSpeciesService.CoutSpecies(_sectionService.GetAnimal())}");
            _message.Append($" different species of animals");
            Console.WriteLine(_message);
        }
    }
}
