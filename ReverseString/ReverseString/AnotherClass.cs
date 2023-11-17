using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    internal class AnotherClass
    {
        public static string Rstring(string s)
        {
            StringBuilder ReverseStringBuilder = new StringBuilder();

            for (int i = s.Length - 1;i>=0;i--)
            {
                ReverseStringBuilder.Append(s[i]);
            }
            return ReverseStringBuilder.ToString();
        }
    }
}
