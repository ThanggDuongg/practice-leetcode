namespace Leetcode
{
  internal class _1792
  {
    public double MaxAverageRatio(int[][] classes, int extraStudents)
    {
      var priority = new PriorityQueue<(int pass, int total), double>(
        Comparer<double>.Create((x, y) => y.CompareTo(x))
      );

      var res = 0d;
      foreach (var cls in classes)
      {
        var pass = cls[0];
        var total = cls[1];
        var currentRatio = (double)pass / total;
        var newRatio = (double)(pass + 1) / (total + 1);
        var diff = newRatio - currentRatio;
        priority.Enqueue((pass, total), diff);
        res += (double)pass / total;
      }

      while (extraStudents > 0)
      {
        var (pass, total) = priority.Dequeue();
        res -= (double)pass / total;
        pass++;
        total++;
        var currentRatio = (double)pass / total;
        var newRatio = (double)(pass + 1) / (total + 1);
        res += currentRatio;
        var diff = newRatio - currentRatio;
        priority.Enqueue((pass, total), diff);
        extraStudents--;
      }

      return res / classes.Length;
    }
  }
}
