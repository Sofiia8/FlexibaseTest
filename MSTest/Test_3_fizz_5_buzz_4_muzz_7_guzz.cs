using FlexibaseTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSTest
{
    [TestClass]
    public class Test_3_fizz_5_buzz_4_muzz_7_guzz
    {
        [TestMethod]
        public void CheckChangeLongSeq()
        {
            int[] In = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 60, 105, 420 };
            string[] Out = { "1", "2", "fizz", "muzz", "buzz", "fizz", "guzz", "muzz", "fizz",
                "buzz", "11", "fizz-muzz", "13", "guzz", "fizz-buzz","fizz-buzz-muzz", "fizz-buzz-guzz", "fizz-buzz-muzz-guzz" };
            var converter = new ConvertNumberStringSeq(In, new TransformToStringFizBuzMuzGuz());
            string[] outStrings = converter.TransformedArr;

            for (int i = 0; i < In.Length; i++)
            {
                Assert.AreEqual(Out[i], outStrings[i]);
            }
        }
        [TestMethod]
        public void CheckChange_4060_495320()
        {
            int[] In = { 4060, 495320 };
            string[] Out = { "buzz-muzz-guzz", "buzz-muzz-guzz" };
            var converter = new ConvertNumberStringSeq(In, new TransformToStringFizBuzMuzGuz());
            string[] outStrings = converter.TransformedArr;

            for (int i = 0; i < In.Length; i++)
            {
                Assert.AreEqual(Out[i], outStrings[i]);
            }
        }
    }
}
