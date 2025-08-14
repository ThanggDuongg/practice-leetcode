namespace Leetcode
{
    internal class _2264
    {
        public string LargestGoodInteger(string num)
        {
            int i = 0,
                currentMax = -1;

            while (i < num.Length)
            {
                if (i + 2 > num.Length - 1)
                {
                    break;
                }

                var isValid = num[i] == num[i + 1] && num[i] == num[i + 2];
                if (isValid)
                {
                    i += 2;
                    var newValue = num[i] - '0';
                    if (newValue > currentMax)
                    {
                        currentMax = newValue;
                    }
                }
                else
                {
                    i++;
                }
            }

            return currentMax != -1 ? $"{currentMax}{currentMax}{currentMax}" : string.Empty;
        }
    }
}
