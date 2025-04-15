using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace modul8_103022300029
{
    class BankTransferConfig
    {
        public const string ConfigPath = @"bank_transfer_config.json";

        public string lang { get; set; }
        public Transfer transfer { get; set; }
        public List<string> methods { get; set; }
        public Confirmation confirmation { get; set; }


        public class Transfer()
        {

            public int threshold { get; set; }
            public int low_fee { get; set; }
            public int high_fee { get; set; }

        }

        public class Confirmation()
        {

            public string en { get; set; }
            public string id { get; set; }



        }

        public BankTransferConfig LoadConfig()
        {
            string json = File.ReadAllText(ConfigPath);
            var data = JsonSerializer.Deserialize<BankTransferConfig>(json);
            return data;
        }
    }

}
