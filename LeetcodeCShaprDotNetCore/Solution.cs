using System;
using System.Collections.Generic;
using System.Text;

namespace LeetcodeCShaprDotNetCore
{

    public class Solution
    {
        public IList<string> FindMissingRanges(int[] vals, int start, int end)
        {
            var ranges = new List<string>();
            int prev = start - 1;
            for (int i = 0; i <= vals.Length; i++)
            {
                int curr = (i == vals.Length) ? end + 1 : vals[i];
                var t = curr - prev;
                if (t > 1)
                {
                    ranges.Add(this.GetRange(prev + 1, curr - 1));
                }
                prev = curr;
            }
            return ranges;
        }
        private string GetRange(int from, int to)
        {
            return (from == to) ? from + "" : from + "->" + to;
        }
    }
}
