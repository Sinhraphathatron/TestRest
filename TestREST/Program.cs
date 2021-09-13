using System;
using System.Net.Http;
using System.Net;
using System.Text;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace TestREST
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Test REST API 2gis\r");
            Console.WriteLine("------------------------\n");

            Console.WriteLine("Type the key of the GET method, and then press Enter");
            string KeyGet = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Type the value of the GET method, and then press Enter");
            string ValueGet = Convert.ToString(Console.ReadLine());

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(
                "https://regions-test.2gis.com/1.0/regions?" + KeyGet + "=" + ValueGet);

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            Stream receiveStream = response.GetResponseStream();

            StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8);
           // string jsonString = JsonSerializer.Serialize(readStream.ReadToEnd());

            Console.WriteLine("------------------------\n");
            Console.WriteLine("You got an response");
            Console.WriteLine("------------------------\n");
            //Console.WriteLine(jsonString);
            Console.WriteLine(readStream.ReadToEnd());
            response.Close();
            readStream.Close();

        }
    }
}
