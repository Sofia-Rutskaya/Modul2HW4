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
        private SafariParkSectionService _sectionService;

        public UIService()
        {
            _sectionService = new SafariParkSectionService();
        }

        void IUIService.InfoAboutSafariPark()
        {
            Console.WriteLine($"Park has a {_sectionService.GetAnimal()} different species of animals.");
        }
    }
}
