using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Stonks
{
    public class DataLoader
    {
        public static async Task<List<StonkData>> LoadDatasAsync(string stonkName)
        {
            var userFolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            var folderName = $"{userFolder}\\Stonks\\";

            if(!File.Exists($"{folderName}{stonkName}.txt"))
            {
                return new List<StonkData>();
            }

            string jsonDataFromFile = await File.ReadAllTextAsync($"{folderName}{stonkName}.txt");
            return JsonConvert.DeserializeObject<List<StonkData>>(jsonDataFromFile);
        }
    }
}
