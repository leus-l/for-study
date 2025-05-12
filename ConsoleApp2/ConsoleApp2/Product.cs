using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Product : Tovar
    {
        string name;
        int price;
        int expentionTime;
        DateTime productionDate;

        public Product(string name, int price, int expentionTime, DateTime productionDate)
        {
            this.name = name;
            this.price = price;
            this.expentionTime = expentionTime;
            this.productionDate = productionDate;
        }

        public override void info()
        {
            Console.WriteLine($"Имя товара {name}\nСтоимость товра {price}\nСрок годности{expentionTime} \nСрок производства{productionDate}");
        }
        public override bool isItSuitable(DateTime DateT)
        {
            DateTime temp = productionDate.AddDays(expentionTime);
            return !(temp >= DateT && DateT >= productionDate);
        }
    }
}
