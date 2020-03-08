using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace SecretLobby
{
    public class LobbyList
    {
        // The most fucking simplest api i've ever made.
        // lOl
        
        public static List<Server> GetLobbyList()
        {
            HttpWebRequest request = (HttpWebRequest) WebRequest.Create("https://api.scpslgame.com/lobbylist.php?format=json");
            request.Method = "GET";
            request.ContentType = "application/json";
            request.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/535.2 (KHTML, like Gecko) Chrome/15.0.874.121 Safari/535.2";
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

    public class Server
    {
        [JsonProperty("serverId")]
        public long ServerId { get; set; }

        [JsonProperty("accountId")]
        public long AccountId { get; set; }

        [JsonProperty("ip")]
        public string Ip { get; set; }

        [JsonProperty("port")]
        public long Port { get; set; }

        [JsonProperty("players")]
        public string Players { get; set; }

        [JsonProperty("distance")]
        public long Distance { get; set; }

        [JsonProperty("info")]
        public string Info { get; set; }

        [JsonProperty("pastebin")]
        public string Pastebin { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("privateBeta")]
        public bool PrivateBeta { get; set; }

        [JsonProperty("friendlyFire")]
        public bool FriendlyFire { get; set; }

        [JsonProperty("modded")]
        public bool Modded { get; set; }

        [JsonProperty("whitelist")]
        public bool Whitelist { get; set; }

        [JsonProperty("isoCode")]
        public string IsoCode { get; set; }

        [JsonProperty("continentCode")]
        public string ContinentCode { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("official")]
        public string Official { get; set; }

        [JsonProperty("officialCode")]
        public long OfficialCode { get; set; }

        [JsonProperty("displaySection")]
        public long DisplaySection { get; set; }

        // Hubert made it all FU CK ING  BAS E 64 EnCoded for some reason. Mostly to stop SQL Injection, but like, lemme whisper somthing. "prepared statements" :O
        public string GetInfo()
        {
            return Encoding.ASCII.GetString(Convert.FromBase64String(Info));
        }
    }
}