using ConsoleApp2;
using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Net.Http.Headers;
using System.Text;

internal class Program
{
    static void Main(string[] a)
    {
        //Console.WriteLine("Poin 1: ");
        //Console.WriteLine();
        //Point dot = new Point(10, 10);
        //dot.seeCord();
        //dot.cordFromBegin();
        //Console.WriteLine("Введите новую координату x");
        //int newX = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Введите новую координату y");
        //int newY = Convert.ToInt32(Console.ReadLine());
        //dot.setPoint(ref newX, ref newY);
        //dot.seeCord();
        //Console.WriteLine();
        //Console.WriteLine("============");
        //Console.WriteLine();
        //Console.WriteLine("Poin 2: ");
        //Console.WriteLine();

        //Point dot1 = new Point();
        //dot1.seeCord();
        //try
        //{
        //    Console.WriteLine("Введите координаты x");
        //    dot1.newCordx = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Введите координаты y");
        //    dot1.newCordy = Convert.ToInt32(Console.ReadLine());
        //    dot1.seeCord();
        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine(ex.Message);
        //}
        //dot1.umnX = dot1.newCordx;
        //dot1.umnY = dot1.newCordy;
        //dot1.seeCord();
        //int index = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine(dot1[index]);
        //Console.ReadLine();

        Point dot2 = new Point();
        dot2.newCordx = Convert.ToInt32(Console.ReadLine());
        dot2.newCordy= Convert.ToInt32(Console.ReadLine());
        dot2.seeCord();
        dot2++;
        dot2.seeCord();

    }
}