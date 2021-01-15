using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace Stonks
{
    public class DataLoader
    {
        public List<StonkData> LoadStonkDatas(string stonkName)
        {
            string jsonDataFromFile = File.ReadAllText($"c:\\{stonkName}.txt");
            List<StonkData> stonkDatas = JsonConvert.DeserializeObject<List<StonkData>>(jsonDataFromFile);

            return stonkDatas;
        }
    }
}
