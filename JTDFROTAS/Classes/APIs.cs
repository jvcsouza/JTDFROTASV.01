using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using Newtonsoft.Json;
using System.Text.RegularExpressions;

namespace JTDFROTAS.Classes
{
    class APIs
    {
        private static WebClient WCliente = new WebClient();
        private static void coders()
        {
            WCliente.Encoding = Encoding.UTF8;
            WCliente.Headers.Add("user-agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.169 Safari/537.36");
            WCliente.Headers.Add("accept-language", "pt-BR,pt;q=0.9,en-US;q=0.8,en;q=0.7");
        }

        public static ReceitaApi consultaCNPJ(String cnpj)
        {
            coders();
            cnpj = Regex.Replace(cnpj, "[^0-9]", "");
            String json = WCliente.DownloadString($"https://www.receitaws.com.br/v1/cnpj/{cnpj}");
            return JsonConvert.DeserializeObject<ReceitaApi>(json);
        }
        public static MapsApi consultaMaps(String origem, String destino)
        {
            coders();
            String json = WCliente.DownloadString($"https://maps.googleapis.com/maps/api/distancematrix/json?origins={origem}&destinations={destino}&key=AIzaSyD7yhJ82pacq_YAidfXTgqYhcjFfTd-E80");
            return JsonConvert.DeserializeObject<MapsApi>(json);
        }
    }
}
