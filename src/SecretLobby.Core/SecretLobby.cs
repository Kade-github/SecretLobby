using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace SecretLobby
{
    public static class SecretLobby
    {
        // TODO: Remove hardcode; make request config
        private static readonly HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://api.scpslgame.com/lobbylist.php?format=json");

        // TODO: make generic type
        public static IEnumerable<IServer> GetServers()
        {
            //>hardcode
            request.Method = "GET";
            request.ContentType = "application/json";
            request.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/535.2 (KHTML, like Gecko) Chrome/15.0.874.121 Safari/535.2";
            //<hardcode

            using (StreamReader reader = new StreamReader(request.GetResponse().GetResponseStream()))
            {
                //>not generic type
                return JsonConvert.DeserializeObject<IEnumerable<IServerImpl>>(reader.ReadToEnd());
                //<not generic type
            }
        }
    }
}
