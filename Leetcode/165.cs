namespace Leetcode
{
    internal class _165
    {
        public int CompareVersion(string version1, string version2)
        {
            var v1 = version1.Split('.').Select(int.Parse).ToArray();
            var v2 = version2.Split('.').Select(int.Parse).ToArray();

            int n = Math.Max(v1.Length, v2.Length),
                i = 0;
            while (i < n)
            {
                var v1i = i < v1.Length ? v1[i] : 0;
                var v2i = i < v2.Length ? v2[i] : 0;

                if (v1i > v2i)
                {
                    return 1;
                }
                else if (v1i < v2i)
                {
                    return -1;
                }
                i++;
            }
            return 0;
        }
    }
}
