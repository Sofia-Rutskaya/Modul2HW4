﻿using System;
using Modul2HW4.Providers;
using Modul2HW4.Providers.Abstractions;
using Modul2HW4.Services;
using Modul2HW4.Services.Abstractions;
using Modul2HW4.Models;

// NuGet Package
using Microsoft.Extensions.DependencyInjection;

namespace Modul2HW4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddTransient<IUIService, UIService>()
                .AddTransient<ICountSpeciesService, CountSpeciesService>()
                .AddSingleton<ISafariParkSectionService, SafariParkSectionService>()
                .AddTransient<ISafariParkProvider, SafariParkProvider>()
                .AddTransient<Starter>()
                .BuildServiceProvider();

            var start = serviceProvider.GetService<Starter>();
            start.Run();
        }
    }
}
