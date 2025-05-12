using System;


namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student std = new Student("Вася", 19);
            std.BecomrOlder();
            std.WriteInfo();
            Console.ReadLine();           
        }
    }
}
