using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entkopplung_Demo
{
    internal class XMLParser : IParser
    {
        public void machwas()
        {
            Console.WriteLine("XML Parser macht was.");
        }

        public void machwastolles()
        {
            Console.WriteLine("XML Parser macht was tolles.");
        }
    }
}
