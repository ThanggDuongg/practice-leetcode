namespace Leetcode
{
    class _1432
    {
        public int MaxDiff(int num)
        {
            var numString = num.ToString();
            var tempString = numString;

            int i = 0;
            while (i < numString.Length && numString[i] == '9')
            {
                i++;
            }

            if (i < numString.Length)
            {
                numString = numString.Replace(numString[i], '9');
            }

            i = 0;
            if (tempString[i] != '1')
            {
                tempString = tempString.Replace(tempString[i], '1');
            }
            else
            {
                ++i;
                while (i < tempString.Length)
                {
                    if (tempString[i] != '0' && tempString[i] != tempString[0])
                    {
                        break;
                    }
                    i++;
                }
                if (i < tempString.Length)
                {
                    tempString = tempString.Replace(tempString[i], '0');
                }
            }

            return int.Parse(numString) - int.Parse(tempString);
        }
    }
}
