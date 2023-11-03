using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexibaseTest
{
    public class TransformToStringDogCatGoodBoy : TransformToStringFizBuzMuzGuz, ITransformToString
    {
        public override string Transform(int number)
        {
            string result = base.Transform(number);
            result = TransformDictsToString.TransformCatDogGoodBoy(result);
            return result.Length == 0 ? number.ToString() : result;
        }
    }
}
