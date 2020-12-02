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


            //using (StreamReader r = new StreamReader("C:/Users/kisho/OneDrive/Desktop/outputcheck/input.json") )
            //{

            //    string ipd = r.ReadToEnd();

            //    List<inputDataClass> ipdlist = JsonConvert.DeserializeObject<List<inputDataClass>>(ipd);


            //}



            using (StreamReader r = new StreamReader("C:/Users/kisho/OneDrive/Desktop/outputcheck/input.json"))
            {

                string inputData = r.ReadToEnd();

                List<inputDataClass> inputList = JsonConvert.DeserializeObject<List<inputDataClass>>(inputData);

                Console.WriteLine("Read hte data");

                //print the data
                int i = 0;
                foreach(inputDataClass data in inputList  )
                {
                    Console.WriteLine(i);
                    i++;
                    Console.WriteLine(data.CostCentre + " " + data.CostCentreName);

                }

                //finding the workorders 11010-2-1,11101-1-1,11102-6-1

                foreach (inputDataClass data in inputList)
                {

                    if(data.WorkOrder== "11010-2-1" | data.WorkOrder== "11101-1-1" | data.WorkOrder== "11102 - 6 - 1")
                    {
                        //before changing cost centre
                        Console.WriteLine(" Before changing " +data.CostCentre + " " + data.CostCentreName);


                        data.CostCentre = "2011";

                        //after changing cost centre

                        Console.WriteLine(" After changing " + data.CostCentre + " " + data.CostCentreName);

                    }

                }

                //serialize this input list into inputDataClass and write it back to json.

                //foreach (inputDataClass ip in inputList)
                //{

                //    Console.WriteLine(" in millis " + ip.test + "stamp is " + ip.stamp + " and the date is " + ip.datetime);

                //    if (ip.test == 50)
                //    {

                //    }
                //    else if (ip.test == 100)
                //    {

                //    }
                //    else
                //    {



                //    }
                //}



            }

            Console.ReadLine();
        }
    }

   public class inputDataClass
    {
        //[JsonProperty ( "millis") ]
        //public int test;
        //public string stamp;
        //public DateTime datetime;
        //public int light;
        //public float temp;
        //public float vcc;

        public string Dvision;
        [JsonProperty("Cost Centre #")]
        public string CostCentre;

        [JsonProperty("Cost Centre Name")]

        public string CostCentreName;
        public string Project;

        [JsonProperty("Project Name")]

        public string ProjectName;

        [JsonProperty("Work Order #")]
        public string WorkOrder;

        [JsonProperty("Work Order Name")]

        public string WorkOrderName;

        [JsonProperty("Tax Rule")]

        public string TaxRule;


    }
}
