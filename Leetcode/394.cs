using System.Text;

namespace Leetcode
{
    internal class _394
    {
        public string DecodeString(string s)
        {
            var stack = new Stack<string>();
            var currentNum = 0;
            var currentStr = new StringBuilder();

            foreach (var c in s)
            {
                if (char.IsDigit(c))
                {
                    currentNum = currentNum * 10 + (c - '0');
                }
                else if (c == '[')
                {
                    stack.Push(currentStr.ToString());
                    stack.Push(currentNum.ToString());
                    currentStr.Clear();
                    currentNum = 0;
                }
                else if (c == ']')
                {
                    var numStr = stack.Pop();
                    var prevStr = stack.Pop();
                    int repeatCount = int.Parse(numStr);
                    var repeatedStr = new StringBuilder();
                    for (int i = 0; i < repeatCount; i++)
                    {
                        repeatedStr.Append(currentStr);
                    }
                    currentStr.Clear();
                    currentStr.Append(prevStr).Append(repeatedStr);
                }
                else
                {
                    currentStr.Append(c);
                }
            }

            return currentStr.ToString();
        }
    }
}
