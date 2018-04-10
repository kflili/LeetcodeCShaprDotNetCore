
/*
The API: int read4(char *buf) reads 4 characters at a time from a file. (note: copy from file to *buf)
The return value is the actual number of characters read. For example, it returns 3 if there
is only 3 characters left in the file.
 */
/* The Read4 API is defined in the parent class Reader4.
      int Read4(char[] buf);
 */

public class Solution : Reader4 {
    /**
     * @param buf Destination buffer
     * @param n   Maximum number of characters to read
     * @return    The number of characters read
     */
    public int Read(char[] buf, int n) {
        char[] temp = new char[4];
        int ptr = 0; //index for the buf
        while (ptr < n) {
            int buffCnt = Read4(temp);
            if (buffCnt == 0) break; // no more char from file, break;
            int cnt = Math.Min(buffCnt, n - ptr);
            for (int i = 0; i < cnt; i++) {
                buf[ptr++] = temp[i];
            }
        }
        return ptr;
    }
}


public class Solution : Reader4 {
    /**
     * @param buf Destination buffer
     * @param n   Maximum number of characters to read
     * @return    The number of characters read
     */
    public int Read(char[] buf, int n) {
        bool eof = false; // end of file flag
        int total = 0; // total bytes have been read
        char[] temp = new char[4]; // temp buffer for Reader 4
        while (!eof && total < n) {
            int count = Read4(temp);
            // check if it's the end of the file
            if (count < 4) eof = true;
            // get the actual count for this time read
            count = Math.Min(count, n - total);
            // copy from temp buffer to buf
            for (int i = 0; i < count; i++) {
                buf[total++] = temp[i];
            }
        }
        return total;
    }
}