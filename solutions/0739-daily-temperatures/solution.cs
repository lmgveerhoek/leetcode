using System.Globalization;

public class Solution
{
    public int[] DailyTemperatures(int[] temperatures)
    {
        var answer = new int[temperatures.Length];
        var stack = new Stack<int>();

        for (int i = 0; i < temperatures.Length; i++)
        {
            while (stack.Count > 0 && temperatures[i] > temperatures[stack.Peek()]) {
                var prevIndex = stack.Pop();
                answer[prevIndex] = i - prevIndex;
            } 
            stack.Push(i);
        }
        return answer;
    }
}
