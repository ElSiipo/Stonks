using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Stonks
{
    public class DataSaver
    {
        public static void Save(StonkData data)
        {
            // If file exists, use AppendSave. Otherwise create file. 
            // Maybe?
        }

        public static async Task SaveAppendAsync(StonkData data)
        {
            var stonkList = await DataLoader.LoadDatasAsync(data.Name);

            if (IsLatest(stonkList, data))
            {
                var userFolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
                var folderName = $"{userFolder}\\Stonks\\";
                VerifyFolderExists(folderName);

                stonkList.Add(data);

                var jsonData = JsonConvert.SerializeObject(stonkList);

                await File.WriteAllTextAsync($"{folderName}{data.Name}.txt", jsonData);
            }
        }

        private static void VerifyFolderExists(string path)
        {
            Directory.CreateDirectory(path);
        }

        private static bool IsLatest(List<StonkData> existingData, StonkData data)
        {
            if (!existingData.Any())
                return true;

            return existingData.Any() && existingData.All(existing => existing.LastUpdated < data.LastUpdated);
        }
    }
}