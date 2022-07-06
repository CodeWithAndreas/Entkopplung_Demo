using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entkopplung_Demo
{
    internal class DB_Parser : IParser
    {
        public IValidator myValidator { get; set; }

        public DB_Parser(IValidator t_Validator)
        {
            myValidator = t_Validator;
        }
        public void machwas()
        {
            myValidator.Validate();
            myValidator.ZeigeAnzahl();
            Console.WriteLine("DB Parser macht was.");
        }

        public void machwastolles()
        {
            myValidator.Validate();
            myValidator.ZeigeAnzahl();
            Console.WriteLine("DB Parser macht was tolles.");
        }
    }
}
