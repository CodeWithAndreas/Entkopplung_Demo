using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entkopplung_Demo
{
    internal class Fahrzeug_Validator : IValidator
    {
        static private int _anzahlX;

        public Fahrzeug_Validator()
        {
            _anzahlX++;
        }

        public void Validate()
        {
            Console.WriteLine("Fahrzeug validiert.");
        }

        public void ZeigeAnzahl()
        {
            Console.WriteLine(_anzahlX);
        }
        
    }
}
