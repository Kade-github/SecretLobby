using System.Linq;
using static SecretLobby.Tests.Core.Program;

namespace SecretLobby.Tests.Core.Tests
{
    public class GettingServers : ITest
    {
        public void Invoke()
        {
            ConsoleLog("Getting servers...");
            var servers = SecretLobby.GetServers();
            ConsoleLog("Servers successfully received.");

            ConsoleLog("Getting top 10 servers for online...");
            var tenServers = servers.OrderByDescending(server => server.PlayersCount).ToArray();

            int z;
            for (z = 0; z < tenServers.Count(); z++)
            {
                if (z == 10) break;

                IServer server = tenServers[z];
                ConsoleLog(string.Format("\n----------\n({0}) Players = {1}\nName = {2}\nIP = {3}\nPort = {4}\nVersion = {5}\n----------\n",
                    z,
                    server.Players,
                    server.InfoEncodedCleared,
                    server.Ip,
                    server.Port,
                    server.Version));
            }

            ConsoleLog(string.Format("Successfully received {0} servers", z));
        }
    }
}
