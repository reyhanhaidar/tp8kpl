using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace tp8
{
    internal class covidConvig
    {
        public string suhu { set; get; }
        public int suhu2 { set; get;}
        public string suhu3 { set; get;}

        public string suhu4 { set; get;}    

        public covidConvig() { }

        public covidConvig(string suhu, int suhu2, string suhu3, string suhu4) {
            suhu = suhu;
            suhu2 = suhu2;
            suhu3 = suhu3;
            suhu4 = suhu4;
        }
    
    }

    class UIConfig
    {
        public covidConvig config;
        public const String filePath = "C:\\Users\\Reyhan\\source\\repos\\tp8kpl\\tp8\\tp8\\Script1.js";
        public UIConfig() {
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
        private covidConvig ReadConfigFile() {
            String configJsonData = File.ReadAllText("C:\\Users\\Reyhan\\source\\repos\\tp8kpl\\tp8\\tp8\\Script1.js");
            covidConvig config = JsonSerializer.Deserialize<covidConvig>(configJsonData);
            return config;
        }
        private void SetDefault() { Console.WriteLine("belum ada"); }
        private void WriteNewConfigFile() {
            if("CONFIG" == null)
            {
                Console.WriteLine("berapa suhu anda?");
            }
        }



    }



}

   

