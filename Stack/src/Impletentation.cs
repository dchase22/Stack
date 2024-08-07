using System.Text;

public class Stack 
{
    private List<int> stack;

    public Stack()
    {
        stack = new List<int>();
    }

    public Stack(List<int> stack)
    {
        this.stack = stack;
    }

    public void push(int value)
    {
        stack.Add(value);
    }

    public int pop()
    {
        var num = stack.Last();
        stack.RemoveAt(stack.Count - 1);
        return num;
    }

    public bool isEmpty()
    {
        return stack.Count == 0;
    }

    public int size()
    {
        return stack.Count;
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("Stack: ");

        for (int i = stack.Count - 1; i >= 0; i--)
        {
            sb.Append(stack[i]);
            if (i > 0)
                sb.Append(", ");
        }

        return sb.ToString();
    }

}