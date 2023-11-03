using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexibaseTest
{
    public class TransformToStringFizBuzMuzGuz : ITransformToString
    {
        public virtual string Transform(int number)
        {
            Dictionary<int, string> rule = new Dictionary<int, string>
            {{ 3, "fizz" }, { 5, "buzz"} , { 4, "muzz" }, { 7, "guzz" } };
            Dictionary<int, bool> checkDevided = new Dictionary<int, bool>();
            checkDevided.Add(3, Devision.IsDevisibleBy(number, 3));
            checkDevided.Add(5, Devision.IsDevisibleBy(number, 5));
            checkDevided.Add(4, Devision.IsDevisibleBy(number, 4));
            checkDevided.Add(7, Devision.IsDevisibleBy(number, 7));
            string result = TransformDictsToString.TransformToString(checkDevided, rule, '-');
            return result.Length == 0 ? number.ToString() : result;
        }
    }
}
