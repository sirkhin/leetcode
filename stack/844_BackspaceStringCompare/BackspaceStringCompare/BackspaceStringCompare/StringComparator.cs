using System.Text;

namespace BackspaceStringCompare
{
    internal class StringComparator
    {
        public bool BackspaceCompare(string S, string T)
        {
            return BuildResultString(S) == BuildResultString(T);
        }
        public string BuildResultString(string s)
        {
            StringBuilder res = new StringBuilder();
            foreach (var c in s)
            {
                if (c == '#')
                {
                    if (res.Length > 0)
                    {
                        res.Remove(res.Length - 1, 1);
                    }
                }
                else
                {
                    res.Append(c);
                }
            }
            return res.ToString();
        }
    }
}
