using System;
using System.Net.Http;
using System.Net;
using System.Text;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Linq;

namespace TestREST
{
    class Program
    {
        public static string json { get; set; }

        static void Main(string[] args)
        {
            Console.WriteLine("------------------------\n");
            Console.WriteLine("Test REST API \n");
            Console.WriteLine("------------------------\n");

            Console.WriteLine("Type the key of the GET method, and then press Enter:\n");
            string KeyGet = Convert.ToString(Console.ReadLine());
            Console.WriteLine("\n");

            Console.WriteLine("Type the value of the GET method, and then press Enter:\n");
            string ValueGet = Convert.ToString(Console.ReadLine());
            Console.WriteLine("\n");

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(
                "https://regions-test.2gis.com/1.0/regions?" + KeyGet + "=" + ValueGet);

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            Stream receiveStream = response.GetResponseStream();

            StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8);

          

            string json = readStream.ReadToEnd();

            JObject jobject = JObject.Parse(json);

            string exmpl = jobject.ToString();

           

            Console.WriteLine("------------------------\n");
            Console.WriteLine("You got a response:\n");
            Console.WriteLine("------------------------\n");
           
            Console.WriteLine(exmpl);
            
            response.Close();
            readStream.Close();




        }
    }
}
