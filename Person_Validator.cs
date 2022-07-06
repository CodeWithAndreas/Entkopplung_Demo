using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entkopplung_Demo
{
    internal class Person_Validator : IValidator
    {
        public void Validate()
        {
            Console.WriteLine("Person validiert.");
        }

        public void ZeigeAnzahl()
        {
            throw new NotImplementedException();
        }
    }
}
