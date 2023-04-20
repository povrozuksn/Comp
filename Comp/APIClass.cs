using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Comp
{
    public static class APIClass
    {
        public static Dictionary<string, double> vals = new Dictionary<string, double>();

        public static string temper;

        /// <summary>
        /// API курсов валют
        /// </summary>
        public static void Vals()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(
                "https://www.cbr-xml-daily.ru/daily_json.js");

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader sr = new StreamReader(stream);

            string sReadData = sr.ReadToEnd();
            response.Close();

            dynamic d = JsonConvert.DeserializeObject(sReadData);
            string usd = d.Valute.USD.Value.ToString();
            string eur = d.Valute.EUR.Value.ToString();
            string cny = d.Valute.CNY.Value.ToString();

            double Usd = Convert.ToDouble(usd);
            double Eur = Convert.ToDouble(eur);
            double Cny = Convert.ToDouble(cny);

            vals.Add("Рубли", 1);
            vals.Add("Доллары", Usd);
            vals.Add("Евро", Eur);
            vals.Add("Юани", Cny);
        }

        /// <summary>
        /// API курсов валют
        /// </summary>
        public static void Weather()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(
                "https://api.open-meteo.com/v1/forecast?latitude=54.3282&longitude=48.3866&hourly=temperature_2m");

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader sr = new StreamReader(stream);

            string sReadData = sr.ReadToEnd();
            response.Close();

            dynamic w = JsonConvert.DeserializeObject(sReadData);
            temper = w.hourly.temperature_2m[12].ToString();
        }
    }
}
