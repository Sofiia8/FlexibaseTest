using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexibaseTest
{
    public class MultipleFourSeven : MultipleThreeFive
    {
        protected string _muzzTest = "";
        protected string _guzzTest = "";
        public MultipleFourSeven(int[] startSequence) : base(startSequence)
        {
        }

        protected virtual void setMuzz() // 4
        {
            if (_number % 4 == 0)
            {
                _muzzTest = "-muzz";
            }
        }
        protected virtual void setGuzz() // 7
        {
            if (_number % 7 == 0)
            {
                _guzzTest = "-guzz";
            }
        }
        protected override void count()
        {
            base.count();
            setMuzz();
            setGuzz();
        }
        protected override string convert()
        {
            count();
            string result = (_fizzTest + _buzzTest + _muzzTest + _guzzTest).TrimStart('-');
            return result == "" ? _number.ToString() : result;
        }
        protected override void clearVariables()
        {
            base.clearVariables();
            _muzzTest = "";
            _guzzTest = "";
        }
    }
}
