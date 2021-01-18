using Stonks;
using System.Threading.Tasks;
using Xunit;

namespace StonksTests
{
    public class StonksTests
    {
        [Fact]
        public async Task FileShouldBeAppended()
        {
            var converter = new DataConverter();
            var stonk = converter.ConvertToStonkModel(Testdata);
            var newerStonk = converter.ConvertToStonkModel(NewerTestdata);
            
            await DataSaver.SaveAppendAsync(stonk);
            await DataSaver.SaveAppendAsync(newerStonk);

            var loadedData = await DataLoader.LoadDatasAsync(stonk.Name);

            Assert.True(loadedData.Count == 2);
        }

        private string Testdata => @"ZAPTEC


Utv. idag %
-6,33 %
Utv. idag NOK
-3,55  NOK

52,00
56,80
Senast
52,50

Högst
58,00
Lägst
50,01
Antal

1 096 766
Tid
17:15:01
";

        private string NewerTestdata => @"ZAPTEC


Utv. idag %
-6,33 %
Utv. idag NOK
-3,55  NOK

52,00
56,80
Senast
52,50

Högst
58,00
Lägst
50,01
Antal

1 096 766
Tid
20:15:01
";
    }
}
