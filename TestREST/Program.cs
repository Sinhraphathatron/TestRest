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
using JsonDiffPatchDotNet;

namespace TestREST
{
    class Program

    {

        private const string BaseUrl = "https://regions-test.2gis.com/1.0/regions?";
        public static string json { get; set; }
        public static object Assert { get; private set; }
        static void Main(string[] args)

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
                //  Console.WriteLine("\t10 - q");
                //  Console.WriteLine("\t11 - ");
                Console.WriteLine("\n");
                Console.Write("Your option? ");
                //int num = 0;
                //CompareResponse(Params[num], str[num]);
                switch (Console.ReadLine())
                {
                    case "1":
                        {
                            string Params = "page=1";
                            var compareStr = @"{ 'total': 22,'items': [{ 'id': 196,'name': 'Актау','code': 'aktau','country': { 'name': 'Казахстан','code': 'kz'} },{ 'id': 167,'name': 'Актобе','code': 'aktobe','country': { 'name': 'Казахстан','code': 'kz'} },{ 'id': 67,'name': 'Алматы','code': 'almaty','country': { 'name': 'Казахстан','code': 'kz'} },{ 'id': 112,'name': 'Бишкек','code': 'bishkek','country': { 'name': 'Кыргызстан','code': 'kg'} },{ 'id': 114,'name': 'Владикавказ','code': 'vladikavkaz','country': { 'name': 'Россия','code': 'ru'} },{ 'id': 25,'name': 'Владивосток','code': 'vladivostok','country': { 'name': 'Россия','code': 'ru'} },{ 'id': 105,'name': 'Днепр','code': 'dnepropetrovsk','country': { 'name': 'Украина','code': 'ua'} },{ 'id': 7,'name': 'Красноярск','code': 'krasnoyarsk','country': { 'name': 'Россия','code': 'ru'} },{ 'id': 26,'name': 'Магнитогорск','code': 'magnitogorsk','country': { 'name': 'Россия','code': 'ru'} },{ 'id': 32,'name': 'Москва','code': 'moscow','country': { 'name': 'Россия','code': 'ru'} },{ 'id': 19,'name': 'Нижний Новгород','code': 'n_novgorod','country': { 'name': 'Россия','code': 'ru'} },{ 'id': 1,'name': 'Новосибирск','code': 'novosibirsk','country': { 'name': 'Россия','code': 'ru'} },{ 'id': 2,'name': 'Омск','code': 'omsk','country': { 'name': 'Россия','code': 'ru'} },{ 'id': 71,'name': 'Орёл','code': 'orel', 'country' : { 'name': 'Россия','code': 'ru'} },{ 'id': 142,'name': 'Орск','code': 'orsk','country': { 'name': 'Россия','code': 'ru'} }]}
                            ";
                            CompareResponse(Params, compareStr);
                        }
                        break;

                    case "2":
                        {
                            string Params = "page=2";
                            var compareStr = @"{ 'total': 22,'items': [{ 'id': 142,'name': 'Орск','code': 'orsk','country': { 'name': 'Россия','code': 'ru'} },{ 'id': 171,'name': 'Ош','code': 'osh','country': { 'name': 'Кыргызстан','code': 'kg'} },{ 'id': 95,'name': 'Петропавловск-Камчатский','code': 'p_kamchatskiy','country': { 'name': 'Россия','code': 'ru'} },{ 'id': 92,'name': 'Прага','code': 'praha','country': { 'name': 'Чехия','code': 'cz'} },{ 'id': 38,'name': 'Санкт-Петербург','code': 'spb','country': { 'name': 'Россия','code': 'ru'} },{ 'id': 3,'name': 'Томск','code': 'tomsk','country': { 'name': 'Россия','code': 'ru'} },{ 'id': 91,'name': 'Усть-Каменогорск','code': 'ustkam','country': { 'name': 'Казахстан','code': 'kz'} },{ 'id': 17,'name': 'Уфа','code': 'ufa','country': { 'name': 'Россия','code': 'ru'} }]}";
                            CompareResponse(Params, compareStr);
                        }
                        break;

                    case "3":
                        {
                            string Params = "page_size=5";
                            var compareStr = @"{'total': 22,'items': [{'id': 196,'name': 'Актау','code': 'aktau','country': {'name': 'Казахстан','code': 'kz'}},{'id': 167,'name': 'Актобе','code': 'aktobe','country': {'name': 'Казахстан','code': 'kz'}},{'id': 67,'name': 'Алматы','code': 'almaty','country': {'name': 'Казахстан','code': 'kz'}},{'id': 112,'name': 'Бишкек','code': 'bishkek','country': {'name': 'Кыргызстан','code': 'kg'}},{'id': 114,'name': 'Владикавказ','code': 'vladikavkaz','country': {'name': 'Россия','code': 'ru'}}]}";
                            CompareResponse(Params, compareStr);
                        }
                        break;

                    case "4":
                        {
                            string Params = "page_size=10";
                            var compareStr = @"{'total': 22,'items': [{'id': 196,'name': 'Актау','code': 'aktau','country': {'name': 'Казахстан','code': 'kz'}},{'id': 167,'name': 'Актобе','code': 'aktobe','country': {'name': 'Казахстан','code': 'kz'}},{'id': 67,'name': 'Алматы','code': 'almaty','country': {'name': 'Казахстан','code': 'kz'}},{'id': 112,'name': 'Бишкек','code': 'bishkek','country': {'name': 'Кыргызстан','code': 'kg'}},{'id': 114,'name': 'Владикавказ','code': 'vladikavkaz','country': {'name': 'Россия','code': 'ru'}},{'id': 25,'name': 'Владивосток','code': 'vladivostok','country': {'name': 'Россия','code': 'ru'}},{'id': 105,'name': 'Днепр','code': 'dnepropetrovsk','country': {'name': 'Украина','code': 'ua'}},{'id': 7,'name': 'Красноярск','code': 'krasnoyarsk','country': {'name': 'Россия','code': 'ru'}},{'id': 26,'name': 'Магнитогорск','code': 'magnitogorsk','country': {'name': 'Россия','code': 'ru'}},{'id': 32,'name': 'Москва','code': 'moscow','country': {'name': 'Россия','code': 'ru'}}]}";
                            CompareResponse(Params, compareStr);
                        }
                        break;

                    case "5":
                        {
                            string Params = "page_size=15";
                            var compareStr = @"{ 'total': 22,'items': [{ 'id': 196,'name': 'Актау','code': 'aktau','country': { 'name': 'Казахстан','code': 'kz'} },{ 'id': 167,'name': 'Актобе','code': 'aktobe','country': { 'name': 'Казахстан','code': 'kz'} },{ 'id': 67,'name': 'Алматы','code': 'almaty','country': { 'name': 'Казахстан','code': 'kz'} },{ 'id': 112,'name': 'Бишкек','code': 'bishkek','country': { 'name': 'Кыргызстан','code': 'kg'} },{ 'id': 114,'name': 'Владикавказ','code': 'vladikavkaz','country': { 'name': 'Россия','code': 'ru'} },{ 'id': 25,'name': 'Владивосток','code': 'vladivostok','country': { 'name': 'Россия','code': 'ru'} },{ 'id': 105,'name': 'Днепр','code': 'dnepropetrovsk','country': { 'name': 'Украина','code': 'ua'} },{ 'id': 7,'name': 'Красноярск','code': 'krasnoyarsk','country': { 'name': 'Россия','code': 'ru'} },{ 'id': 26,'name': 'Магнитогорск','code': 'magnitogorsk','country': { 'name': 'Россия','code': 'ru'} },{ 'id': 32,'name': 'Москва','code': 'moscow','country': { 'name': 'Россия','code': 'ru'} },{ 'id': 19,'name': 'Нижний Новгород','code': 'n_novgorod','country': { 'name': 'Россия','code': 'ru'} },{ 'id': 1,'name': 'Новосибирск','code': 'novosibirsk','country': { 'name': 'Россия','code': 'ru'} },{ 'id': 2,'name': 'Омск','code': 'omsk','country': { 'name': 'Россия','code': 'ru'} },{ 'id': 71,'name': 'Орёл','code': 'orel', 'country' : { 'name': 'Россия','code': 'ru'} },{ 'id': 142,'name': 'Орск','code': 'orsk','country': { 'name': 'Россия','code': 'ru'} }]}";
                            CompareResponse(Params, compareStr);
                        }
                        break;

                    case "6":
                        {
                            string Params = "country_code=ru";
                            var compareStr = @"{ 'total': 22,'items': [{ 'id': 114,'name': 'Владикавказ','code': 'vladikavkaz','country': { 'name': 'Россия','code': 'ru'} },{ 'id': 25,'name': 'Владивосток','code': 'vladivostok','country': { 'name': 'Россия','code': 'ru'} },{ 'id': 7,'name': 'Красноярск','code': 'krasnoyarsk','country': { 'name': 'Россия','code': 'ru'} },{ 'id': 26,'name': 'Магнитогорск','code': 'magnitogorsk','country': { 'name': 'Россия','code': 'ru'} },{ 'id': 32,'name': 'Москва','code': 'moscow','country': { 'name': 'Россия','code': 'ru'} },{ 'id': 19,'name': 'Нижний Новгород','code': 'n_novgorod','country': { 'name': 'Россия','code': 'ru'} },{ 'id': 1,'name': 'Новосибирск','code': 'novosibirsk','country': { 'name': 'Россия','code': 'ru'} },{ 'id': 2,'name': 'Омск','code': 'omsk','country': { 'name': 'Россия','code': 'ru'} },{ 'id': 71,'name': 'Орёл','code': 'orel','country': { 'name': 'Россия','code': 'ru'} },{ 'id': 142,'name': 'Орск','code': 'orsk','country': { 'name': 'Россия','code': 'ru'} },{ 'id': 95,'name': 'Петропавловск-Камчатский','code': 'p_kamchatskiy','country': { 'name': 'Россия','code': 'ru'} },{ 'id': 38,'name': 'Санкт-Петербург','code': 'spb','country': { 'name': 'Россия','code': 'ru'} },{ 'id': 3,'name': 'Томск','code': 'tomsk','country': { 'name': 'Россия','code': 'ru'} },{ 'id': 17,'name': 'Уфа','code': 'ufa','country': { 'name': 'Россия','code': 'ru'} }]}
                            ";
                            CompareResponse(Params, compareStr);
                        }
                        break;

                    case "7":
                        {
                            string Params = "country_code=kz";
                            var compareStr = @"{'total': 22,'items': [{'id': 196,'name': 'Актау','code': 'aktau','country': {'name': 'Казахстан','code': 'kz'}},{'id': 167,'name': 'Актобе','code': 'aktobe','country': {'name': 'Казахстан','code': 'kz'}},{'id': 67,'name': 'Алматы','code': 'almaty','country': {'name': 'Казахстан','code': 'kz'}},{'id': 91,'name': 'Усть-Каменогорск','code': 'ustkam','country': {'name': 'Казахстан','code': 'kz'}}]}";
                            CompareResponse(Params, compareStr);
                        }
                        break;

                    case "8":
                        {
                            string Params = "country_code=kg";
                            var compareStr = @"{'total': 22,'items': [{'id': 112,'name': 'Бишкек','code': 'bishkek','country': {'name': 'Кыргызстан','code': 'kg'}},{'id': 171,'name': 'Ош','code': 'osh','country': {'name': 'Кыргызстан','code': 'kg'}}]}";
                            CompareResponse(Params, compareStr);
                        }
                        break;

                    case "9":
                        {
                            string Params = "country_code=cz";
                            var compareStr = @"{'total': 22,'items': [{'id': 92,'name': 'Прага','code': 'praha','country': {'name': 'Чехия','code': 'cz'}}]}";
                            CompareResponse(Params, compareStr);
                        }
                        break;

                }
                Console.Write("Press 'n' and Enter to close the app, or press any other key and Enter to continue: ");
                if (Console.ReadLine() == "n") endApp = true;

                Console.WriteLine("\n");
            }
            return;



        }

        private static void CompareResponse(string Params, string compareStr)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(BaseUrl + Params);
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
            var left = JObject.Parse(compareStr);
            var right = JObject.Parse(json);
            JToken result = jdp.Diff(left, right);
            // Assert.IsNotNull(result);
            response.Close();
            readStream.Close();
            Console.WriteLine("------------------------\n");
            Console.WriteLine("Compare:\n");
            Console.WriteLine(result);
            Console.WriteLine("------------------------\n");
        }
    }
}
