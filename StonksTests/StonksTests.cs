using Stonks;
using Xunit;

namespace StonksTests
{
    public class StonksTests
    {
        [Fact]
        public void TestMethod1()
        {
            var stonk = new DataConverter().ConvertToStonkModel(Testdata);

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
    }
}
