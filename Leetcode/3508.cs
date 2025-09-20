namespace Leetcode
{
    public class Router
    {
        private sealed record Data(int Source, int Destination, int Timestamp);

        private readonly SortedSet<Data> Stored;
        private readonly Queue<Data> Items;
        private readonly Dictionary<int, List<int>> DestinationTimestamps;
        private readonly int MemoryLimit;

        public Router(int memoryLimit)
        {
            Stored = new SortedSet<Data>(
                Comparer<Data>.Create(
                    (x, y) =>
                    {
                        var cmp = x.Timestamp.CompareTo(y.Timestamp);
                        if (cmp == 0)
                        {
                            cmp = x.Destination.CompareTo(y.Destination);
                            if (cmp == 0)
                            {
                                cmp = x.Source.CompareTo(y.Source);
                            }
                        }
                        return cmp;
                    }
                )
            );
            Items = new Queue<Data>();
            DestinationTimestamps = [];
            MemoryLimit = memoryLimit;
        }

        public bool AddPacket(int source, int destination, int timestamp)
        {
            var newItem = new Data(source, destination, timestamp);
            if (Stored.Contains(newItem))
            {
                return false;
            }

            if (Items.Count >= MemoryLimit)
            {
                var oldestItem = Items.Dequeue();
                Stored.Remove(oldestItem);
                RemoveIndex(oldestItem.Destination);
            }
            AddIndex(destination, timestamp);
            Stored.Add(newItem);
            Items.Enqueue(newItem);
            return true;
        }

        public int[] ForwardPacket()
        {
            if (Items.Count == 0)
            {
                return [];
            }

            var packet = Items.Dequeue();
            Stored.Remove(packet);
            RemoveIndex(packet.Destination);
            return [packet.Source, packet.Destination, packet.Timestamp];
        }

        public int GetCount(int destination, int startTime, int endTime)
        {
            if (!DestinationTimestamps.TryGetValue(destination, out var timestamps))
            {
                return 0;
            }

            int l = 0,
                r = timestamps.Count;
            while (l < r)
            {
                var m = l + (r - l) / 2;
                if (timestamps[m] < startTime)
                {
                    l = m + 1;
                }
                else
                {
                    r = m;
                }
            }
            var left = l;

            l = 0;
            r = timestamps.Count;
            while (l < r)
            {
                var m = l + (r - l) / 2;
                if (timestamps[m] <= endTime)
                {
                    l = m + 1;
                }
                else
                {
                    r = m;
                }
            }
            int right = l - 1;

            if (left > right)
            {
                return 0;
            }

            return right - left + 1;
        }

        private void AddIndex(int destination, int timestamp)
        {
            if (!DestinationTimestamps.TryGetValue(destination, out var timestamps))
            {
                timestamps = [];
                DestinationTimestamps[destination] = timestamps;
            }
            timestamps.Add(timestamp);
        }

        private void RemoveIndex(int destination)
        {
            if (!DestinationTimestamps.TryGetValue(destination, out var timestamps))
            {
                return;
            }

            if (timestamps.Count > 0)
            {
                timestamps.RemoveAt(0);
            }
        }
    }
}
