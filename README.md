[![Issues](https://img.shields.io/github/issues/KadeDev/SecretLobby?style=for-the-badge)](https://github.com/KadeDev/SecretLobby/issues) 
[![NuGet](https://img.shields.io/nuget/v/secretlobby-sl?style=for-the-badge)](https://www.nuget.org/packages/secretlobby-sl/)
[![Codacy grade](https://img.shields.io/codacy/grade/f80caf117ba04850a4d611fece0e5330?style=for-the-badge)](https://www.codacy.com/manual/KadeDev/SecretLobby?utm_source=github.com&amp;utm_medium=referral&amp;utm_content=KadeDev/SecretLobby&amp;utm_campaign=Badge_Grade)


# Secret Lobby
An API (getter) to get (lol) the scpsl servers.

To init it do: `List<Server> Servers = LobbyList.GetLobbyList();`

And control it how you would. 

Also use `Servers[important server].GetInfo()` instead of `Servers[Important server].Info` because hubert was like ima base 64 encode shit so `GetInfo` does that automaticly for you. <3
