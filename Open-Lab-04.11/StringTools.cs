using System;
using System.Collections.Concurrent;
using System.Reflection.Metadata.Ecma335;

namespace Open_Lab_04._11
{
    public class StringTools
    {
        public string AlphabetSoup(string str)
        {
            char[] jano = str.ToCharArray();
            Array.Sort(jano);
            return new string(jano);
        }
       
    }
}
