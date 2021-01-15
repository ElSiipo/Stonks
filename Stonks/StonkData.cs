using System;
using System.Runtime.Serialization;

namespace Stonks
{
    [DataContract]
    public class StonkData
    {
        [DataMember]
        public string Name { get; }
        [DataMember]
        public string Currency { get; }
        [DataMember]
        public decimal? DevelopmentTodayPercentage { get; }
        [DataMember]
        public decimal? DevelopmentToday { get; }
        [DataMember]
        public decimal? BuyValue { get; }
        [DataMember]
        public decimal? SellValue { get; }
        [DataMember]
        public decimal? LastValue { get; }
        [DataMember]
        public decimal? HighestToday { get; }
        [DataMember]
        public decimal? LowestToday { get; }
        [DataMember]
        public decimal? Shares { get; }
        [DataMember]
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
