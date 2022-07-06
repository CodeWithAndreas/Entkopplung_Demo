using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entkopplung_Demo
{
    internal class Program
    {
        //static DB_Parser myParser;
        static IParser myParser;


        static void Main(string[] args)
        {
            myParser = new DB_Parser(new Fahrzeug_Validator());

            myParser.machwas();

            myParser.machwastolles();

            myParser = new XMLParser();

            myParser.machwas();

            myParser.machwastolles();

            Console.ReadLine();
        }
    }
}
