using System;
using System.Collections;
using Conditionals;
using Loops;
using Inheritance;


namespace Console.UI
{
    class Program
    {
        static void Main(string[] args)
        {

            var p1 = new Perro(11, "Puchi");
            var p2 = new Perro(10, "Tyra");
            var p3 = new Perro();
            var p4 = new Perro() { Name = "Coco"};
            System.Console.WriteLine(p1.Bark());
            System.Console.WriteLine(p2.Bark());
            p3.Name = "Sushi";
            

            System.Console.WriteLine(p3.Bark());
            System.Console.WriteLine(p4.Bark());
            
        }
    }
}
