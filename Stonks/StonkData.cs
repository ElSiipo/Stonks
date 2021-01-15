using System;

namespace Stonks
{
    public class StonkData
    {
        public string Name { get; }
        public string Currency { get; }
        public decimal? DevelopmentTodayPercentage { get; }
        public decimal? DevelopmentToday { get; }
        public decimal? BuyValue { get; }
        public decimal? SellValue { get; }
        public decimal? LastValue { get; }
        public decimal? HighestToday { get; }
        public decimal? LowestToday { get; }
        public decimal? Shares { get; }
        public DateTime LastUpdated { get; }

        public StonkData(string name, string currency, decimal? developmentTodayPercentage, decimal? developmentToday, decimal? buyValue, decimal? sellValue, decimal? lastValue, decimal? highestToday, decimal? lowestToday, decimal? shares, DateTime lastUpdated)
        {
            Name = name;
            Currency = currency;
            DevelopmentTodayPercentage = developmentTodayPercentage;
            DevelopmentToday = developmentToday;
            BuyValue = buyValue;
            SellValue = sellValue;
            LastValue = lastValue;
            HighestToday = highestToday;
            LowestToday = lowestToday;
            Shares = shares;
            LastUpdated = lastUpdated;
        }
    }
}
