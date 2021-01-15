using Newtonsoft.Json;
using System.IO;

namespace Stonks
{
    public class DataSaver
    {
        public void AppendSave(StonkData data)
        {
            if (IsLatest(data))
            {
                var jsonData = JsonConvert.SerializeObject(data);
                using var destination = File.AppendText($"c:\\{data.Name}.txt");
                destination.Write(jsonData);
            }
        }

        private bool IsLatest(StonkData data)
        {


            return true;
        }
    }
}
