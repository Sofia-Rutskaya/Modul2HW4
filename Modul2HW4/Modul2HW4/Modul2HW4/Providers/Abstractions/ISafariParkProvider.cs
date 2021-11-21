using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modul2HW4.Models;

namespace Modul2HW4.Providers.Abstractions
{
    public interface ISafariParkProvider
    {
        public ChordatesAnimals[] GetAnimals();
    }
}
