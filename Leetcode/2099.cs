namespace Leetcode
{
    class _2099
    {
        public int[] MaxSubsequence(int[] nums, int k)
        {
            var track = new List<(int, int)>();

            for (int i = 0; i < nums.Length; i++)
            {
                track.Add((nums[i], i));
            }

            return
            [
                .. track
                    .OrderBy(x => x.Item1)
                    .TakeLast(k)
                    .OrderByDescending(x => x.Item2)
                    .Select(x => x.Item1),
            ];
        }
    }
}
