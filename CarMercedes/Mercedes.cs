using System;
using System.ComponentModel.Composition;
using CarContract;

namespace CarMercedes
{ 
    [Export(typeof(ICarContract))]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class Mercedes : ICarContract
    {
        private Mercedes()
        {
            Console.WriteLine("Mercedes constructor.");
        }
        public string StartEngine(string name)
        {
            return String.Format("{0} starts the Mercedes.", name);
        }
    }
}
