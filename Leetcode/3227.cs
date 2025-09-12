namespace Leetcode
{
    internal class _3227
    {
        public bool DoesAliceWin(string s)
        {
            var vowels = "aeiou";
            foreach (var item in s)
            {
                if (vowels.Contains(item))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
