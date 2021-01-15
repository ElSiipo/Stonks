using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stonks
{
    public class DataGetter
    {
        public async Task<string> GetData(string url)
        {
            var doc = await new HtmlWeb().LoadFromWebAsync(url);
            var values = new List<string>
            {
                url[url.LastIndexOf("/")..].Replace("/", "").ToUpper()
            };

            var temp =
                doc.DocumentNode
                .SelectNodes("//ul[@class='cleanList floatList clearFix quoteBar ']")
                .Select(n => n.InnerText.Trim()
                    .Replace("\t", "")
                    .Replace("\n\r\n\r", "")
                    .Replace("Köp" + Environment.NewLine, "")
                    .Replace("Sälj" + Environment.NewLine, ""));

            values.AddRange(temp);

            return string.Join(Environment.NewLine, values);
        }
    }
}