public class Solution {
    public IList<string> GenerateParenthesis(int n) {
        var stack = new Stack<(string current, int open, int closed)>();
        var results = new List<string>(); 

        // Base case 
        stack.Push(("(", 1, 0));

        while (stack.Count != 0) {
            var (current, open, closed) = stack.Pop();

            if (open == n && closed == n) {
                results.Add(current);
                continue;
            }
                
            if (open < n)
                stack.Push((current + "(", open + 1, closed));

            if (open > closed)
                stack.Push((current + ")", open, closed + 1));
    
        }
        return results;
    }
}
