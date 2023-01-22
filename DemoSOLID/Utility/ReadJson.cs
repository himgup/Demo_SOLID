using DemoSOLID.Models;
using Newtonsoft.Json;

namespace DemoSOLID.Utility
{
    public static class ReadJson
    {
        public static string  ReadJsonFile()
        {

            string jsonText = File.ReadAllText(@"./data.json");

            if (string.IsNullOrWhiteSpace(jsonText))

                return "Either file is not found or there is no data present."; 
                
            else
            
                return jsonText;

        }
    }
}
