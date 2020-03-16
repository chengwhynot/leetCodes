using System;
using System.Text;

namespace compress_string_lcci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Solution
    {
        public string CompressString(string S)
        {
            int x = 0;
            int y = 0;
            StringBuilder sb = new StringBuilder();

            while (x < S.Length)
            {
                sb.Append(S[x]);
                while (y < S.Length && (S[x] == S[y]))
                {
                    y++;
                }
                sb.Append(y - x);
                x = y;
            }
            var r = sb.ToString();
            if (r.Length < S.Length)
                return r;
            return S;
        }
    }
}
