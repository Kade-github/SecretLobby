using Newtonsoft.Json;
using System;
using System.Text;

namespace SecretLobby
{
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

        /// <summary>
        /// Returns the base-64-parsed contents of <see cref="Info"/>.
        /// </summary>
        public string ServerInfo => Encoding.ASCII.GetString(Convert.FromBase64String(Info));

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

    }
}
