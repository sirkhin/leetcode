namespace FindFriendCircles
{
    public class WeightedUnionFind
    {
        private int[] _id;
        private int[] _size;

        public int FriendCirclesCount;

        public WeightedUnionFind(int n)
        {
            _id = new int[n];
            _size = new int[n];
            FriendCirclesCount = n;

            for (int i = 0; i < n; i++)
            {
                _id[i] = i;
                _size[i] = 1;
            }
        }

        public void Union(int p, int q, int shouldBeConnected)
        {
            if (!Connected(p, q) && shouldBeConnected == 1)
            {
                int pid = Root(p);
                int qid = Root(q);

                if (_size[p] >= _size[q])
                {
                    _id[qid] = pid;
                    _size[p] += _size[q];
                }
                else
                {
                    _id[pid] = qid;
                    _size[q] += _size[p];
                }

                FriendCirclesCount--;
            }
        }

        private bool Connected(int p, int q)
        {
            return Root(p) == Root(q);
        }

        private int Root(int i)
        {
            while (_id[i] != i)
            {
                i = _id[i];
            }

            return i;
        }
    }
}
