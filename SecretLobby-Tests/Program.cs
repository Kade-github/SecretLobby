using System;
using System.Collections.Generic;
using System.Linq;

namespace SecretLobby
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            List<Server> list = LobbyList.GetLobbyList();
            Console.WriteLine("Servers: " + list.Count);
            Console.WriteLine("Top 20 in your area!");
            for (int i = 0; i < 20; i++)
                Console.WriteLine("#" + (i + 1) + ": " + list[i].ServerInfo);
            Console.Read();
        }
    }
}