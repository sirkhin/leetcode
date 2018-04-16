using System.Collections.Generic;

/*
771. Jewels and Stones

You're given strings J representing the types of stones that are jewels, and S representing the stones you have.  Each character in S is a type of stone you have.  You want to know how many of the stones you have are also jewels.

The letters in J are guaranteed distinct, and all characters in J and S are letters. Letters are case sensitive, so "a" is considered a different type of stone from "A".

Example 1:

Input: J = "aA", S = "aAAbbbb"
Output: 3
Example 2:

Input: J = "z", S = "ZZ"
Output: 0
Note:

S and J will consist of letters and have length at most 50.
The characters in J are distinct.
 */

namespace _771_IntersectionFinder
{
    public class IntersectionCounter
    {
        public int CountIntersections(string J, string S)
        {
            if (string.IsNullOrEmpty(J) || string.IsNullOrEmpty(S))
            {
                return 0;
            }

            var charArrayToCompare = J.ToCharArray();

            var charHashSet = new HashSet<char>();

            foreach (char t in charArrayToCompare)
            {
                if (!charHashSet.Contains(t))
                {
                    charHashSet.Add(t);
                }
            }

            var intersectionCount = 0;

            var charArray = S.ToCharArray();

            foreach (char t in charArray)
            {
                if (charHashSet.Contains(t))
                {
                    intersectionCount++;
                }
            }

            return intersectionCount;
        }
    }
}
