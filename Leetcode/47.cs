namespace Leetcode
{
    internal class _47
    {
        public IList<IList<int>> PermuteUnique(int[] nums)
        {
            Array.Sort(nums);
            var result = new List<IList<int>>();
            Backtrack(nums, 0, result);
            return result;
        }

        private void Backtrack(int[] nums, int start, IList<IList<int>> result)
        {
            if (start == nums.Length)
            {
                result.Add([.. nums]);
                return;
            }

            var seen = new HashSet<int>();
            for (int i = start; i < nums.Length; i++)
            {
                if (seen.Contains(nums[i]))
                {
                    continue; // Skip duplicates
                }
                seen.Add(nums[i]);
                (nums[i], nums[start]) = (nums[start], nums[i]);
                Backtrack(nums, start + 1, result);
                (nums[i], nums[start]) = (nums[start], nums[i]);
            }
        }

        //private void Backtrack(int[] nums, bool[] used, List<int> current, IList<IList<int>> result)
        //{
        //    if (current.Count == nums.Length)
        //    {
        //        result.Add([.. current]);
        //        return;
        //    }

        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        if (used[i])
        //        {
        //            continue;
        //        }

        //        if (i > 0 && nums[i] == nums[i - 1] && !used[i - 1])
        //        {
        //            continue; // Skip duplicates
        //        }

        //        used[i] = true;
        //        current.Add(nums[i]);
        //        Backtrack(nums, used, current, result);
        //        used[i] = false;
        //        current.RemoveAt(current.Count - 1);
        //    }
        //}
    }
}
