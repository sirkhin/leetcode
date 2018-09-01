using System.Linq;

namespace NumberOfIslands
{
    public class UnionFind
    {
        private int[] _id;

        private int _i;

        private int _j;

        public UnionFind(int i, int j)
        {
            _i = i;
            _j = j;
            _id = new int[_i * _j];

            for (var index = 0; index < i * j; index++)
            {
                _id[index] = -1;
            }
        }

        public int NumberOfComponents => _id.Where(i => i > -1).Distinct().Count();

        public void Put(int i, int j)
        {
            if (CanConnect(i, j))
            {
                Union(i, j);
            }
            else
            {
                _id[i * _j + j] = i * _j + j;
            }
        }

        private bool CanConnect(int i, int j)
        {
            return CanConnectUp(i, j) || CanConnectLeft(i, j);
        }

        private bool CanConnectUp(int i, int j)
        {
            return i * _j + j - _j > -1 && Root(i * _j + j - _j) != -1;
        }

        private bool CanConnectLeft(int i, int j)
        {
            return i * _j - 1 + j > -1 && Root(i * _j - 1 + j) != -1;
        }

        private void Union(int i, int j)
        {
            var upRoot = -1;
            var leftRoot = -1;
            if (CanConnectUp(i, j))
            {
                upRoot = Root(i * _j + j - _j);
            }
            if (CanConnectLeft(i, j))
            {
                leftRoot = Root(i * _j - 1 + j);
            }

            if ((upRoot <= leftRoot && upRoot > -1) || leftRoot == -1)
            {
                _id[i * _j + j] = upRoot;
                if (leftRoot > -1)
                {
                    _id[leftRoot] = upRoot;
                }
            }
            else if ((leftRoot < upRoot && leftRoot > -1) || upRoot == -1)
            {
                _id[i * _j + j] = leftRoot;
                if (upRoot > -1)
                {
                    _id[upRoot] = leftRoot;
                }
            }
        }

        private int Root(int index)
        {
            while (_id[index] != index)
            {
                index = _id[index];

                if (index == -1)
                {
                    break;
                }
            }

            return index;
        }
    }
}
