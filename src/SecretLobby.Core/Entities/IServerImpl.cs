using Newtonsoft.Json;
using System;
using System.Text;
using System.Text.RegularExpressions;

namespace SecretLobby
{
    [JsonObject(
        MemberSerialization = MemberSerialization.OptIn,
        MissingMemberHandling = MissingMemberHandling.Ignore,
        ItemNullValueHandling = NullValueHandling.Include,
        ItemRequired = Required.Default,

        IsReference = false,
        ItemIsReference = false,
        Id = "SecretLobby.IServer"
        )]
    public sealed class IServerImpl : IServer
    {
        #region JSON Fields

        [JsonProperty(PropertyName = "serverId")]
        private long _serverId;

        [JsonProperty(PropertyName = "accountId")]
        private long _accountId;

        [JsonProperty(PropertyName = "ip")]
        private string _ip;

        [JsonProperty(PropertyName = "port")]
        private ushort _port;

        [JsonProperty(PropertyName = "players")]
        private string _players;

        [JsonProperty(PropertyName = "distance")]
        private long _distance;

        [JsonProperty(PropertyName = "info")]
        private string _info;

        [JsonProperty(PropertyName = "pastebin")]
        private string _pastebin;

        [JsonProperty(PropertyName = "version")]
        private string _version;

        [JsonProperty(PropertyName = "privateBeta")]
        private bool _privateBeta;

        [JsonProperty(PropertyName = "friendlyFire")]
        private bool _friendlyFire;

        [JsonProperty(PropertyName = "modded")]
        private bool _modded;

        [JsonProperty(PropertyName = "whitelist")]
        private bool _whitelist;

        [JsonProperty(PropertyName = "isoCode")]
        private string _isoCode;

        [JsonProperty(PropertyName = "continentCode")]
        private string _continentCode;

        [JsonProperty(PropertyName = "latitude")]
        private double _latitude;

        [JsonProperty(PropertyName = "longitude")]
        private double _longitude;

        [JsonProperty(PropertyName = "official")]
        private string _official;

        [JsonProperty(PropertyName = "officialCode")]
        private long _officialCode;

        [JsonProperty(PropertyName = "displaySection")]
        private long _displaySection;

        #endregion

        #region Implemented Fields

        long IServer.ServerId => _serverId;

        long IServer.AccountId => _accountId;

        string IServer.Ip => _ip;

        ushort IServer.Port => _port;

        string IServer.Players => _players;

        long IServer.Distance => _distance;

        string IServer.Info => _info;

        string IServer.Pastebin => _pastebin;

        string IServer.Version => _version;

        bool IServer.PrivateBeta => _privateBeta;

        bool IServer.FriendlyFire => _friendlyFire;

        bool IServer.Modded => _modded;

        bool IServer.Whitelist => _whitelist;

        string IServer.ISOCode => _isoCode;

        string IServer.ContinentCode => _continentCode;

        double IServer.Latitude => _latitude;

        double IServer.Longitude => _longitude;

        string IServer.Official => _official;

        long IServer.OfficialCode => _officialCode;

        long IServer.DisplaySection => _displaySection;

        // Use UTF-8 to support the Chinese character
        // >>> Need to check if it didn't work for me | @iRebbok
        string IServer.InfoEncoded => Encoding.UTF8.GetString(Convert.FromBase64String(_info));

        string IServer.InfoEncodedCleared =>
            // A lot of spaces
            Regex.Replace(
                // Other <tags>
                Regex.Replace(
                    Encoding.UTF8.GetString(
                    Convert.FromBase64String(_info)),
                @"<[^>]*?>",
                string.Empty),
            @"\s+",
            " ");

        int IServer.PlayersCount => int.Parse(_players.Split('/')[0]);

        int IServer.SlotsCount => int.Parse(_players.Split('/')[1]);

        #endregion
    }
}
