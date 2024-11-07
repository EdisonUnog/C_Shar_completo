using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class BackLogException : Exception
    { 
        public BackLogException() : base()
        { }
        public BackLogException(string mensaje) : base(mensaje) 
        { 
        }
        public BackLogException(string message, Exception innerExeption) : base(message, innerExeption)
        {

        }
    }
}
