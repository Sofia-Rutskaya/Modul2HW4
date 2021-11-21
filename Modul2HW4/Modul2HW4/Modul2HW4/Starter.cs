﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modul2HW4.Services.Abstractions;
using Modul2HW4.Services;
using Modul2HW4.Models;

namespace Modul2HW4
{
    public class Starter
    {
        private readonly IUIService _iuIService;

        public Starter(IUIService uIService)
        {
            _iuIService = uIService;
        }

        public void Run()
        {
            _iuIService.InfoAboutSafariPark();
            _iuIService.Sort();
            _iuIService.FindAnimal();
        }
    }
}
