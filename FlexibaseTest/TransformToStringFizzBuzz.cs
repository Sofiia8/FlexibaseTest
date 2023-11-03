using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexibaseTest
{
    public class TransformToStringFizzBuzz : ITransformToString
    {
        public string Transform(int number)
        {
            Dictionary<int, string> rule = new Dictionary<int, string>
            {{ 3, "fizz" }, { 5, "buzz"} };
            Dictionary<int, bool> checkDevided = new Dictionary<int, bool>();
            checkDevided.Add(3, Devision.IsDevisibleBy(number, 3));
            checkDevided.Add(5, Devision.IsDevisibleBy(number, 5));
            string result = TransformDictsToString.TransformToString(checkDevided, rule, '-');
            return result.Length == 0 ? number.ToString() : result;
        }
    }
}
