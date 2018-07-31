namespace RedundantConnection
{
    class WeightedUnionFind
    {
        private int[] _id;
        private int[] _size;

        public WeightedUnionFind(int n)
        {
            _id = new int[n + 1];
            _size = new int[n + 1];

            for (int i = 1; i < n + 1; i++)
            {
                _id[i] = i;
                _size[i] = 1;
            }
        }

        public void Union(int p, int q)
        {
            if (!Connected(p, q))
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
            }
        }

        public bool Connected(int p, int q)
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
