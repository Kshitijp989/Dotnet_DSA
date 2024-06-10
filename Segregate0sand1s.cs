using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_DSA
{
    public class Segregate0sand1s
    {
        public int[] segregate0and1(int[] arr, int n)
        {
            Console.WriteLine("Here");
            
            int i = 0;
            int j = n - 1;
            while (i < j)
            {
                if (arr[i]==0 && arr[j] == 1)
                {
                    i++;
                    j--;
                }
                if(arr[i]==1 && arr[j] == 0) {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    i++;
                    j--;
                }

            }
            return arr;

        }
    }
}
