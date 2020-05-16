using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestoreTDSnew
{
    class FilePicker
    {
        public int GetLab { get; set; }
        public int GetServer { get; set; }
        public string GetDatabase { get; set; }
        public string ExactServer
        {
            get
            {
                return "Lab" + GetLab + "s000" + GetServer;
            }
        }

        public FilePicker(int getLab, int getServer, string getDatabase)
        {
            GetLab= getLab;
            GetServer= getServer;
            GetDatabase = getDatabase;
        }

        public string GetDataFromConfig()
        {
            var data = new ConfigurationBuilder().AddJsonFile("config.json").Build();

            return data[GetDatabase + ":"+ ExactServer];
        }
    }
}
