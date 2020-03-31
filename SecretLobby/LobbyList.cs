using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;
using System.Net;

namespace SecretLobby
{
    public static class LobbyList
    {
        // The most fucking simplest api i've ever made.
        // lOl
        
        public static List<Server> GetLobbyList()
        {
            HttpWebRequest request = (HttpWebRequest) WebRequest.Create("https://api.scpslgame.com/lobbylist.php?format=json");
            request.Method = "GET";
            request.ContentType = "application/json";
            using (Stream s = request.GetResponse().GetResponseStream())
            {
                using (StreamReader sr = new StreamReader(s))
                {
                    var jsonResponse = sr.ReadToEnd();
                    return JsonConvert.DeserializeObject<List<Server>>(jsonResponse);
                }
            }
        }
    }

}