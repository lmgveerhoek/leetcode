public class Solution
{
    public int EvalRPN(string[] tokens)
    {
        var tokenStack = new Stack<int>();
        var opSet = new HashSet<string>() { "+", "*", "/", "-" };

        foreach (var token in tokens)
        {
            if (!opSet.Contains(token))
            {
                tokenStack.Push(int.Parse(token));
                continue;
            }

            var op2 = tokenStack.Pop();
            var op1 = tokenStack.Pop();
            switch (token)
            {
                case "+":
                    tokenStack.Push(op1 + op2);
                    break;
                case "*":
                    tokenStack.Push(op1 * op2);
                    break;
                case "/":
                    tokenStack.Push(op1 / op2);
                    break;
                case "-":
                    tokenStack.Push(op1 - op2);
                    break;
                default:
                    break;
            }
        }

        return tokenStack.Pop();
    }
}
