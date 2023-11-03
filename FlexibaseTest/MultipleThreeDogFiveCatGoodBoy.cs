using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexibaseTest
{
    public class MultipleThreeDogFiveCatGoodBoy : MultipleFourSeven
    {
        public MultipleThreeDogFiveCatGoodBoy(int[] startSequence) : base(startSequence)
        {
        }
        protected virtual string setDog(string result)
        {
            return result == _fizzTest ? "dog" : result;
        }
        protected virtual string setCat(string result)
        {
            return result == _buzzTest.TrimStart('-') ? "cat": result; 
        }
        protected virtual void setGoodBoy()
        {
            if (_fizzTest.Length * _buzzTest.Length > 0)
            {
                _fizzTest = "";
                _buzzTest = "";
                _muzzTest = "good-boy" + _muzzTest;
            }
        }
        protected override void count()
        {
            base.count();
            setGoodBoy();
        }
        protected override string convert()
        {
            count();
            string result = (_fizzTest + _buzzTest + _muzzTest + _guzzTest).TrimStart('-');
            if (result.Length > 0)
            {
                result = setDog(result);
                result = setCat(result);
            }
            return result == "" ? _number.ToString() : result;
        }
    }
}
