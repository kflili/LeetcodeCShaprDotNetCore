public class Solution {
    public uint reverseBits(uint n) {
        if (n == 0) return n;
        uint result = 0;
        for (int i = 0; i < 32; i++) {
            result = (result << 1) + n & 1; // OR(|) is cheaper than ADD(+)
            n >>= 1; 
        }
        return result;
    }
}
// Optimization:
// We can divide an uint into 4 bytes, and reverse each byte then combine into 
// an uint. For each byte, we can use cache to improve performance.