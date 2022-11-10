using System;
using System.Collections.Concurrent;
using System.Reflection.Metadata.Ecma335;

namespace Open_Lab_04._11
{
    public class StringTools
    {
        public string AlphabetSoup(string str)
        {
            char[] strInChar = str.ToCharArray();
            Array.Sort(strInChar);
            return new string(strInChar);
        }
       
    }
}
