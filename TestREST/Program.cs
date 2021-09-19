using System;
using System.IO;
using System.Net;
using System.Text;
using JsonDiffPatchDotNet;
using Newtonsoft.Json.Linq;

namespace TestREST
{
    internal class Program
    {
        public static string json { get; set; }
        public static object Assert { get; private set; }

        private static void Main(string[] args)
        {
            Console.WriteLine("------------------------\n");
            Console.WriteLine("Test REST API \n");
            Console.WriteLine("------------------------\n");

            bool endApp = false;
            while (!endApp)
            {
                // Console.WriteLine("Type the key of the GET method, and then press Enter:\n");
                // string KeyGet = Convert.ToString(Console.ReadLine());
                // Console.WriteLine("\n");

                // Console.WriteLine("Type the value of the GET method, and then press Enter:\n");
                //  string ValueGet = Convert.ToString(Console.ReadLine());
                // Console.WriteLine("\n");
                string BaseUrl = "https://regions-test.2gis.com/1.0/regions?";
                string Params1 = "page=1";
                string Params2 = "page=2";
                string Params3 = "page_size=5";
                string Params4 = "page_size=10";
                string Params5 = "page_size=15";
                string Params6 = "country_code=ru";
                string Params7 = "country_code=kz";
                string Params8 = "country_code=kg";
                string Params9 = "country_code=cz";
                // string Params10 = "q";
                // string Params11 = "";

                Console.WriteLine("Choose the parameters of the request to be sent:");
                Console.WriteLine("\n");
                Console.WriteLine("\t1 - page=1");
                Console.WriteLine("\t2 - page=2");
                Console.WriteLine("\t3 - page_size=5");
                Console.WriteLine("\t4 - page_size=10");
                Console.WriteLine("\t5 - page_size=15");
                Console.WriteLine("\t6 - country_code=ru");
                Console.WriteLine("\t7 - country_code=kz");
                Console.WriteLine("\t8 - country_code=kg");
                Console.WriteLine("\t9 - country_code=cz");
                //  Console.WriteLine("\t10 - ");
                //  Console.WriteLine("\t11 - ");
                Console.WriteLine("\n");
                Console.Write("Your option? ");

                //  HttpWebRequest request = (HttpWebRequest)WebRequest.Create(
                //      "https://regions-test.2gis.com/1.0/regions?" + KeyGet + "=" + ValueGet);

                // HttpWebRequest request = (HttpWebRequest)WebRequest.Create(
                //       "https://regions-test.2gis.com/1.0/regions?" + );
                // HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                //  Stream receiveStream = response.GetResponseStream();
                //  StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8);
                // string json = readStream.ReadToEnd();
                // JObject jobject = JObject.Parse(json);
                // string exmpl = jobject.ToString();
                // Console.WriteLine("------------------------\n");
                // Console.WriteLine("You got a response:\n");
                // Console.WriteLine("------------------------\n");
                //  Console.WriteLine(exmpl);
                //  var jdp = new JsonDiffPatch();
                //  var left = JObject.Parse(@"");
                //  var right = JObject.Parse(json);
                //  JToken result = jdp.Diff(left, right);
                // Assert.IsNotNull(result);
                //  response.Close();
                //  readStream.Close();
                // Console.WriteLine("------------------------\n");
                //  Console.WriteLine("Compare:\n");
                //  Console.WriteLine(result);
                // Console.WriteLine("------------------------\n");

                switch (Console.ReadLine())
                {
                    case "1":
                        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(
                      BaseUrl + Params1);
                        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                        Stream receiveStream = response.GetResponseStream();
                        StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8);
                        string json = readStream.ReadToEnd();
                        JObject jobject = JObject.Parse(json);
                        string exmpl = jobject.ToString();
                        Console.WriteLine("\n");
                        Console.WriteLine("------------------------\n");
                        Console.WriteLine("You got a response:\n");
                        Console.WriteLine("------------------------\n");
                        Console.WriteLine(exmpl);
                        var jdp = new JsonDiffPatch();
                        var left = JObject.Parse(@"{'total': 22, 'items': [{'id': 196, 'name': '\u0410\u043a\u0442\u0430\u0443', 'code': 'aktau', 'country': {'name': '\u041a\u0430\u0437\u0430\u0445\u0441\u0442\u0430\u043d', 'code': 'kz'}}, {'id': 167, 'name': '\u0410\u043a\u0442\u043e\u0431\u0435', 'code': 'aktobe', 'country': {'name': '\u041a\u0430\u0437\u0430\u0445\u0441\u0442\u0430\u043d', 'code': 'kz'}}, {'id': 67, 'name': '\u0410\u043b\u043c\u0430\u0442\u044b', 'code': 'almaty', 'country': {'name': '\u041a\u0430\u0437\u0430\u0445\u0441\u0442\u0430\u043d', 'code': 'kz'}}, {'id': 112, 'name': '\u0411\u0438\u0448\u043a\u0435\u043a', 'code': 'bishkek', 'country': {'name': '\u041a\u044b\u0440\u0433\u044b\u0437\u0441\u0442\u0430\u043d', 'code': 'kg'}}, {'id': 114, 'name': '\u0412\u043b\u0430\u0434\u0438\u043a\u0430\u0432\u043a\u0430\u0437', 'code': 'vladikavkaz', 'country': {'name': '\u0420\u043e\u0441\u0441\u0438\u044f', 'code': 'ru'}}, {'id': 25, 'name': '\u0412\u043b\u0430\u0434\u0438\u0432\u043e\u0441\u0442\u043e\u043a', 'code': 'vladivostok', 'country': {'name': '\u0420\u043e\u0441\u0441\u0438\u044f', 'code': 'ru'}}, {'id': 105, 'name': '\u0414\u043d\u0435\u043f\u0440', 'code': 'dnepropetrovsk', 'country': {'name': '\u0423\u043a\u0440\u0430\u0438\u043d\u0430', 'code': 'ua'}}, {'id': 7, 'name': '\u041a\u0440\u0430\u0441\u043d\u043e\u044f\u0440\u0441\u043a', 'code': 'krasnoyarsk', 'country': {'name': '\u0420\u043e\u0441\u0441\u0438\u044f', 'code': 'ru'}}, {'id': 26, 'name': '\u041c\u0430\u0433\u043d\u0438\u0442\u043e\u0433\u043e\u0440\u0441\u043a', 'code': 'magnitogorsk', 'country': {'name': '\u0420\u043e\u0441\u0441\u0438\u044f', 'code': 'ru'}}, {'id': 32, 'name': '\u041c\u043e\u0441\u043a\u0432\u0430', 'code': 'moscow', 'country': {'name': '\u0420\u043e\u0441\u0441\u0438\u044f', 'code': 'ru'}}]}");
                        var right = JObject.Parse(json);
                        JToken result = jdp.Diff(left, right);
                        // Assert.IsNotNull(result);
                        response.Close();
                        readStream.Close();
                        Console.WriteLine("------------------------\n");
                        Console.WriteLine("Compare:\n");
                        Console.WriteLine(result);
                        Console.WriteLine("------------------------\n");
                        break;

                    case "2":
                        HttpWebRequest request2 = (HttpWebRequest)WebRequest.Create(
                      BaseUrl + Params2);
                        HttpWebResponse response2 = (HttpWebResponse)request2.GetResponse();
                        Stream receiveStream2 = response2.GetResponseStream();
                        StreamReader readStream2 = new StreamReader(receiveStream2, Encoding.UTF8);
                        string json2 = readStream2.ReadToEnd();
                        JObject jobject2 = JObject.Parse(json2);
                        string exmpl2 = jobject2.ToString();
                        Console.WriteLine("------------------------\n");
                        Console.WriteLine("You got a response:\n");
                        Console.WriteLine("------------------------\n");
                        Console.WriteLine(exmpl2);
                        var jdp2 = new JsonDiffPatch();
                        var left2 = JObject.Parse(@"{'total': 22, 'items': [{'id': 32, 'name': '\u041c\u043e\u0441\u043a\u0432\u0430', 'code': 'moscow', 'country': {'name': '\u0420\u043e\u0441\u0441\u0438\u044f', 'code': 'ru'}}, {'id': 19, 'name': '\u041d\u0438\u0436\u043d\u0438\u0439 \u041d\u043e\u0432\u0433\u043e\u0440\u043e\u0434', 'code': 'n_novgorod', 'country': {'name': '\u0420\u043e\u0441\u0441\u0438\u044f', 'code': 'ru'}}, {'id': 1, 'name': '\u041d\u043e\u0432\u043e\u0441\u0438\u0431\u0438\u0440\u0441\u043a', 'code': 'novosibirsk', 'country': {'name': '\u0420\u043e\u0441\u0441\u0438\u044f', 'code': 'ru'}}, {'id': 2, 'name': '\u041e\u043c\u0441\u043a', 'code': 'omsk', 'country': {'name': '\u0420\u043e\u0441\u0441\u0438\u044f', 'code': 'ru'}}, {'id': 71, 'name': '\u041e\u0440\u0451\u043b', 'code': 'orel', 'country': {'name': '\u0420\u043e\u0441\u0441\u0438\u044f', 'code': 'ru'}}, {'id': 171, 'name': '\u041e\u0448', 'code': 'osh', 'country': {'name': '\u041a\u044b\u0440\u0433\u044b\u0437\u0441\u0442\u0430\u043d', 'code': 'kg'}}, {'id': 95, 'name': '\u041f\u0435\u0442\u0440\u043e\u043f\u0430\u0432\u043b\u043e\u0432\u0441\u043a-\u041a\u0430\u043c\u0447\u0430\u0442\u0441\u043a\u0438\u0439', 'code': 'p_kamchatskiy', 'country': {'name': '\u0420\u043e\u0441\u0441\u0438\u044f', 'code': 'ru'}}, {'id': 92, 'name': '\u041f\u0440\u0430\u0433\u0430', 'code': 'praha', 'country': {'name': '\u0427\u0435\u0445\u0438\u044f', 'code': 'cz'}}, {'id': 38, 'name': '\u0421\u0430\u043d\u043a\u0442-\u041f\u0435\u0442\u0435\u0440\u0431\u0443\u0440\u0433', 'code': 'spb', 'country': {'name': '\u0420\u043e\u0441\u0441\u0438\u044f', 'code': 'ru'}}, {'id': 3, 'name': '\u0422\u043e\u043c\u0441\u043a', 'code': 'tomsk', 'country': {'name': '\u0420\u043e\u0441\u0441\u0438\u044f', 'code': 'ru'}}]}");
                        var right2 = JObject.Parse(json2);
                        JToken result2 = jdp2.Diff(left2, right2);
                        // Assert.IsNotNull(result);
                        response2.Close();
                        readStream2.Close();
                        Console.WriteLine("------------------------\n");
                        Console.WriteLine("Compare:\n");
                        Console.WriteLine(result2);
                        Console.WriteLine("------------------------\n");
                        break;

                    case "5":
                        HttpWebRequest request5 = (HttpWebRequest)WebRequest.Create(
                      BaseUrl + Params5);
                        HttpWebResponse response5 = (HttpWebResponse)request5.GetResponse();
                        Stream receiveStream5 = response5.GetResponseStream();
                        StreamReader readStream5 = new StreamReader(receiveStream5, Encoding.UTF8);
                        string json5 = readStream5.ReadToEnd();
                        JObject jobject5 = JObject.Parse(json5);
                        string exmpl5 = jobject5.ToString();
                        Console.WriteLine("------------------------\n");
                        Console.WriteLine("You got a response:\n");
                        Console.WriteLine("------------------------\n");
                        Console.WriteLine(exmpl5);
                        var jdp5 = new JsonDiffPatch();
                        var left5 = JObject.Parse(@"{'total': 22, 'items': [{'id': 196, 'name': '\u0410\u043a\u0442\u0430\u0443', 'code': 'aktau', 'country': {'name': '\u041a\u0430\u0437\u0430\u0445\u0441\u0442\u0430\u043d', 'code': 'kz'}}, {'id': 167, 'name': '\u0410\u043a\u0442\u043e\u0431\u0435', 'code': 'aktobe', 'country': {'name': '\u041a\u0430\u0437\u0430\u0445\u0441\u0442\u0430\u043d', 'code': 'kz'}}, {'id': 67, 'name': '\u0410\u043b\u043c\u0430\u0442\u044b', 'code': 'almaty', 'country': {'name': '\u041a\u0430\u0437\u0430\u0445\u0441\u0442\u0430\u043d', 'code': 'kz'}}, {'id': 112, 'name': '\u0411\u0438\u0448\u043a\u0435\u043a', 'code': 'bishkek', 'country': {'name': '\u041a\u044b\u0440\u0433\u044b\u0437\u0441\u0442\u0430\u043d', 'code': 'kg'}}, {'id': 114, 'name': '\u0412\u043b\u0430\u0434\u0438\u043a\u0430\u0432\u043a\u0430\u0437', 'code': 'vladikavkaz', 'country': {'name': '\u0420\u043e\u0441\u0441\u0438\u044f', 'code': 'ru'}}, {'id': 25, 'name': '\u0412\u043b\u0430\u0434\u0438\u0432\u043e\u0441\u0442\u043e\u043a', 'code': 'vladivostok', 'country': {'name': '\u0420\u043e\u0441\u0441\u0438\u044f', 'code': 'ru'}}, {'id': 105, 'name': '\u0414\u043d\u0435\u043f\u0440', 'code': 'dnepropetrovsk', 'country': {'name': '\u0423\u043a\u0440\u0430\u0438\u043d\u0430', 'code': 'ua'}}, {'id': 7, 'name': '\u041a\u0440\u0430\u0441\u043d\u043e\u044f\u0440\u0441\u043a', 'code': 'krasnoyarsk', 'country': {'name': '\u0420\u043e\u0441\u0441\u0438\u044f', 'code': 'ru'}}, {'id': 26, 'name': '\u041c\u0430\u0433\u043d\u0438\u0442\u043e\u0433\u043e\u0440\u0441\u043a', 'code': 'magnitogorsk', 'country': {'name': '\u0420\u043e\u0441\u0441\u0438\u044f', 'code': 'ru'}}, {'id': 32, 'name': '\u041c\u043e\u0441\u043a\u0432\u0430', 'code': 'moscow', 'country': {'name': '\u0420\u043e\u0441\u0441\u0438\u044f', 'code': 'ru'}}, {'id': 19, 'name': '\u041d\u0438\u0436\u043d\u0438\u0439 \u041d\u043e\u0432\u0433\u043e\u0440\u043e\u0434', 'code': 'n_novgorod', 'country': {'name': '\u0420\u043e\u0441\u0441\u0438\u044f', 'code': 'ru'}}, {'id': 1, 'name': '\u041d\u043e\u0432\u043e\u0441\u0438\u0431\u0438\u0440\u0441\u043a', 'code': 'novosibirsk', 'country': {'name': '\u0420\u043e\u0441\u0441\u0438\u044f', 'code': 'ru'}}, {'id': 2, 'name': '\u041e\u043c\u0441\u043a', 'code': 'omsk', 'country': {'name': '\u0420\u043e\u0441\u0441\u0438\u044f', 'code': 'ru'}}, {'id': 71, 'name': '\u041e\u0440\u0451\u043b', 'code': 'orel', 'country': {'name': '\u0420\u043e\u0441\u0441\u0438\u044f', 'code': 'ru'}}, {'id': 142, 'name': '\u041e\u0440\u0441\u043a', 'code': 'orsk', 'country': {'name': '\u0420\u043e\u0441\u0441\u0438\u044f', 'code': 'ru'}}]}");
                        var right5 = JObject.Parse(json5);
                        JToken result5 = jdp5.Diff(left5, right5);
                        // Assert.IsNotNull(result);
                        response5.Close();
                        readStream5.Close();
                        Console.WriteLine("------------------------\n");
                        Console.WriteLine("Compare:\n");
                        Console.WriteLine(result5);
                        Console.WriteLine("------------------------\n");
                        break;
                }

                Console.Write("Press 'n' and Enter to close the app, or press any other key and Enter to continue: ");
                if (Console.ReadLine() == "n") endApp = true;

                Console.WriteLine("\n");
            }
            return;
        }
    }
}
