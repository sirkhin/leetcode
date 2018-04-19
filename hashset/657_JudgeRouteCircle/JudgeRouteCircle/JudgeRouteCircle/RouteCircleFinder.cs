using System.Collections.Generic;

namespace JudgeRouteCircle
{
    /*
        657. Judge Route Circle

        Initially, there is a Robot at position (0, 0). Given a sequence of its moves, judge if this robot makes a circle, which means it moves back to the original place.

        The move sequence is represented by a string. And each move is represent by a character. The valid robot moves are R (Right), L (Left), U (Up) and D (down). The output should be true or false representing whether the robot makes a circle.

        Example 1:
        Input: "UD"
        Output: true
        Example 2:
        Input: "LL"
        Output: false
     */
    public class RouteCircleFinder
    {
        public bool CheckIfCircleRoute(string moves)
        {
            var movesDict = new Dictionary<char, int>();

            movesDict.Add('L', 1);
            movesDict.Add('R', 1);
            movesDict.Add('U', 1);
            movesDict.Add('D', 1);

            foreach (char t in moves)
            {
                if (movesDict.ContainsKey(t))
                {
                    movesDict[t]++;
                }
                else
                {
                    movesDict.Add(t, 1);
                }
            }

            return movesDict['L'] == movesDict['R'] && movesDict['U'] == movesDict['D'];
        }
    }
}
