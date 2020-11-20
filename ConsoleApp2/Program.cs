using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classesBasics
{


     class car
    {

       public string Model;
       public string Color;
       public int year;

        public void StartEngine()
        {
            Console.WriteLine(Model + "----Engine started-------");
        }

    }
    class Program
    {
        //static void Main(string[] args)
        //{
        //    //object for car class
        //    car ford = new car();

        //    ford.Model = "Mustang";
        //    ford.Color = "red";
        //    ford.year = 1993;

        //    car audi = new car();

        //    audi.Model = "Q5";
        //    audi.Color = "yellow";
        //    audi.year = 1990;


        //    Console.WriteLine(ford.Color);
        //    Console.WriteLine(audi.Color);

        //    ford.StartEngine();
        //    audi.StartEngine();
        //    Console.ReadLine();

        //}
    }
}
