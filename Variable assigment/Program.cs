using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variable_assigment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //North
            int number = 29;
            double price = 2.99, area;
            string yeah = "I am learing a bit about computer science!";
            string name;
            int grad;
            int radius;
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("This is room #" + number);
            Console.WriteLine("the price is " + price.ToString("c"));
            Console.WriteLine(yeah);
            Console.WriteLine();
            Console.WriteLine("press Enter to Continue");
            Console.ReadLine();
            name = "North Harrington";
            grad = 2026;
            Console.WriteLine("my name is " + name + " and ill graduate in " + grad);
            radius = 8;
            area = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine(Math.Round(area, 1));
           

            
            
             
                
        }
    }
}
