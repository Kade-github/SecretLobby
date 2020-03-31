[![Issues](https://img.shields.io/github/issues/KadeDev/SecretLobby?style=for-the-badge)](https://github.com/KadeDev/SecretLobby/issues) 
[![NuGet](https://img.shields.io/nuget/v/secretlobby-sl?style=for-the-badge)](https://www.nuget.org/packages/secretlobby-sl/)
[![Codacy grade](https://img.shields.io/codacy/grade/f80caf117ba04850a4d611fece0e5330?style=for-the-badge)](https://www.codacy.com/manual/KadeDev/SecretLobby?utm_source=github.com&amp;utm_medium=referral&amp;utm_content=KadeDev/SecretLobby&amp;utm_campaign=Badge_Grade)


# Secret Lobby
Secret Lobby is an API to get SCP:SL servers from the web api, and use them in C# Applications.

# How to use
Secret Lobby is pretty simple to use.

Here's an example of how you would call it:
```csharp
List<Server> list = LobbyList.GetLobbyList();
Console.WriteLine("Servers: " + list.Count);
Console.WriteLine("Top 20 in your area!");
for (int i = 0; i < 20; i++)
    Console.WriteLine("#" + (i + 1) + ": " + list[i].ServerInfo);
Console.Read();
```
