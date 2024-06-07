using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_DSA.StringManupilation
{
    public  class RemoveDuplicateCharacterFrom_String
    {

        public string RemoveDuplicateChar(string str)
        {
            return new string(str.ToCharArray().Distinct().ToArray());
        }
        public string RemoveDuplicateChar1(string str)
        { string newString = "";
           List <char> list = new List <char>();
            foreach (char c in str) {
                if (list.Contains(c))
                {
                    continue;
                }
                list.Add(c);
                newString += c;
            }
            return newString;

        }

    }
}
