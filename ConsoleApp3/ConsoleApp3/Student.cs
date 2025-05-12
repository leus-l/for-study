using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Student : ISpecialist
    {
        string name;
        public int age;
        Subject subject;
        public Student(string Name)
        {
            name = Name;
        }
        public Student(string Name, int Age)
        {
            name = Name;
            age = Age;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public void WriteInfo()
        {
            Console.WriteLine($"Имя: {name} \nВозраст: {age}");
        }
        public int BecomrOlder()
        {
            return this.age++;
        }
        public override string ToString()
        {
            return name;
        }
        void ISpecialist.Info()
        {
            Console.WriteLine("ISpecialist");
        }
        void IPerson.Info()
        {
            Console.WriteLine("IPerson");
        }
        public void Experience()
        {
            Console.WriteLine("Exp");
        }
    }
}
