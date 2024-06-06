using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_DSA
{
    public  class TwoSum
    {
        public int[] TwoSumMethod(int[] nums, int target) {
            int[] arr =new  int[2];
            for(int i=0; i<nums.Length; i++)
            {
                for(int  j=1; j<nums.Length; j++)
                {
                    if (nums[i]+ nums[j] == target)
                    {
                        arr[0] = i;
                        arr[1]= j;
                    }
                }
            }
            return arr;
        
        }


        //public int[] TwoSumOptimise(int[] nums, int target)
        //{
        //    int[] arr = new int[2];
        //    Dictionary<int, int> map = new Dictionary<int, int>();

        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        int complement = target - nums[i];
        //        if (map.ContainsKey(complement))
        //        {
        //            arr[0] = map[complement];
        //            arr[1] = i;
        //            return arr;
        //        }
        //        map[nums[i]] = i;
        //    }
        //    return map;

        //}
    }
}
