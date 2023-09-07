using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosSolid
{
    public class MiExceptionPersonalizada : Exception
    {
        public MiExceptionPersonalizada(string mensaje) : base()
        {
            Console.WriteLine(mensaje);
        }
    }
}
