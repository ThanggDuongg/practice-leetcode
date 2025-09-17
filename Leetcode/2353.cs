namespace Leetcode
{
    internal class FoodRatings
    {
        private readonly Dictionary<string, string> FoodCuisine;
        private readonly Dictionary<string, int> FoodRating;
        private readonly Dictionary<string, SortedSet<(string, int)>> CuisineMap;

        public FoodRatings(string[] foods, string[] cuisines, int[] ratings)
        {
            var len = foods.Length;
            FoodCuisine = new Dictionary<string, string>(len);
            FoodRating = new Dictionary<string, int>(len);
            CuisineMap = [];

            for (int i = 0; i < len; i++)
            {
                var food = foods[i];
                var cuisine = cuisines[i];
                var rating = ratings[i];
                FoodCuisine[food] = cuisine;
                FoodRating[food] = rating;
                if (!CuisineMap.TryGetValue(cuisine, out SortedSet<(string, int)>? value))
                {
                    value = new SortedSet<(string, int)>(
                        Comparer<(string, int)>.Create(
                            (x, y) =>
                            {
                                var cmp = x.Item2.CompareTo(y.Item2);
                                if (cmp == 0)
                                {
                                    return y.Item1.CompareTo(x.Item1);
                                }
                                return cmp;
                            }
                        )
                    );
                    CuisineMap[cuisine] = value;
                }

                value.Add((food, rating));
            }
        }

        public void ChangeRating(string food, int newRating)
        {
            var cuisine = FoodCuisine[food];
            var currentRating = FoodRating[food];

            CuisineMap[cuisine].Remove((food, currentRating));
            CuisineMap[cuisine].Add((food, newRating));
            FoodRating[food] = newRating;
        }

        public string HighestRated(string cuisine)
        {
            return CuisineMap[cuisine].Max.Item1;
        }
    }
}
