namespace Leetcode
{
    class _2566
    {
        public int MinMaxDifference(int num)
        {
            var numString = num.ToString();
            var tempString = numString;

            var i = 0;
            while (i < numString.Length && numString[i] == '9')
            {
                i++;
            }

            if (i < numString.Length)
            {
                numString = numString.Replace(numString[i], '9');
            }
            tempString = tempString.Replace(tempString[0], '0');
            return int.Parse(numString) - int.Parse(tempString);
        }
    }
}
