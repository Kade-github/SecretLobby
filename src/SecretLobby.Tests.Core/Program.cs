using System;
using System.Linq;
using System.Reflection;

namespace SecretLobby.Tests.Core
{
    public static class Program
    {
        public static void ConsoleLog(string message)
        {
            if (string.IsNullOrWhiteSpace(message))
            {
                ConsoleLog("Null/White space message;\nStackTace:\n" + new System.Diagnostics.StackTrace().ToString());
                return;
            }
            Console.WriteLine(string.Format("[{0}] {1}", DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss.fff zzz"), message));
        }

        public static void Main()
        {
            try
            {
                var assembly = Assembly.GetEntryAssembly();

                foreach (var type in assembly.GetTypes())
                {
                    if (type != typeof(ITest) && type.GetInterfaces().Any(interf => interf == typeof(ITest)))
                    {
                        ConsoleLog("\n-----------------------------------------------------------------\n");
                        try
                        {
                            var instance = (ITest)Activator.CreateInstance(type);

                            ConsoleLog(string.Format("Starting {0} test.", type.Name));
                            try
                            {
                                instance.Invoke();
                            }
                            catch (Exception ex)
                            {
                                ConsoleLog(string.Format("Exception while executing {0} test.", type.Name));
                                ConsoleLog(ex.ToString());
                            }
                            ConsoleLog(string.Format("Ending {0} test.", type.Name));
                        }
                        catch (Exception ex)
                        {
                            ConsoleLog(string.Format("Exception while creating instance {0} test.", type.Name));
                            ConsoleLog(ex.ToString());
                        }
                        ConsoleLog("\n-----------------------------------------------------------------\n");
                    }
                }
            }
            catch (Exception ex)
            {
                ConsoleLog("Exception.");
                ConsoleLog(ex.ToString());
            }

            Console.ReadKey();
        }
    }
}
