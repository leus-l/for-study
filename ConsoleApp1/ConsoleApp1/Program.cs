using System;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Media;
using System.Security.Cryptography;
using System.Threading;
using System.Xml.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("введите x");
            //double x = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("введите y");
            //double y = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("введите опреацию +, -, /, *, sqrt, pow, log");
            //string a = Console.ReadLine();
            //switch (a)
            //{ 
            //    case "+":
            //    Console.WriteLine(x + y);
            //        break;
            //    case "-":
            //        Console.WriteLine(x - y);
            //        break;
            //    case "/":
            //        Console.WriteLine(x / y);
            //        break;
            //    case "*":
            //        Console.WriteLine(x * y);
            //        break;
            //    case "sqrt":
            //        Console.WriteLine( Math.Sqrt(x));
            //        Console.WriteLine( Math.Sqrt(y));
            //        break;
            //    case "pow":
            //        Console.WriteLine("введите степень");
            //        double p = Convert.ToDouble(Console.ReadLine());
            //        Console.WriteLine(Math.Pow(x, p));
            //        Console.WriteLine(Math.Pow(y, p));
            //        break;
            //    case "log":
            //        Console.WriteLine("введите основание");
            //        double o = Convert.ToDouble(Console.ReadLine());
            //        Console.WriteLine(Math.Log(x, o));
            //        Console.WriteLine(Math.Log(y, o));
            //        break;                  
            //    default:
            //        Console.WriteLine("такой операции нет");
            //        break;
            //}
            //Console.ReadKey();

            //int a = Convert.ToInt32(Console.ReadLine());

            //for (int i = 0; i < a; i++)
            //{
            //    Console.Write("#");

            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("#");
            //    }
            //    Console.WriteLine();
            //}

            //for (int i = a; i > 0; i--)
            //{
            //    Console.Write("#");

            //    for (int j = i; j >= 2; j--)
            //    {
            //        Console.Write("#");
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadLine();

            //int[] a = new int[100];
            //Random rnd = new Random();
            //int min = 100 * 100;

            //for (int i = 1; i < a.Length; i++)
            //{
            //    a[i] = rnd.Next(1000);
            //    if (a[i] < min)
            //    {
            //        min = a[i];
            //    }

            //    Console.Write(a[i] + "\t");
            //}
            //Console.WriteLine();
            //Console.WriteLine("min: " + min);
            //Console.ReadLine();

            //int[,] array = new int[3, 3];
            //Random random = new Random();
            //int width = array.GetLength(1);

            //for (int i = 0; i < array.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array.GetLength(1); j++)
            //    {
            //        array[i,j] = random.Next(10);
            //    }
            //}
            //for (int i = 0; i < array.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array.GetLength(1); j++)
            //    {
            //        Console.Write(array[i,j]);
            //    }
            //    Console.WriteLine();
            //}

            //for (int i = 0; i < array.GetLength(0); i++)
            //{             
            //    Console.WriteLine(array[i, width - i - 1]);  
            //}
            //Console.ReadLine();

            //int[,] array = new int[3,3];
            //Random random = new Random();
            //int str = array.GetLength(0);
            //int sum;

            //for (int i = 0; i < array.GetLength(0); i++)
            //{
            //    for  (int j = 0; j < array.GetLength(1); j++)
            //    {
            //        array[i, j] = random.Next(-3, 3);
            //    }
            //}
            //for (int i = 0; i < array.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array.GetLength(1); j++)
            //    {
            //        Console.Write(array[i,j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            //for (int i = 0; i < array.GetLength(0); i++)
            //{
            //    sum = 0;
            //    for (int j = 0; j < array.GetLength(1); j++)
            //    {
            //        if (array[i, j] >= 0)
            //        {
            //            sum++;
            //            if (sum >= 3)
            //            {
            //                Console.Write("str");
            //                break;
            //            }
            //        }

            //    }
            //}
            //Console.ReadLine();

            //int[] mas = new int[32];
            //Random random = new Random();
            //int i;

            //for (i = 0; i < mas.Length; i++)
            //{
            //    mas[i] = random.Next(33);
            //}
            //for (i = 0; i < mas.Length; i++)
            //{
            //    Console.Write(mas[i] + " ");
            //}
            //Console.WriteLine();

            //addElement(ref mas);
            //foreach (var ma in mas)
            //{
            //    Console.Write(ma + " ");
            //}
            //Console.ReadKey();

            //Resize(ref mas);
            //foreach (var ms in mas)
            //{
            //    Console.Write(ms + " ");
            //}
            //Console.ReadKey();


            //int Index = FindIndex(i, mas);
            //if (Index != 0)
            //{
            //    Console.WriteLine(Index);
            //}

            //Console.ReadKey();

            int a = Convert.ToInt32(Console.ReadLine());
            int b = Foo(a);
            Console.WriteLine(b);
            Console.ReadKey();

        }
        //static int FindIndex(int i, int [] mas )
        //{
        //    int number = Convert.ToInt32(Console.ReadLine());
        //    for (i = 0; i < mas.Length; i++)
        //    {
        //        if (number == mas[i])
        //        {
        //            Console.Write($"идекс числа {number} равен: ");
        //            return i;
        //        }
        //        if (number > mas.Length)
        //        {
        //            Console.WriteLine("число не входит в массив");
        //            break;
        //        }
        //    }
        //    return i;
        //}
        
        //static void Resize(ref int[] mas)
        //{
        //    int newSize  = Convert.ToInt32(Console.ReadLine());
        //    int[] mas1 = new int[newSize];
        //    for ( int i = 0;i < mas1.Length;i++)
        //    {
        //        if (i < mas.Length)
        //        {
        //            mas1[i] = mas[i];
        //        }
        //        else
        //        {
        //            mas1[i] = 0;
        //        }
        //    }
        //    mas = mas1;
        //}

        //static void addElement(ref int[] mas)
        //{
        //    int value = Convert.ToInt32(Console.ReadLine());
        //    int index = Convert.ToInt32(Console.ReadLine());
        //    int[] newMas = new int[mas.Length + 1];
        //    newMas[index] = value;
        //    for (int i = 0; i < index; i++)
        //    {
        //        newMas[i] = mas[i];
        //    }
        //    for (int i = index; i < mas.Length; i++)
        //    {
        //        newMas[i + 1] = mas[i];
        //    }
        //    mas = newMas;
        //}

        static int Foo(int a)
        {
            if (a < 10)
            {
                return a;
            }
            int ln = a % 10;
            int mn = a / 10;
            return ln + Foo(mn);
        }
    }
}