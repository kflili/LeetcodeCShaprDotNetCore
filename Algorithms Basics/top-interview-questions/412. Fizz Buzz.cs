public class Solution {
    public IList<string> FizzBuzz(int n) {
        List<string> res = new List<string>();
        for (int i = 1; i <= n; i++) {
            if (i % 15 == 0) {
                res.Add("FizzBuzz");
            } else if (i % 3 == 0) {
                res.Add("Fizz");
            } else if (i % 5 == 0) {
                res.Add("Buzz");
            } else {
                res.Add(i.ToString());
            }
        }
            return res;
    }
}

// without using %
public class Solution {
    public IList<string> FizzBuzz(int n) {
        List<string> res = new List<string>();
        for (int i = 1, fizz = 1, buzz = 1; i <= n; i++, fizz++, buzz++) {
            if (fizz == 3 && buzz == 5) {
                res.Add("FizzBuzz");
                fizz = 0;
                buzz = 0;
            } else if (fizz == 3) {
                res.Add("Fizz");
                fizz = 0;
            } else if (buzz == 5) {
                res.Add("Buzz");
                buzz = 0;
            } else {
                res.Add(i.ToString());
            }
        }
            return res;
    }
}