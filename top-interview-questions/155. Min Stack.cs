// use self defined node class with min field
public class MinStack {
    private Node top;
    /** initialize your data structure here. */
    public MinStack() {}
    public void Push(int x) {
        if (top == null) {
            top = new Node(x, x);
        } else {
            top = new Node(x, Math.Min(x, top.min), top);
        }
    }

    public void Pop() {
        if (top != null)
            top = top.next;
    }

    public int Top() {
        if (top != null) 
            return top.val;
        else 
            return -1;
    }

    public int GetMin() {
        if (top != null)
            return top.min;
        else
            return -1;
    }

    private class Node {
        public int val;
        public int min;
        public Node next;
        
        public Node (int val, int min) : this(val, min, null) {

        }
        public Node (int val, int min, Node next) {
            this.val = val;
            this.min = min;
            this.next = next;
        }
    }
}

// two stack, one for normal num, one for min number,
// push and pop together.
public void Push(int number) {
    stack.Push(number);
    if (minStack.Count > 0) {
        minStack.Push(number);
    } else {
        minStack.Push(Math.Min(number, minStack.Peek()));
    }
}

public int Pop() {
    minStack.Pop();
    return stack.Pop();
}

// one stack
class MinStack {
    int min = Integer.MAX_VALUE;
    Stack<int> stack = new Stack<int>();
    public void Push(int x) {
        // only push the old minimum value when the current 
        // minimum value changes after pushing the new value x
        if(x <= min){          
            stack.Push(min);
            min=x;
        }
        stack.Push(x);
    }

    public void Pop() {
        // if Pop operation could result in the changing of the current minimum value, 
        // Pop twice and change the current minimum value to the last minimum value.
        if(stack.Pop() == min) min=stack.Pop();
    }

    public int Top() {
        return stack.Peek();
    }

    public int GetMin() {
        return min;
    }
}


/**
* Your MinStack object will be instantiated and called as such:
* MinStack obj = new MinStack();
* objPPush(x);
* obj.Pop();
* int param_3 = obj.Top();
* int param_4 = obj.GetMin();
*/