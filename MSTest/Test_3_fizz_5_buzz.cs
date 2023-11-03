using FlexibaseTest;

namespace MSTest
{
    [TestClass]
    public class Test_3_fizz_5_buzz
    {
        [TestMethod]
        public void CheckChangeFrom_1_to_15()
        {
            int[] In = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            string[] Out = { "1", "2", "fizz", "4", "buzz", "fizz", "7", "8",
                "fizz", "buzz", "11", "fizz", "13", "14", "fizz-buzz" };
            var a = new ConvertNumberStringSeq(In, new TransformToStringFizzBuzz());
            string[] outStrings = a.TransformedArr;

            for (int i = 0; i < In.Length; i++)
            {
                Assert.AreEqual(Out[i], outStrings[i]);
            }
        }
    }
}