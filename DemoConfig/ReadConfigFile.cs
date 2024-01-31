using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
namespace DemoConfig
{
    public class ReadConfigFile
    {
        public static int GetPlayerCount()
        {
            int CountPlayers = Convert.ToInt32(ConfigurationManager.AppSettings["NumberOfPlayers"]);
            return CountPlayers;

        }
    }
}
