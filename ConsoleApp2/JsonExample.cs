using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace ConsoleApp2
{
    class JsonExample
    {


        static void Main()
        {

            using (StreamReader r = new StreamReader("C:/Users/kisho/OneDrive/Desktop/outputcheck/input.json")) {

                string inputData = r.ReadToEnd();

                List<inputDataClass> inputList = JsonConvert.DeserializeObject<List<inputDataClass>>(inputData);           
            }

            Console.ReadLine();
        }
    }

   public class inputDataClass
    {

        public int millis;
        public string stamp;
        public DateTime datetime;
        public int light;
        public float temp;
        public float vcc;

    }
}
