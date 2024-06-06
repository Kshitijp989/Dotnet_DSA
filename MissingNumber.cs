using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_DSA
{
    public  class MissingNumber
    {

        public int MissingNumberFromArray(int[] arr, int n)
        {
            int sum1 = 0;
            for(int i=0; i<arr.Length; i++)
            {
                sum1 += arr[i];
            }
            int sumNum = n * (n + 1) / 2;
            int ans = sumNum - sum1;
            return ans;
        }
    }
}
