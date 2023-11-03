using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexibaseTest
{
    internal static class TransformDictsToString
    {
        internal static string TransformToString(Dictionary<int, bool> devision, Dictionary<int, string> change, char separator)
        {
            string resultString = "";
            if (devision.Count != change.Count)
            {
                throw new ArgumentException();
            }
            foreach (int i in devision.Keys.Where(key => devision[key] == true))
            {
                if (!change.ContainsKey(i)) throw new ArgumentException();
                if (resultString.Length > 0) { resultString += separator; }
                resultString += change[i];
            }
            return resultString;
        }

        internal static string TransformCatDogGoodBoy(string input)
        {
            string multipleBy3 = "fizz";
            string multipleBy5 = "buzz";
            string both = "fizz-buzz";
            if (input == multipleBy3) return "dog";
            if (input == multipleBy5) return "cat";
            return input.StartsWith(both) ? input.Replace(both, "good-boy") : input;
        }
    }
}
