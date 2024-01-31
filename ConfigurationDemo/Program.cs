using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using DemoConfig;
namespace ConfigurationDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int TotalPlayers=ReadConfigFile.GetPlayerCount();
            Console.WriteLine(TotalPlayers);

            //string value=ConfigurationManager.AppSettings.Get("p1");
            //Console.WriteLine(value);

            string value=ConfigurationManager.AppSettings["p1"];
            Console.WriteLine(value);
            Console.ReadLine();

        }

        
    }
}
