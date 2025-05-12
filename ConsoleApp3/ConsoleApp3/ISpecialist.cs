using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal interface ISpecialist : IPerson
    {
        public void Experience();
        void Info();
    }
}
