using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? name = Console.ReadLine();
            int price = Convert.ToInt32(Console.ReadLine());
            int expentionTime = Convert.ToInt32(Console.ReadLine());
            int amount = Convert.ToInt32(Console.ReadLine());
            DateTime DateT = Convert.ToDateTime(Console.ReadLine());

            Product product = new Product(name, price, expentionTime, DateT);
            product.info();
            product.isItSuitable(DateT);
            Batch part = new Batch(amount,DateT,expentionTime,name,price);
            part.info();
            Console.ReadLine();
        }
    }
}
