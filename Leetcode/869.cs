namespace Leetcode
{
    internal class _869
    {
        public bool ReorderedPowerOf2(int n)
        {
            var digitCount = GetDigitCount(n);
            var intNum = 31; // long - 62
            for (int i = 0; i < intNum; i++)
            {
                var powerOf2Count = GetDigitCount(1 << i);
                if (IsSameCount(digitCount, powerOf2Count))
                {
                    return true;
                }
            }
            return false;
        }

        private bool IsSameCount(int[] a, int[] b)
        {
            for (int i = 0; i < 10; i++)
            {
                if (a[i] != b[i])
                {
                    return false;
                }
            }
            return true;
        }

        private int[] GetDigitCount(int n)
        {
            var count = new int[10];
            while (n > 0)
            {
                count[n % 10]++;
                n /= 10;
            }
            return count;
        }

        public bool ReorderedPowerOf2_1(int n)
        {
            var nums = GetNums(n);
            var used = new bool[nums.Length];

            return Backtrack(nums, used, []);
        }

        private bool Backtrack(int[] nums, bool[] used, List<int> current)
        {
            if (nums.Length == current.Count)
            {
                var number = MakeNumber(current);
                if (number > 0 && (number & (number - 1)) == 0)
                {
                    return true;
                }
                return false;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (used[i])
                {
                    continue;
                }

                if (i > 0 && nums[i] == nums[i - 1] && !used[i - 1])
                {
                    continue; // Skip duplicates
                }

                if (current.Count == 0 && nums[i] == 0)
                {
                    continue;
                }
                used[i] = true;
                current.Add(nums[i]);
                if (Backtrack(nums, used, current))
                {
                    return true;
                }
                used[i] = false;
                current.RemoveAt(current.Count - 1);
            }

            return false;
        }

        private int MakeNumber(List<int> nums)
        {
            int number = 0;
            for (int i = 0; i < nums.Count; i++)
            {
                number = number * 10 + nums[i];
            }
            return number;
        }

        private int[] GetNums(int n)
        {
            var digits = new List<int>();
            while (n > 0)
            {
                digits.Add(n % 10);
                n /= 10;
            }
            digits.Sort();
            return [.. digits];
        }
    }
}
