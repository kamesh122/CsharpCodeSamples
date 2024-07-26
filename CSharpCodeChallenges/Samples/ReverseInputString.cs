using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCodeChallenges.Samples
{
    public class ReverseInputString
    {

        public char[] ReverseAllWords(char[] in_text)
        {
            int lindex = 0;
            int rindex = in_text.Length - 1;
            if (rindex > 1)
            {
                //reverse complete phrase
                in_text = ReverseString(in_text, lindex, rindex);

                //    //reverse each word in resultant reversed phrase
                //    for (rindex = 0; rindex <= in_text.Length; rindex++)
                //    {
                //        if (rindex == in_text.Length || in_text[rindex] == ' ')
                //        {
                //            in_text = ReverseString(in_text, lindex, rindex - 1);
                //            lindex = rindex + 1;
                //        }
                //    }
            }
            return in_text;
        }

        public char[] ReverseString(char[] intext, int lindex, int rindex)
        {
            char tempc;
            while (lindex < rindex)
            {
                tempc = intext[lindex];
                intext[lindex++] = intext[rindex];
                intext[rindex--] = tempc;
            }
            return intext;
        }

        public string ReverseString(string myString)
        {
            string reversedString = string.Empty;
            
            for (int i = myString.Length - 1; i >= 0; i--)
            {
                reversedString += myString[i];
            }

            return reversedString;
        }
    }
}
