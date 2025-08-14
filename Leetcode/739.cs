namespace Leetcode
{
    internal class _739
    {
        public int[] DailyTemperatures(int[] temperatures)
        {
            var res = new int[temperatures.Length];
            var stack = new Stack<int>();

            for (int i = 0; i < temperatures.Length; i++)
            {
                while (stack.Count > 0 && temperatures[i] > temperatures[stack.Peek()])
                {
                    var idx = stack.Pop();
                    res[idx] = i - idx;
                }
                stack.Push(i);
            }

            return res;
        }
    }
}
