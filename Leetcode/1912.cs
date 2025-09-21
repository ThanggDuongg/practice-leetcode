namespace Leetcode
{
    public class MovieRentingSystem
    {
        private sealed record Data(int movie, int shop);

        private sealed record RentedData(int movie, int price, int shop);

        private sealed record UnrentedData(int price, int shop);

        private readonly Dictionary<Data, int> DataStored;
        private readonly SortedSet<RentedData> RentedStored;
        private readonly Dictionary<int, SortedSet<UnrentedData>> UnrentedMovies;

        public MovieRentingSystem(int n, int[][] entries)
        {
            DataStored = [];
            UnrentedMovies = [];
            RentedStored = new SortedSet<RentedData>(
                Comparer<RentedData>.Create(
                    (x, y) =>
                    {
                        var cmp = x.price.CompareTo(y.price);
                        if (cmp == 0)
                        {
                            cmp = x.shop.CompareTo(y.shop);
                            if (cmp == 0)
                            {
                                cmp = x.movie.CompareTo(y.movie);
                            }
                        }
                        return cmp;
                    }
                )
            );

            foreach (var entry in entries)
            {
                var shop = entry[0];
                var movie = entry[1];
                var price = entry[2];
                DataStored[new(movie, shop)] = price;

                if (!UnrentedMovies.TryGetValue(movie, out var list))
                {
                    list = new SortedSet<UnrentedData>(
                        Comparer<UnrentedData>.Create(
                            (x, y) =>
                            {
                                var cmp = x.price.CompareTo(y.price);
                                if (cmp == 0)
                                {
                                    cmp = x.shop.CompareTo(y.shop);
                                }
                                return cmp;
                            }
                        )
                    );
                    UnrentedMovies[movie] = list;
                }
                list.Add(new(price, shop));
            }
        }

        public IList<int> Search(int movie)
        {
            if (UnrentedMovies.TryGetValue(movie, out var res))
            {
                return [.. res.Take(5).Select(x => x.shop)];
            }
            return [];
        }

        public void Rent(int shop, int movie)
        {
            var price = DataStored[new(movie, shop)];
            RentedStored.Add(new(movie, price, shop));
            UnrentedMovies[movie].Remove(new(price, shop));
        }

        public void Drop(int shop, int movie)
        {
            var price = DataStored[new(movie, shop)];
            RentedStored.Remove(new(movie, price, shop));
            UnrentedMovies[movie].Add(new(price, shop));
        }

        public IList<IList<int>> Report()
        {
            var res = RentedStored.Take(5).Select(x => (IList<int>)[x.shop, x.movie]).ToList();
            return res;
        }
    }
}
