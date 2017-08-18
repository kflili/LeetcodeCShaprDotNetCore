public class Solution {
    public List<int> SlidingWindowFindSubString(String s, String t) {
        List<int> result = new List<int>();
        if (t.Length > s.Length) return result;
        // init a HashTable (K, V) = (Character, Frequence of the Characters)
        Dictionary<char, int> map = new Dictionary<char, int>();
        foreach (char c in t.ToCharArray()) { map[c]++; }
        //maintain a counter to check whether match the target string.
        int counter = t.Length; // could be the map.count or t.Length
        int begin = 0, end = 0; // Two Pointers for window boundary
        while (end < s.Length) {
            // keep moving end by end++
            if (map[s[end++]]-- > 0 /* may be other condition */)
                counter--;/* modify counter here */ 
            while (counter == 0 /* may be other counter condition */) {
                // !!!Note: when counter == 0, the window size is >= p.Length. no way for < p.Length

                // add the index to result list if meet certen condition
                if (end - begin == p.Length) { result.add(begom); }
                // move the begin to narrow the window size
                if (map[s[begin++]]++ >= 0 /* or other condition */) 
                    counter++;/* modify the counter here */
            }
        }
        return result;
    }
}