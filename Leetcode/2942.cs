namespace Leetcode
{
    class _2942
    {
        public IList<int> FindWordsContaining(string[] words, char x)
        {
            int i = 0;
            var res = new List<int>();
            foreach (var word in words)
            {
                foreach (var c in word)
                {
                    if (c == x)
                    {
                        res.Add(i);
                        break;
                    }
                }
                i++;
            }
            return res;
        }
    }
}
