using System;

namespace Answer
{
    public class Solution
    {
        public int HammingWeight(uint n)
        {
            uint c = 0;
            n = n - ((n >> 1) & 0x55555555);
            n = (n & 0x33333333) + ((n >> 2) & 0x33333333);
            c = ((n + (n >> 4) & 0xF0F0F0F) * 0x1010101) >> 24;
            return unchecked((int)c);
        }
    }
}
