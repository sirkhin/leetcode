using System.Collections.Generic;

namespace MorseTransformationCounter
{
    /*
        804. Unique Morse Code Words

        International Morse Code defines a standard encoding where each letter is mapped to a series of dots and dashes, as follows: "a" maps to ".-", "b" maps to "-...", "c" maps to "-.-.", and so on.

        For convenience, the full table for the 26 letters of the English alphabet is given below:

        [".-","-...","-.-.","-..",".","..-.","--.","....","..",".---","-.-",".-..","--","-.","---",".--.","--.-",".-.","...","-","..-","...-",".--","-..-","-.--","--.."]
        Now, given a list of words, each word can be written as a concatenation of the Morse code of each letter. For example, "cab" can be written as "-.-.-....-", (which is the concatenation "-.-." + "-..." + ".-"). We'll call such a concatenation, the transformation of a word.

        Return the number of different transformations among all words we have.

        Example:
        Input: words = ["gin", "zen", "gig", "msg"]
        Output: 2
        Explanation: 
        The transformation of each word is:
        "gin" -> "--...-."
        "zen" -> "--...-."
        "gig" -> "--...--."
        "msg" -> "--...--."

        There are 2 different transformations, "--...-." and "--...--.".
 

        Note:

        The length of words will be at most 100.
        Each words[i] will have length in range [1, 12].
        words[i] will only consist of lowercase letters.
     */
    public class MorseTransformationCounter
    {
        private const char Dot = '.';
        private const char Dash = '−';

        private readonly Dictionary<char, string> _morseLetters = new Dictionary<char, string>()
        {
            {'a', string.Concat(Dot, Dash)},
            {'b', string.Concat(Dash, Dot, Dot, Dot)},
            {'c', string.Concat(Dash, Dot, Dash, Dot)},
            {'d', string.Concat(Dash, Dot, Dot)},
            {'e', Dot.ToString()},
            {'f', string.Concat(Dot, Dot, Dash, Dot)},
            {'g', string.Concat(Dash, Dash, Dot)},
            {'h', string.Concat(Dot, Dot, Dot, Dot)},
            {'i', string.Concat(Dot, Dot)},
            {'j', string.Concat(Dot, Dash, Dash, Dash)},
            {'k', string.Concat(Dash, Dot, Dash)},
            {'l', string.Concat(Dot, Dash, Dot, Dot)},
            {'m', string.Concat(Dash, Dash)},
            {'n', string.Concat(Dash, Dot)},
            {'o', string.Concat(Dash, Dash, Dash)},
            {'p', string.Concat(Dot, Dash, Dash, Dot)},
            {'q', string.Concat(Dash, Dash, Dot, Dash)},
            {'r', string.Concat(Dot, Dash, Dot)},
            {'s', string.Concat(Dot, Dot, Dot)},
            {'t', string.Concat(Dash)},
            {'u', string.Concat(Dot, Dot, Dash)},
            {'v', string.Concat(Dot, Dot, Dot, Dash)},
            {'w', string.Concat(Dot, Dash, Dash)},
            {'x', string.Concat(Dash, Dot, Dot, Dash)},
            {'y', string.Concat(Dash, Dot, Dash, Dash)},
            {'z', string.Concat(Dash, Dash, Dot, Dot)},
        };

        public int CountUniqueMorseTransformations(string[] words)
        {
            var uniqueTransformations = new HashSet<string>();

            foreach (string word in words)
            {
                if (string.IsNullOrEmpty(word))
                {
                    continue;
                }

                var morseWord = GetMorseWord(word);

                if (!uniqueTransformations.Contains(morseWord))
                {
                    uniqueTransformations.Add(morseWord);
                }
            }

            return uniqueTransformations.Count;
        }

        private string GetMorseWord(string word)
        {
            var wordCharArray = word.ToCharArray();

            var morseWord = string.Empty;

            foreach (var wordChar in wordCharArray)
            {
                var morseLetter = _morseLetters[wordChar];

                morseWord += morseLetter;
            }

            return morseWord;
        }
    }
}
