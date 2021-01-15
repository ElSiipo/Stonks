using System;
using System.Linq;

namespace Stonks
{
    public class DataConverter
    {
        public StonkData ConvertToStonkModel(string data)
        {
            var splittedData = data
                .Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries)
                .Where(l => !string.IsNullOrWhiteSpace(l))
                .ToArray();

            return new StonkData(
                splittedData[0],
                splittedData[4][^3..],
                TryGetValue(splittedData[2].Replace(" %", "")),
                TryGetValue(RemoveCurrency(splittedData[4])),
                TryGetValue(splittedData[5]),
                TryGetValue(splittedData[6]),
                TryGetValue(splittedData[8]),
                TryGetValue(splittedData[10]),
                TryGetValue(splittedData[12]),
                TryGetValue(splittedData[14]),
                DateTime.Parse(splittedData[16]));
        }

        private static decimal? TryGetValue(string line)
        {
            return decimal.TryParse(line, out decimal value)
                ? (decimal?)value
                : null;
        }

        private static string RemoveCurrency(string line)
        {
            return line
                .Replace("  NOK", "")
                .Replace("  SEK", "")
                .Replace("  CAD", "")
                .Replace("  USD", "");
        }
    }
}
