namespace Leetcode
{
    internal class _966
    {
        public string[] Spellchecker(string[] wordlist, string[] queries)
        {
            var wordSet = wordlist.ToHashSet();

            for (int i = 0; i < queries.Length; i++)
            {
                if (wordSet.TryGetValue(queries[i], out var val))
                {
                    queries[i] = val;
                    continue;
                }
                else if (wordSet.Contains(queries[i], StringComparer.OrdinalIgnoreCase))
                {
                    queries[i] = wordSet.First(x =>
                        string.Equals(x, queries[i], StringComparison.OrdinalIgnoreCase)
                    );
                    continue;
                }

                var resQuery = "";
                foreach (var word in wordlist)
                {
                    if (word.Length != queries[i].Length)
                    {
                        continue;
                    }

                    var match = true;
                    for (int j = 0; j < word.Length; j++)
                    {
                        if (
                            char.ToLower(word[j]) != char.ToLower(queries[i][j])
                            && !(
                                "aeiou".Contains(char.ToLower(queries[i][j]))
                                && "aeiou".Contains(char.ToLower(word[j]))
                            )
                        )
                        {
                            match = false;
                            break;
                        }
                    }
                    if (match)
                    {
                        resQuery = word;
                        break;
                    }
                }

                queries[i] = resQuery;
            }

            return queries;
        }
    }
}
