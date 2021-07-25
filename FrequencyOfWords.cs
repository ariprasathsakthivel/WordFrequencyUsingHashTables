using System;
using System.Collections.Generic;
using System.Text;

namespace WordFrequencyUsingHashTables
{
    class FrequencyOfWords
    {
        Dictionary<string, int> wordCounts;
        public FrequencyOfWords()
        {
           this.wordCounts = new Dictionary<string, int>();
        }
        public void WordCounter(string sentence)
        {
            string[] words = sentence.Split(' ');
            foreach (string elements in words)
            {
                if (this.wordCounts.ContainsKey(elements))
                {
                    this.wordCounts[elements] += 1;
                }
                else
                {
                    this.wordCounts[elements] = 1;
                }
            }
            foreach (string key in this.wordCounts.Keys)
            {
                Console.WriteLine(key + "-->" + this.wordCounts[key]);
            }

        }
    }
}
