using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using CarContract;

namespace CarHost
{
    class Program
    {
        [ImportMany(typeof(ICarContract), RequiredCreationPolicy = CreationPolicy.NonShared)]
        private IEnumerable<Lazy<ICarContract>> CarPartsA { get; set; }

        [ImportMany(typeof(ICarContract), RequiredCreationPolicy = CreationPolicy.NonShared)]
        private IEnumerable<Lazy<ICarContract>> CarPartsB { get; set; }
       
        static void Main(string[] args)
        {
            new Program().Run();
        }
        void Run()
        {          
            var catalog = new DirectoryCatalog(".");
            var container = new CompositionContainer(catalog);
            container.ComposeParts(this);
            foreach (Lazy<ICarContract> car in CarPartsA)
                Console.WriteLine(car.Value.StartEngine("Sebastian"));
            Console.WriteLine("");
            foreach (Lazy<ICarContract> car in CarPartsB)
                Console.WriteLine(car.Value.StartEngine("Michael"));
            container.Dispose();
        }
    }
}
