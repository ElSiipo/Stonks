using System;
using System.IO;
using System.Linq;

namespace Stonks
{
    class Program : DataGetter
    {
        static void Main(string[] args)
        {
            var dataGetter = new DataGetter();
            var dataConverter = new DataConverter();

            using var tr = new StreamReader(@"stonks.txt");
            
            var stonkAddresses = tr.ReadToEnd()
                .Split(Environment.NewLine)
                .ToList();

            var stonkModels = stonkAddresses
                .Select(address => dataGetter.GetData(address).GetAwaiter().GetResult())
                .Select(dataConverter.ConvertToStonkModel)
                .ToList();

            foreach(var stonk in stonkModels)
            {
                Console.WriteLine(string.Format("{0,30} | {1,8} |{2,8}|{3,15}|{4,8}|{5,8}|{6,8}|{7,8}|", 
                    stonk.Name, 
                    stonk.LastUpdated,
                    stonk.DevelopmentTodayPercentage != null ? stonk.DevelopmentTodayPercentage + "%" : "", 
                    stonk.DevelopmentToday != null ? stonk.DevelopmentToday + " " + stonk.Currency : "",
                    stonk.BuyValue, 
                    stonk.SellValue, 
                    stonk.HighestToday, 
                    stonk.LowestToday));
            }

            Console.ReadLine();
        }
    }
}
