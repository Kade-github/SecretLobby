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
        
        /// <summary>
        /// Returns the most recent servers in the SCP:SL Web API.
        /// </summary>
        /// <returns>A List of Servers found</returns>
        public static List<Server> GetLobbyList()
        {
            HttpWebRequest request = (HttpWebRequest) WebRequest.Create("https://api.scpslgame.com/lobbylist.php?format=json");
            request.Method = "GET";
            request.ContentType = "application/json";
            request.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/535.2 (KHTML, like Gecko) Chrome/15.0.874.121 Safari/535.2"; // If we do not add the user agent, it will return a 'Unhandled Exception: System.Net.WebException: The request was aborted: The connection was closed unexpectedly.'
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