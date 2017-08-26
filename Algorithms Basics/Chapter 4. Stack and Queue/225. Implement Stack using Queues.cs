public class MyStack {
    private Queue<int> q1;

    /** Initialize your data structure here. */
    public MyStack() {
        q1 = new Queue<int>();
    }

    /** Push element x onto stack. */
    public void Push(int x) {
        q1.Enqueue(x);
        int size = q1.Count;
        while (size-- > 1) {
            int temp = q1.Dequeue();
            q1.Enqueue(temp);
        }
    }

    /** Removes the element on top of the stack and returns that element. */
    public int Pop() {
        int top = q1.Dequeue();
        return top;
    }

    /** Get the top element. */
    public int Top() {
        return q1.Peek();
    }

    /** Returns whether the stack is empty. */
    public bool Empty() {
        return q1.Count == 0;
    }
}

/**
    * Your MyStack object will be instantiated and called as such:
    * MyStack obj = new MyStack();
    * obj.Push(x);
    * int param_2 = obj.Pop();
    * int param_3 = obj.Top();
    * bool param_4 = obj.Empty();
    */