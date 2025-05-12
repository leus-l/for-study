using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class ITStudent : Student
    {
        public string direction;
        public ITStudent(string Direction, string Name, int Age) : base(Name, Age)
        {
            direction = Direction;
        }
    }
}
