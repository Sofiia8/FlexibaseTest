using FlexibaseTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSTest
{
    [TestClass]
    public class Test_3_dog_5_cat_4_muzz_7_guzz_3_5_goodboy
    {
        [TestMethod]
        public void CheckChangeLongSeq()
        {
            int[] In = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 60, 105, 420 };
            string[] Out = { "1", "2", "dog", "muzz", "cat", "dog", "guzz", "muzz", "dog",
                "cat", "11", "fizz-muzz", "13", "guzz", "good-boy","good-boy-muzz", "good-boy-guzz", "good-boy-muzz-guzz"};

            //string[] outStrings = (new MultipleThreeDogFiveCatGoodBoy(In)).ResultSequence;
            var converter = new ConvertNumberStringSeq(In, new TransformToStringDogCatGoodBoy());
            string[] outStrings = converter.TransformedArr;

            for (int i = 0; i < In.Length; i++)
            {
                Assert.AreEqual(Out[i], outStrings[i]);
            }
        }
        [TestMethod]
        public void Check_34_56_1000003_100000000_345()
        {
            int[] In = { 1000002, 56, 1000003, 100000000, 345 };
            string[] Out = { "dog", "muzz-guzz", "1000003", "buzz-muzz", "good-boy"};
            //string[] outStrings = (new MultipleThreeDogFiveCatGoodBoy(In)).ResultSequence;
            var converter = new ConvertNumberStringSeq(In, new TransformToStringDogCatGoodBoy());
            string[] outStrings = converter.TransformedArr;

            for (int i = 0; i < In.Length; i++)
            {
                Assert.AreEqual(Out[i], outStrings[i]);
            }
        }
    }
}
