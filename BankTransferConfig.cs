using System;
using System.IO;
using System.Text.Json;

namespace modul8_103022300053
{
    class BankTransferConfig
    {
        
        public string lang { get; set; }
        public Transfer transfer {  get; set; }
        public class Transfer
        {
            public int threshold { get; set; }
            public int low_fee { get; set; }
            public int high_fee { get; set; }
        }
        public string[] methods {  get; set; }
        public Confirmation confirmation {  get; set; }
        public class Confirmation
        {
            public string en { get; set; }
            public string id { get; set; }
        }
    }

    class UIConfig
    {
        public BankTransferConfig config { get; set; }
        private string filePath = "BankTransferConfig.json";
        public UIConfig()
        {
            try
            {
                ReadConfigFile();
            }
            catch (Exception)
            {
                SetDefault();
                WriteNewConfigFile();
            }
        }
        public BankTransferConfig ReadConfigFile()
        {
                String configJsonData = File.ReadAllText(filePath);
                BankTransferConfig config = JsonSerializer.Deserialize<BankTransferConfig>(configJsonData); 
            return config;
             
        }
         public void SetDefault()
        {
            config = new BankTransferConfig();
            config.lang = "en";
            config.transfer.threshold = 25000000;
            config.transfer.low_fee = 6500;
            config.transfer.high_fee = 15000;
            config.methods =[ "RTO (real-time)", "SKN", "RTGS", "BI FAST" ];
            config.confirmation.en = "yes";
            config.confirmation.id = "ya";

        }
        private void WriteNewConfigFile()
        {
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                WriteIndented = true
            };
            String jsonString = JsonSerializer.Serialize(config, options);
            File.WriteAllText(filePath, jsonString);
        }
    }

   
       
       
       
    }
