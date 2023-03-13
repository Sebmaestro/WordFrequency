using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordFrequency
{
    /// <summary>
    /// Simple class to count words in a text and save the number of occurence for each word
    /// </summary>
    internal class WordCalculator
    {
        /// <summary>
        /// Calculates the amount of times a word occured in a text
        /// </summary>
        public void CalculateWords()
        {
            string text = File.ReadAllText("text.txt");

            char[] delimiter = { ' ', '.', ',', ';', ':', '?', '\n', '\r', '\t', '"', '(', ')', '-' };
            string[] words = text.Split(delimiter);
            Dictionary<string, int> wordCounts = new Dictionary<string, int>();

            foreach(string word in words)
            {
                //Converts all the words to lowercase
                string lowerCaseWord = word.ToLower();

                if (word.Length >= 2)
                {
                    if (wordCounts.ContainsKey(lowerCaseWord))
                    {
                        wordCounts[lowerCaseWord]++;
                    }
                    else if (!wordCounts.ContainsKey(lowerCaseWord))
                    {
                        wordCounts.Add(lowerCaseWord, 1);
                    }
                }                
            }
            //Sort by word occurence
            var sortedWordCounts = wordCounts.OrderByDescending(x => x.Value);

            PrintWords(sortedWordCounts);
        }

        /// <summary>
        /// Prints out the 10 most common words in the text and the number of occurrences 
        /// </summary>
        /// <param name="d"></param>
        private void PrintWords(IOrderedEnumerable<KeyValuePair<string, int>> d)
        {
            int count = 0;
            foreach (KeyValuePair<string, int> word in d)
            {
                if (count == 10)
                    return;
                Console.WriteLine("{0}: {1}", word.Key, word.Value);
                count++;
            }        
        }
    }
}
