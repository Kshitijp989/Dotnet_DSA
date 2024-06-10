using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_DSA
{
    public class RemoveDuplicateFromArray
    {

        public int RemoveDuplicate(int[] arr,int n) {

            int[] temp = new int[n];
            int j = 0;
            temp[j++] = arr[0];
            for(int i=1; i<arr.Length; i++) {
                if (arr[i] != arr[i-1]) {
                    temp[j++] = arr[i];
                }
            }
            for(int i=0;i<j;i++) {
                arr[i] = temp[i];
            }
            return j;

        }
    }
}
