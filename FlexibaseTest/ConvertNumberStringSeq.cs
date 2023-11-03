using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexibaseTest
{
    public class ConvertNumberStringSeq
    {
        public string[] TransformedArr;
        public ConvertNumberStringSeq(int[] arr, ITransformToString transformSeq)
        {
            TransformedArr = new string[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                TransformedArr[i] = transformSeq.Transform(arr[i]);
            }
        }
    }
}
