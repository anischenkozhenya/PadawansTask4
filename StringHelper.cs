using System;

namespace PadawansTask4
{
    public class StringHelper
    {
        public static int GetVowelCount(string str)
        {
            int gvc = 0;
            if (str == null)
            {
                throw new NotImplementedException();
            }
            char[] chr = str.ToCharArray();
            foreach (char i in chr)
            {
                if (Equals(i, 'a') || Equals(i, 'u') || Equals(i, 'i') || Equals(i, 'o') || Equals(i, 'e'))
                {
                    gvc++;
                }
            }
            return gvc;
        }
    }
}
