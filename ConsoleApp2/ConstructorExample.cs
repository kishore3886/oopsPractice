using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    class car
    {

        public string Model;
        public string Color;
        public int year;

        public car(string mod,string col, int yr )
        {
            Model = mod;
            Color = col;
            year = yr;
              
        }

        public void StartEngine()
        {
            Console.WriteLine(Model + "----Engine started-------");
        }

    }
    class ConstructorExample
    {

        //public static void Main()
        //{

        //    car ford = new car(" Mustang","red",1993);

        //    ford.StartEngine();


        //    Console.ReadLine();
        //}


    }
}
