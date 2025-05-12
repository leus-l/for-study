using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    abstract class Tovar
    {
        public abstract void info();
        public abstract bool isItSuitable(DateTime DateT);
    }
   
}
