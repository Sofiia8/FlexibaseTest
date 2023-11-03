using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexibaseTest
{
    public class MultipleThreeFive
    {
        protected int _number;
        protected string _fizzTest = "";
        protected string _buzzTest = "";
        public string[] ResultSequence { get; set; }
        public MultipleThreeFive(int[] startSequence) 
        { 
            ResultSequence = new string[startSequence.Length];
            for (int i=0; i<startSequence.Length; i++)
            {
                _number = startSequence[i];
                clearVariables();
                ResultSequence[i] = convert();
            }
        }
        protected virtual void setFizz() //3
        {
            if (_number % 3 == 0) { _fizzTest = "fizz"; }
        }
        protected virtual void setBuzz() //5
        {
            if(_number % 5 == 0) { _buzzTest = "-buzz"; }
        }
        protected virtual void count()
        {
            setFizz();
            setBuzz();
        }
        protected virtual string convert()
        {
            count();
            string result = (_fizzTest + _buzzTest).TrimStart('-');
            return result == "" ? _number.ToString() : result;
        }
        protected virtual void clearVariables()
        {
            _fizzTest = "";
            _buzzTest = "";
        }
    }
}
