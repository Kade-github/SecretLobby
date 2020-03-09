namespace SecretLobby
{
    public interface IServer
    {
        #region Base response

        long ServerId { get; }
        long AccountId { get; }
        string Ip { get; }
        ushort Port { get; }
        string Players { get; }
        long Distance { get; }
        string Info { get; }
        string Pastebin { get; }
        string Version { get; }
        bool PrivateBeta { get; }
        bool FriendlyFire { get; }
        bool Modded { get; }
        bool Whitelist { get; }
        string ISOCode { get; }
        string ContinentCode { get; }
        double Latitude { get; }
        double Longitude { get; }
        string Official { get; }
        // TODO: Make sure that this is the correct type
        long OfficialCode { get; }
        // TODO: Make sure that this is the correct type
        long DisplaySection { get; }

        #endregion

        #region Custom fields

        string InfoEncoded { get; }

        string InfoEncodedCleared { get; }

        int PlayersCount { get; }
        int SlotsCount { get; }


        #endregion
    }
}
