namespace Leetcode
{
    public class TaskManager
    {
        private readonly Dictionary<int, int> TaskUser = [];
        private readonly Dictionary<int, int> TaskPriority = [];
        private PriorityQueue<(int taskId, int priority), (int negPriority, int negTaskId)> Pq =
            new();

        public TaskManager(IList<IList<int>> tasks)
        {
            foreach (var t in tasks)
            {
                Add(t[0], t[1], t[2]);
            }
        }

        public void Add(int userId, int taskId, int priority)
        {
            TaskUser[taskId] = userId;
            TaskPriority[taskId] = priority;
            Pq.Enqueue((taskId, priority), (-priority, -taskId));
        }

        public void Edit(int taskId, int newPriority)
        {
            TaskPriority[taskId] = newPriority;
            Pq.Enqueue((taskId, newPriority), (-newPriority, -taskId));
        }

        public void Rmv(int taskId)
        {
            TaskUser.Remove(taskId);
            TaskPriority.Remove(taskId);
        }

        public int ExecTop()
        {
            while (Pq.Count > 0)
            {
                var (taskId, priority) = Pq.Dequeue();

                if (!TaskPriority.ContainsKey(taskId))
                {
                    continue;
                }

                int correctPriority = TaskPriority[taskId];
                if (priority != correctPriority)
                {
                    continue;
                }

                int userId = TaskUser[taskId];
                Rmv(taskId);
                return userId;
            }

            return -1;
        }
    }
}
