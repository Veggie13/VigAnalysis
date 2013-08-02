using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VigAnalysis
{
    class Program
    {
        static void Main(string[] args)
        {
            var buckets = new char[][] {
                "E".ToCharArray(),
                "TAOI".ToCharArray(),
                "NSHR".ToCharArray(),
                "DL".ToCharArray(),
                "CUMW".ToCharArray(),
                "FGYP".ToCharArray(),
                "BVK".ToCharArray(),
                "JXQZ".ToCharArray()
            };

            string cipherText = "";
            
            for (int keyLen = 3; keyLen <= 9; keyLen++)
            {
                var charSets = new List<char>[keyLen];
                for (int offset = 0; offset < keyLen; offset++)
                {
                    charSets[offset] = new List<char>();
                    for (int i = offset; i < cipherText.Length; i += keyLen)
                    {
                        charSets[offset].Add(cipherText[i]);
                    }
                }

            }
        }
    }
}
