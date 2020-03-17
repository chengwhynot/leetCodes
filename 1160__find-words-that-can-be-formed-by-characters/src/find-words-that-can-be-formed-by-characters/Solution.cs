using System;
using System.Collections.Generic;

namespace find_words_that_can_be_formed_by_characters
{
    public class Solution
    {
        public int CountCharacters(string[] words, string chars)
        {
            var returnCounts = 0;

            var baseDict = new Dictionary<char, int>();
            foreach (var c in chars)
            {
                if (baseDict.ContainsKey(c))
                    baseDict[c] = baseDict[c] + 1;
                else
                    baseDict.Add(c, 1);
            }

            foreach (var word in words)
            {
                var dictWord = new Dictionary<char, int>();
                bool charNotFound = false;
                foreach (var c in word)
                {
                    if (!baseDict.ContainsKey(c))
                    {
                        charNotFound = true;
                        break;
                    }
                    else
                    {
                        if (dictWord.ContainsKey(c))
                            dictWord[c] = dictWord[c] + 1;
                        else
                            dictWord.Add(c, 1);
                    }
                }
                bool charExceedChars = false;
                if (!charNotFound)
                {
                    foreach (var item in dictWord)
                    {
                        if(item.Value > baseDict[item.Key])
                        {
                            charExceedChars = true;
                            break;
                        }
                    }
                }
                if(!charExceedChars && !charNotFound)
                {
                    returnCounts += word.Length;
                }
            }

            return returnCounts;
        }
    }
}
