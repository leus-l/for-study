using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Batch : Product
    {
        int amount;
        public Batch(int amount, DateTime productionDate, int expentionTime, string name, int price) : base (name, price, expentionTime, productionDate)
        {
            this.amount = amount;
        }
        public override void info()
        {
            base.info();
            Console.WriteLine($"Количество {amount}");

        }
    }
}
