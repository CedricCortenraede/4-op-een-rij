using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _4opeenrij.Domoticz
{
    class Domoticz
    {
        const string baseAddress = "http://127.0.0.1:8080" + "/json.htm";

        public static Switch[] GetSwitches()
        {
            // Doe een API request naar de link om alle Switches op te halen van Domoticz.
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(baseAddress + "?type=devices&filter=light&used=true&order=Name");
            request.Method = "GET";

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            // Haal de JSON String van deze pagina op.
            String JSONString;
            using (Stream stream = response.GetResponseStream())
            {
                StreamReader reader = new StreamReader(stream, System.Text.Encoding.UTF8);

                JSONString = reader.ReadToEnd();
            }

            // Veranderd deze JSON String naar een Object dat gebruikt kan worden in de applicatie.
            SwitchResult switchResult = Newtonsoft.Json.JsonConvert.DeserializeObject<SwitchResult>(JSONString);

            // Geef de beschikbare switches terug als resultaat.
            return switchResult.Result;
        }

        public static void UseSwitch(Switch @switch, SwitchActionEnum action)
        {
            String paramString = "?type=command&param=switchlight&idx=" + @switch.Idx + "&switchcmd=" + action;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(baseAddress + paramString);
            request.Method = "GET";

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        }
    }
}
