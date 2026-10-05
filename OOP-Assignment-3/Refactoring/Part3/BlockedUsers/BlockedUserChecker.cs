using System.Diagnostics;

namespace Refactoring.Part3.BlockedUsers
{
    public static class BlockedUserChecker
    {
        public static int CountBlocked(HashSet<int> blockedIds, int[] requestIds)
        {
            var blocked = 0;
            foreach (var id in requestIds)
            {
                if (blockedIds.Contains(id))
                    blocked++;
            }
            return blocked;
        }

        public static HashSet<int> BuildBlockedIds(int count)
        {
            var blockedIds = new HashSet<int>();
            for (var i = 0; i < count; i++)
                blockedIds.Add(i);
            return blockedIds;
        }

        public static int[] BuildRequestIds(int count, int maxId, int seed = 42)
        {
            var rnd = new Random(seed);
            var ids = new int[count];
            for (var i = 0; i < count; i++)
                ids[i] = rnd.Next(maxId);
            return ids;
        }

        public static long MeasureMs(HashSet<int> blockedIds, int[] requestIds, out int found)
        {
            var sw = Stopwatch.StartNew();
            found = CountBlocked(blockedIds, requestIds);
            sw.Stop();
            return sw.ElapsedMilliseconds;
        }
    }
}
