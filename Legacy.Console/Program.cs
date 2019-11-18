using BFICommon.Util;
using LegacyConsole;
using System;
using System.Linq;
using System.Reflection;
using System.Threading;

namespace ConsoleLegacy
{
    class Program
    {
        private static void Main(string[] args)
        {
            Startup.ConfigureServices();
            try
            {
                Execute(args[0]);
                Console.WriteLine("Process Success");
                Timer t = new Timer(timerC, null, 5000, 5000);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }

        private static void Execute(string args)
        {
            var value = DatabaseUtil.ReadSQLQueriesFromResourceFile(args, typeof(ConsoleResource)).Split(".");
            if (value.Length == 0)
            {
                Console.Error.WriteLine("Service Not Found");
                Environment.Exit(0);
            }

            var typeValue = value[0];
            var methodValue = value[1];

            var assemblies = Assembly.GetExecutingAssembly().GetTypes();
            var type = assemblies.Where(x => x.Name.ToUpper().Contains(typeValue.ToUpper())).SingleOrDefault();

            type.GetMethod(methodValue).Invoke(null, null);
        }

        private static void timerC(object state)
        {
            Environment.Exit(0);
        }

    }
}
