/*
we design the following class member variables to store the states:
1. buffer – An array of size 4 use to store data returned by read4 temporarily. If
the characters were read into the buffer and were not used partially, they will
be used in the next call.

2. Buffer pointer (buffPtr) , offset – Use to keep track of the offset index 
where the data begins in the next read call. The buffer could be read partially 
(due to constraints of reading up to n bytes) and therefore leaving some data in it.

3. Buffer Counter (buffCnt), bufsize – The real buffer size that stores the actual data. 

we will use buffPtr to control copy data from the tem buffer to ouside large buf
if buffPtr < buffCnt, that means there's some char left in the buffer, we should copy them
first;
if buffPtr == buffCnt, that means we used all the char, should reload the buffer from file,
so reset buffPtr = 0, and buffCnt = Read4(buffer);

if buffCnt == 0, that means no char read from file, so we need break;

 */

/* The Read4 API is defined in the parent class Reader4.
      int Read4(char[] buf); */

public class Solution : Reader4 {
    /**
     * @param buf Destination buffer
     * @param n   Maximum number of characters to read
     * @return    The number of characters read
     */
    private char[] buffer = new char[4];
    private int buffPtr = 0; // buffer pointer
    private int buffCnt = 0; // buffer Counter
    public int Read(char[] buf, int n) {
        int ptr = 0; // pointer for buf
        while (ptr < n) {
            if (buffPtr == 0) {
                buffCnt = Read4(buffer);
            }
            if (buffCnt == 0) break; // reach end of file
            while (ptr < n && buffPtr < buffCnt) {
                buf[ptr++] = buffer[buffPtr++];
            }
            if (buffPtr == buffCnt) buffPtr = 0;
        }
        return ptr;
    }
}

/*
Next challenges: 
Decode Ways
Basic Calculator II
Parse Lisp Expression
 */