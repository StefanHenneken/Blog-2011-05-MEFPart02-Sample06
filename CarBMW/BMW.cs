using System;
using System.ComponentModel.Composition;
using CarContract;

namespace CarBMW
{
    [Export(typeof(ICarContract))]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class BMW : ICarContract
    {
        private BMW()
        {
            Console.WriteLine("BMW constructor.");
        }
        public string StartEngine(string name)
        {
            return String.Format("{0} starts the BMW.", name);
        }
    }
}
